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

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    public partial class VenEntradaEnvios : Form
    {

        private VenMenuPrincipal Pnl_Principal;

        public VenEntradaEnvios(VenMenuPrincipal pnl_Principal)
        {
            InitializeComponent();
            this.Pnl_Principal = pnl_Principal;

            LlenarEntrada();
        }


        private void LlenarEntrada()
        {
            DTVEntradaEnvios.Rows.Clear();
            DateTime fechaSeleccionada = DTPFecha.Value.Date;

            List<OBJRecepcionEnvio> listaEntradas = DatosRecepcionEnvio.ConsultarEntradas(fechaSeleccionada);

            try
            {

                // Itera para agregar al DataGrid
                foreach (OBJRecepcionEnvio objEntrada in listaEntradas)
                {
                    int rowIndex                        = DTVEntradaEnvios.Rows.Add();
                    DataGridViewRow row                 = DTVEntradaEnvios.Rows[rowIndex];
                    row.Cells["IDRecepcion"].Value      = objEntrada.ID_Recepcion;
                    row.Cells["NombreConductor"].Value  = objEntrada.Nombre_Conductor;
                    row.Cells["PlacaCamion"].Value      = objEntrada.Placa_Camion;
                    row.Cells["Cedula"].Value           = objEntrada.Cedula;
                    row.Cells["NBines"].Value           = objEntrada.N_Bines;
                    row.Cells["HoraEnvio"].Value        = objEntrada.Hora_Envio;
                    row.Cells["HoraLlegada"].Value      = objEntrada.Hora_Llegada;

                    // Muestra solo la fecha
                    row.Cells["Fecha"].Value            = objEntrada.Fecha.ToString("dd/MM/yyyy");

                    row.Cells["PesoNeto"].Value         = objEntrada.Peso_Neto;
                    row.Cells["Estado"].Value           = objEntrada.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void Btn_Añadir_Click(object sender, EventArgs e)
        {
            Pnl_Principal.AbrirFormulario(new VenRecepcionEnvios(Pnl_Principal));
        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            LlenarEntrada();
        }

        private void Btn_ConsultarEnvio_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (DTVEntradaEnvios.SelectedRows.Count > 0)
            {
                // Fila seleccionada
                DataGridViewRow filaSeleccionada = DTVEntradaEnvios.SelectedRows[0];

                // Obtiene los datos de la fila seleccionada
                int idRecepcion             = Convert.ToInt32(filaSeleccionada.Cells["IDRecepcion"].Value);
                string nombreConductor      = filaSeleccionada.Cells["NombreConductor"].Value.ToString();
                string placaCamion          = filaSeleccionada.Cells["PlacaCamion"].Value.ToString();
                string cedula               = filaSeleccionada.Cells["Cedula"].Value.ToString();
                int nBines                  = Convert.ToInt32(filaSeleccionada.Cells["NBines"].Value);

                TimeSpan horaEnvio          = TimeSpan.Parse(filaSeleccionada.Cells["HoraEnvio"].Value.ToString());
                TimeSpan horaLlegada        = TimeSpan.Parse(filaSeleccionada.Cells["HoraLlegada"].Value.ToString());
                string fecha                = filaSeleccionada.Cells["Fecha"].Value.ToString();
                decimal pesoNeto            = Convert.ToDecimal(filaSeleccionada.Cells["PesoNeto"].Value);
                string estado               = filaSeleccionada.Cells["Estado"].Value.ToString();

                VenRecepcionEnvios recEnvio = new VenRecepcionEnvios(Pnl_Principal);

                Pnl_Principal.AbrirFormulario(recEnvio);

                recEnvio.LlenarCampos(idRecepcion, nombreConductor, placaCamion, cedula, nBines, horaEnvio, horaLlegada, fecha, pesoNeto, estado);


            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila primero.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
