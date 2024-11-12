using ProyectoSunGlow___Progra_3.Datos;
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
    public partial class VenReportes : Form
    {
        public VenReportes()
        {
            InitializeComponent();
        }


        // Reporta la Cantidad de Cajas Empacadas en Día X
        private void CajasEmpacadas()
        {
            DateTime fechaSeleccionada = DTPPallEmp.Value.Date;
            int cajasempacadas = (int)DatosReporte.CantidadCajasEmpacadasXDia(fechaSeleccionada);

            // Asegúrate de que el gráfico esté limpio antes de agregar nuevos datos
            GraficoCajasDia.Series["Series1"].Points.Clear();

            // Agrega los datos al gráfico
            GraficoCajasDia.Series["Series1"].Points.AddY(cajasempacadas);

            LblCantCajas.Text = cajasempacadas.ToString() + " Cajas";
        }


        // Reporta la cantidad de Pallets Empacados en Día X
        private void PalletsEmpacados()
        {
            DateTime fechaSeleccionada = DTPFechaCajEmp.Value.Date;
            int palletsempacados = (int)DatosReporte.CantidadPalletsEmpacadosXDia(fechaSeleccionada);

            // Asegúrate de que el gráfico esté limpio antes de agregar nuevos datos
            GraficoPalletsDia.Series["Series1"].Points.Clear();

            // Agrega los datos al gráfico
            GraficoPalletsDia.Series["Series1"].Points.AddY(palletsempacados);

            LblCantPallets.Text = palletsempacados.ToString() + " Pallets";
        }



        public void LlenarProcedenciaFruta()
        {
            DTGVProcFruta.Rows.Clear();
            DateTime fechaSeleccionada = DTPFechaCajEmp.Value.Date;

            List<Tuple<string, string, string, string, string, int>> listaProcedencia = DatosReporte.ProcedenciaFrutaXDia(fechaSeleccionada);

            try
            {
                // Itera para agregar al DataGrid
                foreach (var procedencia in listaProcedencia)
                {
                    int rowIndex = DTGVProcFruta.Rows.Add();
                    DataGridViewRow row = DTGVProcFruta.Rows[rowIndex];
                    row.Cells["NombreFinca"].Value = procedencia.Item1;
                    row.Cells["NombreLote"].Value = procedencia.Item2;
                    row.Cells["NombreBloque"].Value = procedencia.Item3;
                    row.Cells["NombreVariedad"].Value = procedencia.Item4;
                    row.Cells["TiposDe_Frutos"].Value = procedencia.Item5;
                    row.Cells["TotalFruta"].Value = procedencia.Item6;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void DTPFechaCajEmp_ValueChanged(object sender, EventArgs e)
        {
            CajasEmpacadas();
        }

        private void DTPPallEmp_ValueChanged(object sender, EventArgs e)
        {
            PalletsEmpacados();
        }

        private void DTPProcFruta_ValueChanged(object sender, EventArgs e)
        {
            //LlenarProcedenciaFruta();
        }

    }
}
