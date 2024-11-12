using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Datos.Objetos;
using ProyectoSunGlow___Progra_3.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    public partial class VenRecepcionEnvios : Form
    {
        private VenMenuPrincipal Pnl_Principal;

        public VenRecepcionEnvios(VenMenuPrincipal pnl_Principal)
        {
            InitializeComponent();
            Pnl_Principal = pnl_Principal;
            this.Pnl_Principal = pnl_Principal;
        }

        bool ConsultadoEnvio;
        int ID_ReEnvioTemp;
        TimeSpan HoraLlegadaTemp;

        decimal PesoNetoTemp;
        string EstadoTemp;


        string Seccion = "Gestión De Recepción de Envíos";


        // Guarda los Datos del envío
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            DateTime FechaHora = DateTime.Now;

            DateTime Fecha = FechaHora.Date;

            TimeSpan Hora = FechaHora.TimeOfDay;

            string Tipo_Mov = "Insertar Recepción De Envío";
            int IDDis_Envio = DatosRecepcionEnvio.ObtenerProximoIDDisponible();

            if (ConsultadoEnvio)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreConductor.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del conductor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_PlacaCamion.Text))
            {
                MessageBox.Show("Debe ingresar la Placa del camión.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_CedConductor.Text))
            {
                MessageBox.Show("Debe ingresar la Cédula del conductor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_CantBines.Text))
            {
                MessageBox.Show("Debe ingresar la Cantidad de Bines.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_PesoBruto.Text))
            {
                MessageBox.Show("Debe ingresar el Peso Bruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                OBJRecepcionEnvio objEnvio  = new OBJRecepcionEnvio();
                objEnvio.ID_Recepcion       = IDDis_Envio;
                objEnvio.Nombre_Conductor   = TxtBx_NombreConductor.Text.Trim();
                objEnvio.Placa_Camion       = TxtBx_PlacaCamion.Text.Trim();
                objEnvio.Cedula             = TxtBx_CedConductor.Text.Trim();
                objEnvio.N_Bines            = int.Parse(TxtBx_CantBines.Text.Trim());

                TimeSpan hora               = DTPHoraEnvío.Value.TimeOfDay;
                objEnvio.Hora_Envio         = hora;

                objEnvio.Hora_Llegada       = Hora;
                objEnvio.Fecha              = Fecha;
                objEnvio.Peso_Neto          = decimal.Parse(TxtBx_PesoBruto.Text.Trim());
                objEnvio.Estado             = "Activo";

                if (DatosRecepcionEnvio.Guardar(objEnvio))
                {
                    MessageBox.Show("Recepción del Envío Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                    Pnl_Principal.AbrirFormulario(new VenEntradaEnvios(Pnl_Principal));
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



        // Modifica los datos del envío
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Recepción de Envío";

            if (ConsultadoEnvio == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(TxtBx_NombreConductor.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del conductor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_PlacaCamion.Text))
            {
                MessageBox.Show("Debe ingresar la Placa del camión.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_CedConductor.Text))
            {
                MessageBox.Show("Debe ingresar la Cédula del conductor.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            try
            {

                // Verifica con el ID si del envío que se está modificando existe en la base de datos
                OBJRecepcionEnvio envioExistente = DatosRecepcionEnvio.Consultar(ID_ReEnvioTemp);
                if (envioExistente == null)
                {
                    MessageBox.Show("El Envío que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crea un nuevo objeto Bin para la modificación
                OBJRecepcionEnvio objEnvio = new OBJRecepcionEnvio();
                objEnvio.ID_Recepcion = ID_ReEnvioTemp;
                objEnvio.Nombre_Conductor = TxtBx_NombreConductor.Text.Trim();
                objEnvio.Placa_Camion = TxtBx_PlacaCamion.Text.Trim();
                objEnvio.Cedula = TxtBx_CedConductor.Text.Trim();
                objEnvio.N_Bines = int.Parse(TxtBx_CantBines.Text.Trim());


                DateTime fechaYHora = DTPHoraEnvío.Value;

                DateTime fecha = fechaYHora.Date;
                TimeSpan hora = fechaYHora.TimeOfDay;
                    
                objEnvio.Hora_Envio = hora;
                objEnvio.Hora_Llegada = HoraLlegadaTemp;
                objEnvio.Fecha = fecha;

                objEnvio.Peso_Neto = PesoNetoTemp;

                objEnvio.Estado = "Activo";

                // Actualiza el Envío en la base de datos
                if (DatosRecepcionEnvio.Actualizar(objEnvio))
                {
                    MessageBox.Show("Datos del Bin modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Llena los campos de la entrada que se consultó en la ventana Entrada Envíos
        public void LlenarCampos(int idRecepcion, string nombreConductor, string placaCamion, string cedula, int nBines, TimeSpan horaEnvio, TimeSpan horaLlegada, string fecha, decimal pesoNeto, string estado)
        {
            decimal Tara = (8600 + 4500) + (nBines * 200);

            ID_ReEnvioTemp = idRecepcion;
            TxtBx_NombreConductor.Text = nombreConductor;
            TxtBx_PlacaCamion.Text = placaCamion;
            TxtBx_CedConductor.Text = cedula;

            // Parsear la cadena de fecha al formato esperado
            DateTime fechaFormateada = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Combinar la fecha formateada con la hora de envío
            DateTime fechaYHoraEnvio = fechaFormateada.Date + horaEnvio;

            // Establecer la fecha y hora en el DateTimePicker
            DTPHoraEnvío.Value = fechaYHoraEnvio;

            TxtBx_CantBines.Text = nBines.ToString();
            TxtBx_PesoBruto.Text = (Tara + pesoNeto).ToString();

            HoraLlegadaTemp = horaLlegada;
            label5.Text = horaLlegada.ToString();

            EstadoTemp = estado.ToString();

            ConsultadoEnvio = true;
        }



        // Elimina el envío poniendo el Estado en Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Envío";

            if (ConsultadoEnvio == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Envio está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El Envío ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Envío?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJRecepcionEnvio objEnvio  = new OBJRecepcionEnvio();
                        objEnvio.ID_Recepcion       = ID_ReEnvioTemp;
                        objEnvio.Estado             = "Inactivo";

                        if (DatosRecepcionEnvio.CambiarEstado(objEnvio))
                        {
                            MessageBox.Show("Envío Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar el Envío.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva el Envío poniendo el Estado en Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Envío";

            if (ConsultadoEnvio == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Envio está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El Envío ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar el Envío?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJRecepcionEnvio objEnvio  = new OBJRecepcionEnvio();
                        objEnvio.ID_Recepcion       = ID_ReEnvioTemp;
                        objEnvio.Estado             = "Activo";

                        if (DatosRecepcionEnvio.CambiarEstado(objEnvio))
                        {
                            MessageBox.Show("Envío Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar el Envío.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // Saca el peso Neto
        private void PesoNeto()
        {
            int Bines = int.Parse(TxtBx_CantBines.Text.Trim()) * 200;

            decimal Tara = (8600) + (4500) + Bines;

            decimal PesoBruto = decimal.Parse(TxtBx_PesoBruto.Text.Trim());

            decimal PesoNeto = PesoBruto - Tara;
            PesoNetoTemp = PesoNeto;
            Lbl_PNeto.Text = PesoNeto.ToString() + " Kg";   
        }


        // Guarda los Movimientos que se hicieron en la Bitácora
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
            ConsultadoEnvio = false;
            ID_ReEnvioTemp = 0;
            TxtBx_NombreConductor.Text = "";
            TxtBx_PlacaCamion.Text = "";
            TxtBx_CedConductor.Text = "";
            TxtBx_CantBines.Text = "";
            TxtBx_PesoBruto.Text = "";
            EstadoTemp = "";
        }


        private void Btn_BoletaCos_Click(object sender, EventArgs e)
        {
            Pnl_Principal.AbrirFormulario(new VenEntradaBoletas(Pnl_Principal));
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            Pnl_Principal.AbrirFormulario(new VenEntradaEnvios(Pnl_Principal));
        }

        private void VenRecepcionEnvios_Load(object sender, EventArgs e)
        {
            ConsultadoEnvio = false;
        }



        private void TxtBx_CantBines_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
        }

        private void TxtBx_PesoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número, un punto decimal o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no es un número, un punto decimal ni una tecla de control, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
            // Verifica si ya existe un punto decimal en el texto
            else if (e.KeyChar == '.' && TxtBx_PesoBruto.Text.IndexOf('.') > -1)
            {
                // Si ya existe un punto decimal, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
        }

        private void TxtBx_PesoBruto_TextChanged(object sender, EventArgs e)
        {
            PesoNeto();
        }


    }
}
