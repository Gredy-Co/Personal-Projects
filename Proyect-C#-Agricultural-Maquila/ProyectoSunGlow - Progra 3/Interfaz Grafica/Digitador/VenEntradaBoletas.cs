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
    public partial class VenEntradaBoletas : Form
    {

        private VenMenuPrincipal Pnl_Principal;

        public VenEntradaBoletas(VenMenuPrincipal pnl_Principal)
        {
            InitializeComponent();
            Pnl_Principal = pnl_Principal;
            this.Pnl_Principal = pnl_Principal;

            LlenarEntrada();
        }



        private void LlenarEntrada()
        {
            DTVBoletas.Rows.Clear();
            DateTime fechaSeleccionada = DTPFecha.Value.Date;

            List<OBJBoletaCosecha> listaBoletas = DatosBoletaCosecha.ConsultarBoletas(fechaSeleccionada);

            try
            {

                // Itera para agregar al DataGrid
                foreach (OBJBoletaCosecha objBoleta in listaBoletas)
                {
                    int rowIndex                    = DTVBoletas.Rows.Add();
                    DataGridViewRow row             = DTVBoletas.Rows[rowIndex];
                    row.Cells["IDBoleta"].Value     = objBoleta.ID_Boleta;
                    row.Cells["Consecutivo"].Value  = objBoleta.Consecutivo_Boleta;
                    row.Cells["EnvioID"].Value      = objBoleta.Envio_ID;
                    row.Cells["Cuadrilla"].Value    = objBoleta.Cuadrilla;

                    // Muestra solo la fecha
                    row.Cells["FechaCosecha"].Value = objBoleta.Fecha_Cosecha.ToString("dd/MM/yyyy");
                    row.Cells["HoraCosecha"].Value  = objBoleta.Hora_Cosecha;
                    row.Cells["Estado"].Value       = objBoleta.Estado;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void Btn_Añadir_Click(object sender, EventArgs e)
        {
            Pnl_Principal.AbrirFormulario(new VenBoletaCosechaDetalleCRUD(Pnl_Principal));
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
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
            if (DTVBoletas.SelectedRows.Count > 0)
            {
                // Fila seleccionada
                DataGridViewRow filaSeleccionada = DTVBoletas.SelectedRows[0];

                // Obtiene los datos de la fila seleccionada
                int idBoleta            = Convert.ToInt32(filaSeleccionada.Cells["IDBoleta"].Value);
                string consecutivo      = filaSeleccionada.Cells["Consecutivo"].Value.ToString();
                int envioID             = Convert.ToInt32(filaSeleccionada.Cells["EnvioID"].Value);
                string cuadrilla        = filaSeleccionada.Cells["Cuadrilla"].Value.ToString();
                string fechaCosecha     = filaSeleccionada.Cells["FechaCosecha"].Value.ToString();
                TimeSpan horaCosecha    = TimeSpan.Parse(filaSeleccionada.Cells["HoraCosecha"].Value.ToString());
                string estado           = filaSeleccionada.Cells["Estado"].Value.ToString();

                VenBoletaCosechaDetalleCRUD bolCosecha = new VenBoletaCosechaDetalleCRUD(Pnl_Principal);

                Pnl_Principal.AbrirFormulario(bolCosecha);

                bolCosecha.LlenarDatosBoleta(idBoleta, consecutivo, envioID, cuadrilla, fechaCosecha, horaCosecha, estado);


            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila primero.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
