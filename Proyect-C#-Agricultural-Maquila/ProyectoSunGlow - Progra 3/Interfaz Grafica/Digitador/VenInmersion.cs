using ProyectoSunGlow___Progra_3.Datos.Objetos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    public partial class VenInmersion : Form
    {
        public VenInmersion()
        {
            InitializeComponent();
            DGVDisponible.Rows.Clear();
            DGVSumergido.Rows.Clear();

            LlenarEntrada();
        }

        string Seccion = "Inmersión";

        private void Btn_Sumergir_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Sumergir Frutas";

            DateTime FechaHora = DateTime.Now;

            DateTime Fecha = FechaHora.Date;

            TimeSpan Hora = FechaHora.TimeOfDay;

            Random rnd = new Random();

            int temperatura = rnd.Next(10, 16);

            bool exito = true;

            foreach (DataGridViewRow dataGridViewRow in DGVSumergido.Rows)
            {
                // Verifica en cada for que la fila no sea vacía
                if (!dataGridViewRow.IsNewRow)
                {
                    // Procesa la fila solo si no está vacía
                    OBJInmersion objInmersion = new OBJInmersion();
                    objInmersion.ID_Inmersion = DatosInmersion.ObtenerProximoIDDisponible(); // Obtener un nuevo ID para cada fila
                    objInmersion.DetalleBol_ID = Convert.ToInt32(dataGridViewRow.Cells["IDDet"].Value);
                    objInmersion.N_Bin = Convert.ToInt32(dataGridViewRow.Cells["NBin"].Value);
                    objInmersion.Fecha_Inmersion = Fecha;
                    objInmersion.Hora_Inmersion = Hora;
                    objInmersion.Temperatura_Agua = temperatura;
                    objInmersion.Duracion_Inmersion = 2;
                    objInmersion.Estado = "Activo";

                    if (!DatosInmersion.Guardar(objInmersion))
                    {
                        exito = false;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay Bines para Sumergir", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (exito)
            {
                MessageBox.Show("Inmersión Realizada", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Movimientos(Tipo_Mov);
                LlenarEntrada();
                DGVDisponible.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un problema al realizar la inmersión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LlenarEntrada()
        {
            List<OBJDetalleCosecha> listaBines = DatosInmersion.BinesDisponibles();

            try
            {

                // Itera para agregar al DataGrid
                foreach (OBJDetalleCosecha objDetalle in listaBines)
                {
                    int rowIndex = DGVDisponible.Rows.Add();
                    DataGridViewRow row = DGVDisponible.Rows[rowIndex];
                    row.Cells["IDDetalle"].Value = objDetalle.ID_Detalle;
                    row.Cells["NumBoleta"].Value = objDetalle.Boleta_ID;
                    row.Cells["NumBin"].Value = objDetalle.N_Bin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DGVDisponible_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada en el primer DataGrid
            DataGridViewRow selectedRow = DGVDisponible.Rows[e.RowIndex].Clone() as DataGridViewRow;
            foreach (DataGridViewCell cell in DGVDisponible.Rows[e.RowIndex].Cells)
            {
                selectedRow.Cells[cell.ColumnIndex].Value = cell.Value;
            }

            // Agregar la fila al segundo DataGrid
            DGVSumergido.Rows.Add(selectedRow);
            DGVDisponible.Rows.RemoveAt(e.RowIndex);
        }

        private void DGVSumergido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada en el primer DataGrid
            DataGridViewRow selectedRow = DGVSumergido.Rows[e.RowIndex].Clone() as DataGridViewRow;
            foreach (DataGridViewCell cell in DGVSumergido.Rows[e.RowIndex].Cells)
            {
                selectedRow.Cells[cell.ColumnIndex].Value = cell.Value;
            }

            // Agregar la fila al segundo DataGrid
            DGVDisponible.Rows.Add(selectedRow);
            DGVSumergido.Rows.RemoveAt(e.RowIndex);
        }

       

        private void Movimientos(string tipo_mov)
        {
            DateTime FechaHora = DateTime.Now;

            DateTime Fecha = FechaHora.Date;

            TimeSpan Hora = FechaHora.TimeOfDay;

            int IDDis_Movimiento = DatosMovimiento.ObtenerProximoIDDisponible();
            int IDUSER = VenMenuPrincipal.ObtenerIDActivo();

            OBJMovimiento objMovimiento = new OBJMovimiento();
            objMovimiento.ID_Movimiento = IDDis_Movimiento;
            objMovimiento.ID_Usuario = IDUSER;
            objMovimiento.Seccion = Seccion;
            objMovimiento.Tipo_Movimiento = tipo_mov;
            objMovimiento.Fecha_Movimiento = Fecha;
            objMovimiento.Hora_Movimiento = Hora;
            objMovimiento.Estado = "Activo";

            if (DatosMovimiento.GuardarMovimiento(objMovimiento))
            {
            }
            else
            {
                MessageBox.Show("No fue posible registrar el movimiento.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBx_BusquedaBol_TextChanged(object sender, EventArgs e)
        {
            // Limpiar la selección actual en el DataGridView
            DGVDisponible.ClearSelection();

            // Obtener el número de boleta introducido en el TextBox
            int numeroBoleta;
            if (int.TryParse(TxtBx_BusquedaBol.Text, out numeroBoleta))
            {
                // Recorrer todas las filas del DataGridView y ocultar las que no coincidan con el número de boleta buscado
                foreach (DataGridViewRow row in DGVDisponible.Rows)
                {
                    if (row.Cells["NumBoleta"].Value != null && (int)row.Cells["NumBoleta"].Value != numeroBoleta)
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {
                // Si el texto del TextBox no es un número válido, mostrar todas las filas
                foreach (DataGridViewRow row in DGVDisponible.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void TxtBx_BusquedaBol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
        }

    }
}
