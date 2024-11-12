using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Datos.Objetos;
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

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    public partial class VenVariedadDeFrutoCRUD : Form
    {
        public VenVariedadDeFrutoCRUD()
        {
            InitializeComponent();
        }



        bool ConsultadoVariedadDeFruto;

        int ID_FrutoTemp;
        string NombreFrutoTemp;
        string EstadoTemp;


        string Seccion = "Gestión Variedad De Fruto";



        private void VenVariedadDeFrutoCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoVariedadDeFruto = false;
        }



        // Guarda la variedad de fruto en la base de datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Variedad De Fruto";
            int IDDis_VariedadFruto = DatosVariedadDeFruto.ObtenerProximoIDDisponible();

            if (ConsultadoVariedadDeFruto)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreVariedad.Texts))
            {
                MessageBox.Show("Debe ingresar el nombre de Variedad Del Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe un fruto de la misma variedad
                OBJVariedadDeFruto frutoExistente = DatosVariedadDeFruto.Consultar(TxtBx_NombreVariedad.Texts.Trim());
                if (frutoExistente != null)
                {
                    MessageBox.Show("Ya existe un fruto de la misma variedad.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OBJVariedadDeFruto objVariedadDeFruto   = new OBJVariedadDeFruto();
                objVariedadDeFruto.ID_Variedad_Fruto    = IDDis_VariedadFruto;
                objVariedadDeFruto.Nombre_Variedad      = TxtBx_NombreVariedad.Texts.Trim();
                objVariedadDeFruto.Descripcion_Variedad = TxtBx_Descripcion.Texts.Trim();
                objVariedadDeFruto.Temporada_Cosecha    = TxtBx_TempCosecha.Texts.Trim();
                objVariedadDeFruto.Estado               = "Activo";

                if (DatosVariedadDeFruto.Guardar(objVariedadDeFruto))
                {
                    MessageBox.Show("Variedad De Fruto Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Modifica el fruto en la base de datos
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Variedad De Fruto";

            if (ConsultadoVariedadDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NombreVariedad.Texts))
            {
                MessageBox.Show("Debe ingresar el Nombre de la Variedad del Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el Fruto original
                    OBJVariedadDeFruto datosDelFruto = DatosVariedadDeFruto.Consultar(NombreFrutoTemp);
                    if (datosDelFruto == null)
                    {
                        MessageBox.Show("La Variedad de este Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el Fruto que se está modificando existe en la base de datos
                    OBJVariedadDeFruto frutoExistente = DatosVariedadDeFruto.ConsultarPorIDFruto(ID_FrutoTemp);
                    if (frutoExistente == null)
                    {
                        MessageBox.Show("La Variedad de este Fruto que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del fruto ya existe en la base de datos, excluyendo el fruto que se está modificando actualmente
                    string nuevoNombreFruto = TxtBx_NombreVariedad.Texts.Trim();
                    if (nuevoNombreFruto != datosDelFruto.Nombre_Variedad)
                    {
                        OBJVariedadDeFruto FrutoExistentePorNombre = DatosVariedadDeFruto.Consultar(nuevoNombreFruto);
                        if (FrutoExistentePorNombre != null && FrutoExistentePorNombre.ID_Variedad_Fruto != datosDelFruto.ID_Variedad_Fruto)
                        {
                            MessageBox.Show("Ya existe un fruto de la misma variedad en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Crea un nuevo objeto fruto para la modificación
                    OBJVariedadDeFruto objVariedadDeFruto = new OBJVariedadDeFruto();
                    objVariedadDeFruto.ID_Variedad_Fruto = datosDelFruto.ID_Variedad_Fruto;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objVariedadDeFruto.Nombre_Variedad          = string.IsNullOrWhiteSpace(TxtBx_NombreVariedad.Texts)     ? datosDelFruto.Nombre_Variedad         : TxtBx_NombreVariedad.Texts.Trim();
                    objVariedadDeFruto.Descripcion_Variedad     = string.IsNullOrWhiteSpace(TxtBx_Descripcion.Texts)        ? datosDelFruto.Descripcion_Variedad    : TxtBx_Descripcion.Texts.Trim();
                    objVariedadDeFruto.Temporada_Cosecha        = string.IsNullOrWhiteSpace(TxtBx_TempCosecha.Texts)        ? datosDelFruto.Temporada_Cosecha       : TxtBx_TempCosecha.Texts.Trim();
                    objVariedadDeFruto.Estado                   = datosDelFruto.Estado;

                    // Actualiza el fruto en la base de datos
                    if (DatosVariedadDeFruto.Actualizar(objVariedadDeFruto))
                    {
                        MessageBox.Show("Datos del Fruto modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Consulta un fruto en l base de datos
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Variedad De Fruto";

            if (TxtBx_NombreVariedad.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el Nombre de la Variedad del Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJVariedadDeFruto objVariedadDeFruto = DatosVariedadDeFruto.Consultar(TxtBx_NombreVariedad.Texts.Trim());
                if (objVariedadDeFruto == null)
                {
                    MessageBox.Show("La Variedad del Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ID_FrutoTemp                = objVariedadDeFruto.ID_Variedad_Fruto;
                    TxtBx_NombreVariedad.Texts  = objVariedadDeFruto.Nombre_Variedad;
                    NombreFrutoTemp             = objVariedadDeFruto.Nombre_Variedad;
                    TxtBx_Descripcion.Texts     = objVariedadDeFruto.Descripcion_Variedad;
                    TxtBx_TempCosecha.Texts     = objVariedadDeFruto.Temporada_Cosecha;
                    EstadoTemp                  = objVariedadDeFruto.Estado;

                    ConsultadoVariedadDeFruto = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }



        // Elimina un fruto de la base de datos poniendo el Estado en Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Variedad De Fruto";

            if (ConsultadoVariedadDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el fruto está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("La Variedad de este Fruto ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la Variedad de este Fruto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJVariedadDeFruto objVariedadDeFruto   = new OBJVariedadDeFruto();
                        objVariedadDeFruto.ID_Variedad_Fruto    = ID_FrutoTemp;
                        objVariedadDeFruto.Estado               = "Inactivo";

                        if (DatosVariedadDeFruto.CambiarEstado(objVariedadDeFruto))
                        {
                            MessageBox.Show("Variedad De Fruto Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar la Variedad Del Fruto.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva el fruto poniendo el Estado en Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Variedad De Fruto";

            if (ConsultadoVariedadDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el fruto está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("La Variedad de este Fruto ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar la Variedad de este Fruto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJVariedadDeFruto objVariedadDeFruto   = new OBJVariedadDeFruto();
                        objVariedadDeFruto.ID_Variedad_Fruto    = ID_FrutoTemp;
                        objVariedadDeFruto.Estado               = "Activo";

                        if (DatosVariedadDeFruto.CambiarEstado(objVariedadDeFruto))
                        {
                            MessageBox.Show("Variedad De Fruto Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar la Variedad Del Fruto.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DateTime FechaHora  = DateTime.Now;

            DateTime Fecha      = FechaHora.Date;

            TimeSpan Hora       = FechaHora.TimeOfDay;

            int IDDis_Movimiento    = DatosMovimiento.ObtenerProximoIDDisponible();
            int IDUSER              = VenMenuPrincipal.ObtenerIDActivo();

            OBJMovimiento objMovimiento         = new OBJMovimiento();
            objMovimiento.ID_Movimiento         = IDDis_Movimiento;
            objMovimiento.ID_Usuario            = IDUSER;
            objMovimiento.Seccion               = Seccion;
            objMovimiento.Tipo_Movimiento       = tipo_mov;
            objMovimiento.Fecha_Movimiento      = Fecha;
            objMovimiento.Hora_Movimiento       = Hora;
            objMovimiento.Estado                = "Activo";

            // Actualiza el proveedor en la base de datos
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
            ConsultadoVariedadDeFruto = false;
            TxtBx_NombreVariedad.Texts = "";
            TxtBx_Descripcion.Texts = "";
            TxtBx_TempCosecha.Texts = "";
        }
    }
}
