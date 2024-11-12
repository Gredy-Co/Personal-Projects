using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    public partial class VenProveedoresCRUD : Form
    {
        public VenProveedoresCRUD()
        {
            InitializeComponent();
        }


        bool ConsultadoProveedor;

        int ID_ProveedorTemp;
        string NomProveedorTemp;
        string EstadoTemp;

        string Seccion = "Gestión De Proveedores";



        private void VenProveedoresCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoProveedor = false;
        }



        // Guarda al Proveedor en la base de datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Proveedor";
            int IDDis_Proveedor = DatosProveedor.ObtenerProximoIDDisponible();

            if (ConsultadoProveedor)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreProveedor.Texts))
            {
                MessageBox.Show("Debe ingresar el Nombre del Proveedor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Direccion.Texts))
            {
                MessageBox.Show("Debe ingresar una Dirección.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Ciudad.Texts))
            {
                MessageBox.Show("Debe ingresar la Cédula.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Pais.Texts))
            {
                MessageBox.Show("Debe ingresar un Nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Telefono.Texts))
            {
                MessageBox.Show("Debe ingresar el Primer Apellido.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe el proveedor 
                OBJProveedor proveedorExistente = DatosProveedor.ConsultarPorNombreProveedor(TxtBx_NombreProveedor.Texts.Trim());
                if (proveedorExistente != null)
                {
                    MessageBox.Show("Ya existe un proveedor con el mismo nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OBJProveedor objProveedor                   = new OBJProveedor();
                objProveedor.ID_Proveedor                   = IDDis_Proveedor;
                objProveedor.Nombre_Proveedor               = TxtBx_NombreProveedor.Texts.Trim();
                objProveedor.Direccion                      = TxtBx_Direccion.Texts.Trim();
                objProveedor.Ciudad                         = TxtBx_Ciudad.Texts.Trim();
                objProveedor.Pais                           = TxtBx_Pais.Texts.Trim();
                objProveedor.Telefono                       = TxtBx_Telefono.Texts.Trim();
                objProveedor.Correo                         = TxtBx_Correo.Texts.Trim();
                objProveedor.Categoria_Producto_Servicio    = TxtBx_CategoriaPS.Texts.Trim();
                objProveedor.Estado                         = "Activo";

                if (DatosProveedor.Guardar(objProveedor))
                {
                    MessageBox.Show("Proveedor Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                }
                else
                {
                    MessageBox.Show("No fue posible guardar los datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe revisar la información digitada.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Modifica al proveedor en la base de datos
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Proveedor";

            if (ConsultadoProveedor == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NombreProveedor.Texts))
            {
                MessageBox.Show("Debe ingresar el Nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el proveedor original
                    OBJProveedor datosDelProveedor = DatosProveedor.Consultar(NomProveedorTemp);
                    if (datosDelProveedor == null)
                    {
                        MessageBox.Show("El Proveedor no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el proveedor que se está modificando existe en la base de datos
                    OBJProveedor proveedorExistente = DatosProveedor.ConsultarPorIDProveedor(ID_ProveedorTemp);
                    if (proveedorExistente == null)
                    {
                        MessageBox.Show("El Proveedor que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del proveedor ya existe en la base de datos, excluyendo el proveedor que se está modificando actualmente
                    string nuevoNombreProveedor = TxtBx_NombreProveedor.Texts.Trim();
                    if (nuevoNombreProveedor != datosDelProveedor.Nombre_Proveedor)
                    {
                        OBJProveedor proveedorExistentePorNombre = DatosProveedor.ConsultarPorNombreProveedor(nuevoNombreProveedor);
                        if (proveedorExistentePorNombre != null && proveedorExistentePorNombre.ID_Proveedor != datosDelProveedor.ID_Proveedor)
                        {
                            MessageBox.Show("Ya existe un proveedor con el mismo nombre en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    // Crea un nuevo objeto proveedor para la modificación
                    OBJProveedor objProveedor = new OBJProveedor();
                    objProveedor.ID_Proveedor = datosDelProveedor.ID_Proveedor;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objProveedor.Nombre_Proveedor               = string.IsNullOrWhiteSpace(TxtBx_NombreProveedor.Texts)    ? datosDelProveedor.Nombre_Proveedor            : TxtBx_NombreProveedor.Texts.Trim();
                    objProveedor.Direccion                      = string.IsNullOrWhiteSpace(TxtBx_Direccion.Texts)          ? datosDelProveedor.Direccion                   : TxtBx_Direccion.Texts.Trim();
                    objProveedor.Ciudad                         = string.IsNullOrWhiteSpace(TxtBx_Ciudad.Texts)             ? datosDelProveedor.Ciudad                      : TxtBx_Ciudad.Texts.Trim();
                    objProveedor.Pais                           = string.IsNullOrWhiteSpace(TxtBx_Pais.Texts)               ? datosDelProveedor.Pais                        : TxtBx_Pais.Texts.Trim();
                    objProveedor.Telefono                       = string.IsNullOrWhiteSpace(TxtBx_Telefono.Texts)           ? datosDelProveedor.Telefono                    : TxtBx_Telefono.Texts.Trim();
                    objProveedor.Correo                         = string.IsNullOrWhiteSpace(TxtBx_Correo.Texts)             ? datosDelProveedor.Correo                      : TxtBx_Correo.Texts.Trim();
                    objProveedor.Categoria_Producto_Servicio    = string.IsNullOrWhiteSpace(TxtBx_CategoriaPS.Texts)        ? datosDelProveedor.Categoria_Producto_Servicio : TxtBx_CategoriaPS.Texts.Trim();

                    objProveedor.Estado = datosDelProveedor.Estado;

                    // Actualiza el proveedor en la base de datos
                    if (DatosProveedor.Actualizar(objProveedor))
                    {
                        MessageBox.Show("Datos del Proveedor modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Movimientos(Tipo_Mov);
                        LimpiarInformacion();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible modificar los datos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Consulta al proveedor en la base de datos
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Proveedor";

            if (TxtBx_NombreProveedor.Texts.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar el nombre del Proveedor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                OBJProveedor objProveedor = DatosProveedor.Consultar(TxtBx_NombreProveedor.Texts.Trim());
                if (objProveedor == null)
                {
                    MessageBox.Show("El Proveedor no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ID_ProveedorTemp            = objProveedor.ID_Proveedor;
                    TxtBx_NombreProveedor.Texts = objProveedor.Nombre_Proveedor;
                    NomProveedorTemp            = objProveedor.Nombre_Proveedor;
                    TxtBx_Direccion.Texts       = objProveedor.Direccion;
                    TxtBx_Ciudad.Texts          = objProveedor.Ciudad;
                    TxtBx_Pais.Texts            = objProveedor.Pais;
                    TxtBx_Telefono.Texts        = objProveedor.Telefono;
                    TxtBx_Correo.Texts          = objProveedor.Correo;
                    TxtBx_CategoriaPS.Texts     = objProveedor.Categoria_Producto_Servicio;
                    EstadoTemp                  = objProveedor.Estado;

                    ConsultadoProveedor = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }


        // Elimina al proveedor de la base de datos poniendo el Estado en Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Proveedor";

            if (ConsultadoProveedor == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el proveedor está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El proveedor ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al Proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJProveedor objProveedor   = new OBJProveedor();
                        objProveedor.ID_Proveedor   = ID_ProveedorTemp;
                        objProveedor.Estado         = "Inactivo";

                        if (DatosProveedor.CambiarEstado(objProveedor))
                        {
                            MessageBox.Show("Proveedor Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar al Proveedor.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva al proveedor de la base de datos poniendo el estado en Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Proveedor";

            if (ConsultadoProveedor == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el proveedor está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El proveedor ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar al Proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJProveedor objProveedor   = new OBJProveedor();
                        objProveedor.ID_Proveedor   = ID_ProveedorTemp;
                        objProveedor.Estado         = "Activo";

                        if (DatosProveedor.CambiarEstado(objProveedor))
                        {
                            MessageBox.Show("Proveedor Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar al Proveedor.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Guarda todos los movimientos en la Bitácora
        private void Movimientos(string tipo_mov)
        {
            DateTime FechaHora = DateTime.Now;

            DateTime Fecha = FechaHora.Date;

            TimeSpan Hora = FechaHora.TimeOfDay;

            int IDDis_Movimiento = DatosMovimiento.ObtenerProximoIDDisponible();
            int IDUSER = VenMenuPrincipal.ObtenerIDActivo();

            OBJMovimiento objMovimiento     = new OBJMovimiento();
            objMovimiento.ID_Movimiento     = IDDis_Movimiento;
            objMovimiento.ID_Usuario        = IDUSER;
            objMovimiento.Seccion           = Seccion;
            objMovimiento.Tipo_Movimiento   = tipo_mov;
            objMovimiento.Fecha_Movimiento  = Fecha;
            objMovimiento.Hora_Movimiento   = Hora;
            objMovimiento.Estado            = "Activo";

            // Guarda el movimiento en la base de datos
            if (DatosMovimiento.GuardarMovimiento(objMovimiento))
            {
            }
            else
            {
                MessageBox.Show("No fue posible registrar el movimiento.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LimpiarInformacion()
        {
            ConsultadoProveedor         = false;
            ID_ProveedorTemp            = 0;
            NomProveedorTemp            = "";

            TxtBx_NombreProveedor.Texts = "";
            TxtBx_Direccion.Texts       = "";
            TxtBx_Ciudad.Texts          = "";
            TxtBx_Pais.Texts            = "";
            TxtBx_Telefono.Texts        = "";
            TxtBx_Correo.Texts          = "";
            TxtBx_CategoriaPS.Texts     = "";
            EstadoTemp                  = "";
        }
    }
}
