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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    public partial class VenFincasCRUD : Form
    {
        public VenFincasCRUD()
        {
            InitializeComponent();
            CmbBx_Fincas.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_Propietario.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        bool ConsultadoFinca;

        int IDFincaTemp;
        int IDPorveedorTemp;
        string NombreFincaTemp;
        string NombreProveedorTemp;
        string EstadoTemp;

        string Seccion = "Gestión De Fincas";



        // Carga en la Ventana la información de las Fincas y Proveedores en los ComboBox
        private void VenFincasCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoFinca = false;
            CargarComboBoxFincas();
            CargarComboBoxProveedores(); 
        }




        // Guarda la información de la Finca
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Finca";
            int IDDis_Finca = DatosFinca.ObtenerProximoIDDisponible();

            if (ConsultadoFinca)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreFinca.Texts.Trim()))
            {
                MessageBox.Show("Debe de ingresar el Nombre de la Finca", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe una finca con el mismo nombre
                OBJFinca fincaExistente = DatosFinca.ConsultarPorNombreFinca(TxtBx_NombreFinca.Texts.Trim());
                if (fincaExistente != null)
                {
                    MessageBox.Show("Ya existe una Finca con el mismo nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                OBJFinca objFinca       = new OBJFinca();
                objFinca.ID_Finca       = IDDis_Finca;
                objFinca.Nombre_Finca   = TxtBx_NombreFinca.Texts.Trim();
                objFinca.Ubicacion      = TxtBx_Ubicacion.Texts.Trim();

                try
                {
                    // Intenta convertir el valor de TxtBx_AreaTotal.Text a decimal y asignarlo a objFinca.Area_Total
                    objFinca.Area_Total = decimal.Parse(TxtBx_AreaTotal.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("No se pudo convertir a Decimal.", "¡Atención" +
                        "n!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                objFinca.Tipo_Suelo     = TxtBx_Tipo_De_Suelo.Texts.Trim();
                objFinca.Proveedor_ID   = IDPorveedorTemp;
                objFinca.Estado         = "Activo";

                if (DatosFinca.Guardar(objFinca))
                {
                    MessageBox.Show("Finca Guardada", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                    CargarComboBoxFincas();
                    CargarComboBoxProveedores();
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



        // Modifica la información de la Finca 
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Finca";

            if (ConsultadoFinca == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NombreFinca.Texts.Trim()))
            {
                MessageBox.Show("Debe ingresar el Nombre de la Finca.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta la Finca original
                    OBJFinca datosDeLaFinca = DatosFinca.Consultar(NombreFincaTemp);
                    if (datosDeLaFinca == null)
                    {
                        MessageBox.Show("La Finca no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si la Finca que se está modificando existe en la base de datos
                    OBJFinca fincaExistente = DatosFinca.ConsultarPorIDFinca(IDFincaTemp);
                    if (fincaExistente == null)
                    {
                        MessageBox.Show("La Finca que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre de la Finca ya existe en la base de datos, excluyendo la Finca que se está modificando actualmente
                    string nuevoNombreFinca = TxtBx_NombreFinca.Texts.Trim();
                    if (nuevoNombreFinca != datosDeLaFinca.Nombre_Finca)
                    {
                        OBJFinca FincaExistentePorNombre = DatosFinca.Consultar(nuevoNombreFinca);
                        if (FincaExistentePorNombre != null && FincaExistentePorNombre.ID_Finca != datosDeLaFinca.ID_Finca)
                        {
                            MessageBox.Show("Ya existe una Finca con el mismo nombre en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Crea un nuevo objeto Finca para la modificación
                    OBJFinca objFinca = new OBJFinca();
                    objFinca.ID_Finca = datosDeLaFinca.ID_Finca;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objFinca.Nombre_Finca   = string.IsNullOrWhiteSpace(TxtBx_NombreFinca.Texts)    ? datosDeLaFinca.Nombre_Finca   : TxtBx_NombreFinca.Texts.Trim();
                    objFinca.Ubicacion      = string.IsNullOrWhiteSpace(TxtBx_Ubicacion.Texts)      ? datosDeLaFinca.Ubicacion      : TxtBx_Ubicacion.Texts.Trim();
                    
                    decimal areaTotal;
                    if (decimal.TryParse(TxtBx_AreaTotal.Text.Trim(), out areaTotal))
                    {
                        objFinca.Area_Total = areaTotal;
                    }
                    else if (string.IsNullOrWhiteSpace(TxtBx_AreaTotal.Text))
                    {
                        objFinca.Area_Total = datosDeLaFinca.Area_Total;
                    }
                    else
                    {
                        MessageBox.Show("El valor ingresado no es un número decimal válido.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Retorna para evitar guardar los datos con un valor incorrecto
                    }

                    objFinca.Tipo_Suelo     = string.IsNullOrWhiteSpace(TxtBx_Tipo_De_Suelo.Texts)  ? datosDeLaFinca.Tipo_Suelo     : TxtBx_Tipo_De_Suelo.Texts.Trim();
                    objFinca.Proveedor_ID   = (IDPorveedorTemp == null || IDPorveedorTemp == 0)     ? datosDeLaFinca.Proveedor_ID   : IDPorveedorTemp;
                    objFinca.Estado         = datosDeLaFinca.Estado;

                    // Actualiza la Finca en la base de datos
                    if (DatosFinca.Actualizar(objFinca))
                    {
                        MessageBox.Show("Datos de la Finca modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Movimientos(Tipo_Mov);
                        LimpiarInformacion();
                        CargarComboBoxFincas();
                        CargarComboBoxProveedores();
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



        // Consulta los datos de una Finca en específico
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Finca";

            if (TxtBx_NombreFinca.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la Finca.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJFinca objFinca = DatosFinca.Consultar(TxtBx_NombreFinca.Texts.Trim());
                if (objFinca == null)
                {
                    MessageBox.Show("La Finca no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    IDFincaTemp                 = objFinca.ID_Finca;
                    NombreFincaTemp             = objFinca.Nombre_Finca;
                    TxtBx_Ubicacion.Texts       = objFinca.Ubicacion;
                    TxtBx_AreaTotal.Text        = objFinca.Area_Total.ToString();
                    TxtBx_Tipo_De_Suelo.Texts   = objFinca.Tipo_Suelo;
                    EstadoTemp                  = objFinca.Estado;

                    ConsultadoFinca = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }



        // Elimina la finca pasando el Estado a Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Finca";

            if (ConsultadoFinca == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si la finca está Inactiva
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("La finca ya se encuentra Inactiva.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la Finca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJFinca objFinca   = new OBJFinca();
                        objFinca.ID_Finca   = IDFincaTemp;
                        objFinca.Estado     = "Inactivo";

                        if (DatosFinca.CambiarEstado(objFinca))
                        {
                            MessageBox.Show("Finca Eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar la Finca.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva la Finca pasando el Estado a Activo
        private void Btn_ReactivarUsuario_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Finca";

            if (ConsultadoFinca == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si la finca está Activa
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("La finca ya se encuentra Activa.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar la Finca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJFinca objFinca   = new OBJFinca();
                        objFinca.ID_Finca   = IDFincaTemp;
                        objFinca.Estado     = "Activo";

                        if (DatosFinca.CambiarEstado(objFinca))
                        {
                            MessageBox.Show("Finca Reactivada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar la Finca.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        // Carga la información en los ComboBox
        private void CargarComboBoxFincas()
        {
            List<string> nombresFincas = Datos.DatosFinca.ConsultarNombresFincas();

            // Limpiar ComboBox 
            CmbBx_Fincas.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresFincas)
            {
                CmbBx_Fincas.Items.Add(nombre);
            }
        }


        // Carga la información en los ComboBox
        private void CargarComboBoxProveedores()
        {
            List<string> nombresProveedores = Datos.DatosFinca.ConsultarProveedores();

            // Limpiar ComboBox
            CmbBx_Propietario.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresProveedores)
            {
                CmbBx_Propietario.Items.Add(nombre);
            }
        }


        // Guarda el Movimiento realizado en la Bitácora
        private void Movimientos(string tipo_mov)
        {
            DateTime FechaHora  = DateTime.Now;

            DateTime Fecha      = FechaHora.Date;

            TimeSpan Hora       = FechaHora.TimeOfDay;

            int IDDis_Movimiento    = DatosMovimiento.ObtenerProximoIDDisponible();
            int IDUSER              = VenMenuPrincipal.ObtenerIDActivo();

            OBJMovimiento objMovimiento     = new OBJMovimiento();
            objMovimiento.ID_Movimiento     = IDDis_Movimiento;
            objMovimiento.ID_Usuario        = IDUSER;
            objMovimiento.Seccion           = Seccion;
            objMovimiento.Tipo_Movimiento   = tipo_mov;
            objMovimiento.Fecha_Movimiento  = Fecha;
            objMovimiento.Hora_Movimiento   = Hora;
            objMovimiento.Estado            = "Activo";

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
            ConsultadoFinca             = false;
            IDPorveedorTemp             = 0;
            IDFincaTemp                 = 0;
            NombreProveedorTemp         = "";
            TxtBx_NombreFinca.Texts     = "";
            TxtBx_Ubicacion.Texts       = "";
            TxtBx_AreaTotal.Text        = "";
            TxtBx_Tipo_De_Suelo.Texts   = "";
            EstadoTemp                  = "";
        }



        // Carga los datos en los respectivos ComboBox
        private void CmbBx_Propietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProveedor = CmbBx_Propietario.SelectedItem.ToString();

            OBJProveedor objProveedor = DatosFinca.ConsultarPorNombreProveedor(nombreProveedor);
            if (objProveedor == null)
            {
                MessageBox.Show("El Proveedor no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDPorveedorTemp     = objProveedor.ID_Proveedor;
                NombreProveedorTemp = objProveedor.Nombre_Proveedor;
            }
        }



        private void CmbBx_Fincas_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreFincaTemp = CmbBx_Fincas.SelectedItem.ToString();

            OBJFinca objFinca = DatosFinca.Consultar(NombreFincaTemp);
            if (objFinca == null)
            {
                MessageBox.Show("La Finca no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NombreFincaTemp             = objFinca.Nombre_Finca;
                TxtBx_NombreFinca.Texts     = objFinca.Nombre_Finca;
                TxtBx_Ubicacion.Texts       = objFinca.Ubicacion;
                TxtBx_AreaTotal.Text        = objFinca.Area_Total.ToString();
                TxtBx_Tipo_De_Suelo.Texts   = objFinca.Tipo_Suelo;
            }
        }


        //Prohibe que digite caracteres
        private void TxtBx_AreaTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número, un punto decimal o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no es un número, un punto decimal ni una tecla de control, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
            // Verifica si ya existe un punto decimal en el texto
            else if (e.KeyChar == '.' && TxtBx_AreaTotal.Text.IndexOf('.') > -1)
            {
                // Si ya existe un punto decimal, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
        }
    }
}
