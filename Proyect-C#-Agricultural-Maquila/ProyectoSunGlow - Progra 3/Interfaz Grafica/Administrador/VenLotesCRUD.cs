using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Datos.Objetos;
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
    public partial class VenLotesCRUD : Form
    {
        public VenLotesCRUD()
        {
            InitializeComponent();
            CmbBx_Fincas.DropDownStyle = ComboBoxStyle.DropDownList;

        }



        bool ConsultadoLote;

        string Seccion = "Gestión De Lotes";

        int IDLoteTemp;
        int IDFincaTemp;
        string NombreLoteTemp;
        string NombreFincaTemp;
        string EstadoTemp;




        private void VenLotesCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoLote = false;
            CargarComboBoxFincas();
        }


        // Guarda el Lote en la base de Datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Lote";
            int IDDis_Lote = DatosLote.ObtenerProximoIDDisponible();

            if (ConsultadoLote)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreLote.Texts.Trim()))
            {
                MessageBox.Show("Debe de ingresar el Nombre del Lote", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe un lote con el mismo nombre
                OBJLote loteExistente = DatosLote.Consultar(TxtBx_NombreLote.Texts.Trim());
                if (loteExistente != null)
                {
                    MessageBox.Show("Ya existe un Lote con el mismo nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                OBJLote objLote         = new OBJLote();
                objLote.ID_Lote         = IDDis_Lote;
                objLote.Nombre_Lote     = TxtBx_NombreLote.Texts.Trim();

                try
                {
                    // Intenta convertir el valor de TxtBx_AreaTotal.Text a decimal y asignarlo a objFinca.Area_Total
                    objLote.Area_Total = decimal.Parse(TxtBx_AreaTotal.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("No se pudo convertir a Decimal.", "¡Atención" +
                        "n!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                objLote.Finca_ID    = IDFincaTemp;
                objLote.Estado      = "Activo";

                if (DatosLote.Guardar(objLote))
                {
                    MessageBox.Show("Lote Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                    CargarComboBoxFincas();
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



        // Modifica el lote en la Base de Datos
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Lote";

            if (ConsultadoLote == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NombreLote.Texts))
            {
                MessageBox.Show("Debe ingresar el Nombre del Lote.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el Lote original
                    OBJLote datosDelLote = DatosLote.Consultar(NombreLoteTemp);
                    if (datosDelLote == null)
                    {
                        MessageBox.Show("El Lote no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el Lote que se está modificando existe en la base de datos
                    OBJLote loteExistente = DatosLote.ConsultarPorIDLote(IDLoteTemp);
                    if (loteExistente == null)
                    {
                        MessageBox.Show("El Lote que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del Lote ya existe en la base de datos, excluyendo el Lote que se está modificando actualmente
                    string nuevoNombreLote = TxtBx_NombreLote.Texts.Trim();
                    if (nuevoNombreLote != datosDelLote.Nombre_Lote)
                    {
                        OBJLote LoteExistentePorNombre = DatosLote.Consultar(nuevoNombreLote);
                        if (LoteExistentePorNombre != null && LoteExistentePorNombre.ID_Lote != datosDelLote.ID_Lote)
                        {
                            MessageBox.Show("Ya existe un Lote con el mismo nombre en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Crea un nuevo objeto Lote para la modificación
                    OBJLote objLote = new OBJLote();
                    objLote.ID_Lote = datosDelLote.ID_Lote;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objLote.Nombre_Lote = string.IsNullOrWhiteSpace(TxtBx_NombreLote.Texts) ? datosDelLote.Nombre_Lote : TxtBx_NombreLote.Texts.Trim();

                    decimal areaTotal;
                    if (decimal.TryParse(TxtBx_AreaTotal.Text.Trim(), out areaTotal))
                    {
                        objLote.Area_Total = areaTotal;
                    }
                    else if (string.IsNullOrWhiteSpace(TxtBx_AreaTotal.Text))
                    {
                        objLote.Area_Total = datosDelLote.Area_Total;
                    }
                    else
                    {
                        MessageBox.Show("El valor ingresado no es un número decimal válido.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Retorna para evitar guardar los datos con un valor incorrecto
                    }

                    objLote.Finca_ID = IDFincaTemp;
                    objLote.Estado = datosDelLote.Estado;

                    // Actualiza la Finca en la base de datos
                    if (DatosLote.Actualizar(objLote))
                    {
                        MessageBox.Show("Datos del Lote modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Movimientos(Tipo_Mov);
                        LimpiarInformacion();
                        CargarComboBoxFincas();
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



        // Consulta el Lote en la Base de Datos
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Lote";

            if (TxtBx_NombreLote.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el Nombre del Lote.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJLote objLote = DatosLote.Consultar(TxtBx_NombreLote.Texts.Trim());
                if (objLote == null)
                {
                    MessageBox.Show("El Lote no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    IDLoteTemp              = objLote.ID_Lote;
                    NombreLoteTemp          = objLote.Nombre_Lote;
                    TxtBx_AreaTotal.Text    = objLote.Area_Total.ToString();

                    IDFincaTemp             = objLote.Finca_ID;
                    OBJFinca objFinca       = DatosFinca.ConsultarPorIDFinca(IDFincaTemp);
                    NombreFincaTemp         = objFinca.Nombre_Finca;
                    CmbBx_Fincas.SelectedItem = NombreFincaTemp;

                    EstadoTemp              = objLote.Estado;

                    ConsultadoLote = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }



        // Elimina el lote poniendo el Estado en Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Lote";

            if (ConsultadoLote == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Lote está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El Lote ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Lote?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJLote objLote = new OBJLote();
                        objLote.ID_Lote = IDLoteTemp;
                        objLote.Estado = "Inactivo";

                        if (DatosLote.CambiarEstado(objLote))
                        {
                            MessageBox.Show("Lote Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar el Lote.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva el Lote poniendo el Estado en Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Lote";

            if (ConsultadoLote == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Lote está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El Lote ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar el Lote?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJLote objLote = new OBJLote();
                        objLote.ID_Lote = IDLoteTemp;
                        objLote.Estado = "Activo";

                        if (DatosLote.CambiarEstado(objLote))
                        {
                            MessageBox.Show("Lote Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar el Lote.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<string> nombresFincas = Datos.DatosLote.ConsultarFincas();

            // Limpiar ComboBox
            CmbBx_Fincas.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresFincas)
            {
                CmbBx_Fincas.Items.Add(nombre);
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
            ConsultadoLote          = false;
            IDFincaTemp             = 0;
            IDLoteTemp              = 0;
            NombreLoteTemp          = "";
            NombreFincaTemp         = "";
            TxtBx_NombreLote.Texts  = "";
            TxtBx_AreaTotal.Text    = "";
            EstadoTemp              = "";
        }


        private void CmbBx_Fincas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreFinca = CmbBx_Fincas.SelectedItem.ToString();

            OBJFinca objFinca = DatosLote.ConsultarPorNombreFinca(nombreFinca);
            if (objFinca == null)
            {
                MessageBox.Show("La Finca no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDFincaTemp = objFinca.ID_Finca;
                NombreFincaTemp = objFinca.Nombre_Finca;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
