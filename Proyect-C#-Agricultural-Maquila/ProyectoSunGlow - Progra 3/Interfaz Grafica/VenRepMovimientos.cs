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

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    public partial class VenRepMovimientos : Form
    {
        public VenRepMovimientos()
        {
            InitializeComponent();
            LlenarBitacora();
        }

        private void LlenarBitacora()
        {
            List<OBJMovimiento> listaMovimientos = DatosMovimiento.ConsultarTodo();

            // Itera para agregar al DataGrid
            foreach (OBJMovimiento movimiento in listaMovimientos)
            {
                int rowIndex = DTVBitMovimientos.Rows.Add();
                DataGridViewRow row = DTVBitMovimientos.Rows[rowIndex];
                row.Cells["ID_Usuario"].Value = movimiento.ID_Usuario;
                row.Cells["Seccion"].Value = movimiento.Seccion;
                row.Cells["Tipo_Movimiento"].Value = movimiento.Tipo_Movimiento;

                // Muestra solo la fecha
                row.Cells["Fecha_Movimiento"].Value = movimiento.Fecha_Movimiento.ToString("dd/MM/yyyy");

                row.Cells["Hora_Movimiento"].Value = movimiento.Hora_Movimiento;
            }
        }




        // Función para llenar el DataGridView con los resultados de la consulta
        private void LlenarBitacoraPorFecha(List<OBJMovimiento> movimientos)
        {
            // Limpiar el DataGridView antes de llenarlo con nuevos datos
            DTVBitMovimientos.Rows.Clear();
            DateTime fechaSeleccionada = DTPMovFecha.Value.Date;

            List<OBJMovimiento> listaMovimientos = DatosMovimiento.ConsultarMovimientosFecha(fechaSeleccionada);


            try
            {

                // Itera para agregar al DataGrid
                foreach (OBJMovimiento movimiento in listaMovimientos)
                {
                    int rowIndex = DTVBitMovimientos.Rows.Add();
                    DataGridViewRow row = DTVBitMovimientos.Rows[rowIndex];
                    row.Cells["ID_Usuario"].Value = movimiento.ID_Usuario;
                    row.Cells["Seccion"].Value = movimiento.Seccion;
                    row.Cells["Tipo_Movimiento"].Value = movimiento.Tipo_Movimiento;
                    row.Cells["Fecha_Movimiento"].Value = movimiento.Fecha_Movimiento.ToString("dd/MM/yyyy");
                    row.Cells["Hora_Movimiento"].Value = movimiento.Hora_Movimiento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void DTPMovFecha_ValueChanged(object sender, EventArgs e)
        {
            //List<OBJMovimiento> movimientos = new List<OBJMovimiento>();

            //LlenarBitacoraPorFecha(movimientos);
        }
    }
}
