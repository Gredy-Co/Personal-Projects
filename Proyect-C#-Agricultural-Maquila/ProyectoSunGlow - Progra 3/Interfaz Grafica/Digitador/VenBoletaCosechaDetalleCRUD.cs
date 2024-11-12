using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Digitador
{
    public partial class VenBoletaCosechaDetalleCRUD : Form
    {
        private VenMenuPrincipal Pnl_Principal;

        public VenBoletaCosechaDetalleCRUD(VenMenuPrincipal pnl_Principal)
        {
            InitializeComponent();
            this.Pnl_Principal = pnl_Principal;

            //Permite desactivar la edición en los ComboBox
            CmbBx_Envio.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_BinFK.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_FincaFK.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_LoteFK.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_BloqueFK.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_VariedadFrutoFK.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_TipoFrutoFK.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Todas las variables globales me sirven para manejar de mejor manera la información
        bool ConsultadoBoleta;

        int IDBoletaCosechaTemp;

        int IDEnvioFKTemp;
        string EnvioTemp;

        decimal PesoNeto;


        int IDBinFKTemp;
        string BinTemp;
        int NumeroBinTemp;

        int IDFincaFKTemp;
        string NombreFincaTemp;

        int IDLoteFKTemp;
        string NombreLoteTemp;

        int IDBloqueFKTemp;
        string NombreBloqueTemp;

        int IDVariedadFrutoFKTemp;
        string NombreVariedadFrutoTemp;

        int IDTipoFrutoFKTemp;
        string NombreTipoFrutoTemp;

        int CantidadNBines;
        decimal PesoPiña;

        string EstadoTemp;

        string Seccion = "Gestión De Boleta de Cosecha y Detalle";



        // Guarda la boleta en la base de datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Boleta de Cosecha";

            int IDDis_Boleta = DatosBoletaCosecha.ObtenerProximoIDDisponible();


            if (string.IsNullOrWhiteSpace(TxtBx_Consecutivo.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el Número del Consecutivo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_CantFrutas.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar la cantidad de Frutas", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OBJBoletaCosecha objBoleta      = new OBJBoletaCosecha();
                objBoleta.ID_Boleta             = IDDis_Boleta;
                objBoleta.Consecutivo_Boleta    = int.Parse(TxtBx_Consecutivo.Text.Trim());
                objBoleta.Envio_ID              = int.Parse(CmbBx_Envio.SelectedItem.ToString());
                objBoleta.Cuadrilla             = TxtBx_Cuadrilla.Text.Trim();
                objBoleta.Fecha_Cosecha         = DTPFecha.Value.Date;
                objBoleta.Hora_Cosecha          = DTPFecha.Value.TimeOfDay;
                objBoleta.Estado                = "Activo";

                if (!DatosBoletaCosecha.Guardar(objBoleta))
                {
                    MessageBox.Show("Error al guardar la boleta de cosecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (DataGridViewRow dataGridViewRow in DTVBines.Rows)
                {
                    // Verifica en cada for que la fila no sea vacía
                    if (!dataGridViewRow.IsNewRow)
                    {
                        // Procesa la fila solo si no está vacía
                        OBJDetalleCosecha objDetalle    = new OBJDetalleCosecha();
                        objDetalle.ID_Detalle           = DatosDetalleCosecha.ObtenerProximoIDDisponible();
                        objDetalle.Boleta_ID            = IDDis_Boleta;
                        objDetalle.N_Bin                = Convert.ToInt32(dataGridViewRow.Cells["NumeroBin"].Value);
                        objDetalle.Cantidad_Fruta       = Convert.ToInt32(dataGridViewRow.Cells["CantidadFruta"].Value);
                        objDetalle.Promedio_Fruta       = Convert.ToDecimal(dataGridViewRow.Cells["PromedioFruta"].Value);
                        objDetalle.Finca_ID             = Convert.ToInt32(dataGridViewRow.Cells["FincaID"].Value);
                        objDetalle.Lote_ID              = Convert.ToInt32(dataGridViewRow.Cells["LoteID"].Value);
                        objDetalle.Bloque_ID            = Convert.ToInt32(dataGridViewRow.Cells["BloqueID"].Value);
                        objDetalle.Variedad_Fruto_ID    = Convert.ToInt32(dataGridViewRow.Cells["VariedadFrutoID"].Value);
                        objDetalle.Tipo_Fruto_ID        = Convert.ToInt32(dataGridViewRow.Cells["TipoFrutoID"].Value);
                        objDetalle.Estado               = "Activo";

                        if (!DatosDetalleCosecha.Guardar(objDetalle))
                        {
                            MessageBox.Show("Error al guardar el detalle de la cosecha para la boleta " + objDetalle.Boleta_ID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Mostrar mensaje de éxito una vez que se hayan guardado todas las boletas y detalles correctamente
                MessageBox.Show("Boleta y detalles de cosecha guardados", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Movimientos(Tipo_Mov);
                LimpiarInformacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace); // Esto imprimirá la pila de llamadas para ayudarte a localizar el origen del error.
            }
        }




        public void BinesDeLaBoleta()
        {
            
            DTVBines.Rows.Clear();
            DateTime fechaSeleccionada = DTPFecha.Value.Date;

            List<OBJDetalleCosecha> listadetalles = DatosBoletaCosecha.DetallesLigadosBoleta(IDBoletaCosechaTemp);

            try
            {

                // Itera para agregar al DataGrid
                foreach (OBJDetalleCosecha detalle in listadetalles)
                {
                    int rowIndex = DTVBines.Rows.Add();
                    DataGridViewRow row = DTVBines.Rows[rowIndex];
                    row.Cells["NumeroBin"].Value = detalle.N_Bin;
                    row.Cells["CantidadFruta"].Value = detalle.Cantidad_Fruta;
                    row.Cells["PromedioFruta"].Value = detalle.Promedio_Fruta;
                    row.Cells["NombreFinca"].Value = NombreFincaTemp;
                    row.Cells["NombreLote"].Value = NombreLoteTemp;
                    row.Cells["NombreBloque"].Value = NombreBloqueTemp;
                    row.Cells["VariedadFruto"].Value = NombreVariedadFrutoTemp;
                    row.Cells["TipoFruto"].Value = detalle.Tipo_Fruto_ID; 
                    row.Cells["FincaID"].Value = detalle.Finca_ID;
                    row.Cells["LoteID"].Value = detalle.Lote_ID; ;
                    row.Cells["BloqueID"].Value = detalle.Bloque_ID;
                    row.Cells["VariedadFrutoID"].Value = detalle.Variedad_Fruto_ID;
                    row.Cells["TipoFrutoID"].Value = detalle.Tipo_Fruto_ID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        // Trae los datos de la Ventana de Entrada Boletas y los carga
        public void LlenarDatosBoleta(int idBoleta, string consecutivo, int envioID, string cuadrilla, string fecha, TimeSpan horaCosecha, string estado)
        {

            IDBoletaCosechaTemp = idBoleta;

            TxtBx_Consecutivo.Text = consecutivo;
            CmbBx_Envio.Text = envioID.ToString();
            TxtBx_Cuadrilla.Text = cuadrilla;

            // Parsear la cadena de fecha al formato esperado
            DateTime fechaFormateada = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Establecer la fecha y hora en el DateTimePicker
            DTPFecha.Value = fechaFormateada;


            DTPHora.Value = DateTime.Today.Add(horaCosecha);

            EstadoTemp = estado.ToString();

            ConsultadoBoleta = true;

            BinesDeLaBoleta();


        }

        private void LlenarTablaBines()
        {
            int rowIndex = DTVBines.Rows.Add();
            DataGridViewRow row = DTVBines.Rows[rowIndex];
            row.Cells["IDEnvio"].Value = IDEnvioFKTemp;
            row.Cells["NumeroBin"].Value = NumeroBinTemp;
            row.Cells["CantidadFruta"].Value = int.Parse(TxtBx_CantFrutas.Text);
            row.Cells["PromedioFruta"].Value = PesoPiña.ToString("0.##");
            row.Cells["NombreFinca"].Value = NombreFincaTemp;
            row.Cells["NombreLote"].Value = NombreLoteTemp;
            row.Cells["NombreBloque"].Value = NombreBloqueTemp;
            row.Cells["VariedadFruto"].Value = NombreVariedadFrutoTemp;
            row.Cells["TipoFruto"].Value = NombreTipoFrutoTemp;
            row.Cells["FincaID"].Value = IDFincaFKTemp;
            row.Cells["LoteID"].Value = IDLoteFKTemp;
            row.Cells["BloqueID"].Value = IDBloqueFKTemp;
            row.Cells["VariedadFrutoID"].Value = IDVariedadFrutoFKTemp;
            row.Cells["TipoFrutoID"].Value = IDTipoFrutoFKTemp;
        }





        // Añade un Bin al Data Grid Bines
        private void Btn_AñadirBin_Click(object sender, EventArgs e)
        {

            // Verificar si ya existe un bin con el mismo número
            foreach (DataGridViewRow existingRow in DTVBines.Rows)
            {
                // Obtener el número de bin de la fila actual
                int numeroBinExistente;
                if (existingRow.Cells["NumeroBin"].Value != null && int.TryParse(existingRow.Cells["NumeroBin"].Value.ToString(), out numeroBinExistente))
                {
                    // Verificar si el número de bin actual es igual al número de bin nuevo
                    if (numeroBinExistente == NumeroBinTemp)
                    {
                        MessageBox.Show("Ya existe un bin con el mismo número. Por favor, elija otro número de bin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            CalcularPesoPromedio();

            int rowIndex = DTVBines.Rows.Add();
            DataGridViewRow row = DTVBines.Rows[rowIndex];
            row.Cells["IDEnvio"].Value = IDEnvioFKTemp;
            row.Cells["NumeroBin"].Value = NumeroBinTemp;
            row.Cells["CantidadFruta"].Value = int.Parse(TxtBx_CantFrutas.Text);
            row.Cells["PromedioFruta"].Value = PesoPiña.ToString("0.##");
            row.Cells["NombreFinca"].Value = NombreFincaTemp;
            row.Cells["NombreLote"].Value = NombreLoteTemp;
            row.Cells["NombreBloque"].Value = NombreBloqueTemp;
            row.Cells["VariedadFruto"].Value = NombreVariedadFrutoTemp;
            row.Cells["TipoFruto"].Value = NombreTipoFrutoTemp;
            row.Cells["FincaID"].Value = IDFincaFKTemp;
            row.Cells["LoteID"].Value = IDLoteFKTemp;
            row.Cells["BloqueID"].Value = IDBloqueFKTemp;
            row.Cells["VariedadFrutoID"].Value = IDVariedadFrutoFKTemp;
            row.Cells["TipoFrutoID"].Value = IDTipoFrutoFKTemp;
        }



        private void Btn_EliminarBin_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (DTVBines.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = DTVBines.SelectedRows[0];

                // Eliminar la fila seleccionada del DataGridView
                DTVBines.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarComboBoxEnvios()
        {
            List<string> envios = DatosBoletaCosecha.ConsultarEnvios();

            // Limpiar ComboBox 
            CmbBx_Envio.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string envio in envios)
            {
                CmbBx_Envio.Items.Add(envio);
            } 
           
            if (CmbBx_Envio.Items.Count > 0)
            {
                CmbBx_Envio.SelectedIndex = 0; // Selecciona el primer elemento
            }
        }



        private void CargarComboBoxBines()
        {
            List<string> numerosBines = DatosBoletaCosecha.ConsultarNumerosBines();

            // Limpiar ComboBox 
            CmbBx_BinFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string numero in numerosBines)
            {
                CmbBx_BinFK.Items.Add(numero);
            }

            if (CmbBx_BinFK.Items.Count > 0)
            {
                CmbBx_BinFK.SelectedIndex = 0; // Selecciona el primer elemento
            }
        }



        private void CargarComboBoxFincas()
        {
            List<string> nombresFincas = DatosBoletaCosecha.CargarNombresFincas();

            // Limpiar ComboBox 
            CmbBx_FincaFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresFincas)
            {
                CmbBx_FincaFK.Items.Add(nombre);
            }
        }


        private void CargarComboBoxLotes()
        {
            List<string> nombresLotes = DatosBoletaCosecha.CargarNombresLotes(IDFincaFKTemp);

            // Limpiar ComboBox 
            CmbBx_LoteFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresLotes)
            {
                CmbBx_LoteFK.Items.Add(nombre);
            }
        }


        private void CargarComboBoxBloques()
        {
            List<string> nombresBloques = DatosBoletaCosecha.CargarNombresBloques(IDLoteFKTemp);

            // Limpiar ComboBox 
            CmbBx_BloqueFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresBloques)
            {
                CmbBx_BloqueFK.Items.Add(nombre);
            }
        }

        private void CargarComboBoxVariedadFruto()
        {
            List<string> nombreFrutos = DatosBoletaCosecha.CargarNombresVariedadFruto();

            // Limpiar ComboBox 
            CmbBx_VariedadFrutoFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombreFrutos)
            {
                CmbBx_VariedadFrutoFK.Items.Add(nombre);
            }

            if (CmbBx_VariedadFrutoFK.Items.Count > 0)
            {
                CmbBx_VariedadFrutoFK.SelectedIndex = 0; // Selecciona el primer elemento
            }
        }


        private void CargarComboBoxTipoFruto()
        {
            List<string> tipoFrutos = DatosBoletaCosecha.CargarTipoFruto();

            // Limpiar ComboBox 
            CmbBx_TipoFrutoFK.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string tipo in tipoFrutos)
            {
                CmbBx_TipoFrutoFK.Items.Add(tipo);
            }

            if (CmbBx_TipoFrutoFK.Items.Count > 0)
            {
                CmbBx_TipoFrutoFK.SelectedIndex = 0; // Selecciona el primer elemento
            }
        }


        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            Pnl_Principal.AbrirFormulario(new VenEntradaBoletas(Pnl_Principal));
        }

        private void VenBoletaCosechaDetalleCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoBoleta = false;

            CmbBx_BinFK.Enabled     = false;
            CmbBx_FincaFK.Enabled   = false;
            CmbBx_LoteFK.Enabled    = false;
            CmbBx_BloqueFK.Enabled  = false;
            CargarComboBoxEnvios();
            CargarComboBoxVariedadFruto();
            CargarComboBoxTipoFruto();
        }


        private void CmbBx_Envio_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnvioTemp = CmbBx_Envio.SelectedItem.ToString();
            int Envio = int.Parse(EnvioTemp);


            OBJRecepcionEnvio objEnvio = DatosRecepcionEnvio.Consultar(Envio);
            if (objEnvio == null)
            {
                MessageBox.Show("El Envio no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDEnvioFKTemp = objEnvio.ID_Recepcion;
                CantidadNBines = objEnvio.N_Bines;
                PesoNeto = objEnvio.Peso_Neto;
                CmbBx_BinFK.Enabled = true;
                CargarComboBoxBines();
            }
        }

        private void CmbBx_BinFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinTemp = CmbBx_BinFK.SelectedItem.ToString();
            NumeroBinTemp = int.Parse(BinTemp);
            CmbBx_FincaFK.Enabled = true;
            CargarComboBoxFincas();
        }

        private void CmbBx_FincaFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreFincaTemp = CmbBx_FincaFK.SelectedItem.ToString();

            OBJFinca objFinca = DatosBoletaCosecha.ConsultarNombresFincas(NombreFincaTemp);
            if (objFinca == null)
            {
                MessageBox.Show("La Finca no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDFincaFKTemp = objFinca.ID_Finca;
                CmbBx_LoteFK.Enabled = true;
                CargarComboBoxLotes();

                if (CmbBx_LoteFK.Items.Count > 0)
                {
                    CmbBx_LoteFK.SelectedIndex = 0; // Selecciona el primer elemento
                }
            }
        }

        private void CmbBx_LoteFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreLoteTemp = CmbBx_LoteFK.SelectedItem.ToString();

            OBJLote objLote = DatosBoletaCosecha.ConsultarNombresLotes(IDFincaFKTemp);
            if (objLote == null)
            {
                MessageBox.Show("El Lote no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDLoteFKTemp = objLote.ID_Lote;
                CmbBx_BloqueFK.Enabled = true;
                CargarComboBoxBloques();

                if (CmbBx_BloqueFK.Items.Count > 0)
                {
                    CmbBx_BloqueFK.SelectedIndex = 0; // Selecciona el primer elemento
                }
            }
        }

        private void CmbBx_BloqueFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreBloqueTemp = CmbBx_BloqueFK.SelectedItem.ToString();

            OBJBloque objBloque = DatosBoletaCosecha.ConsultarNombresBloques(IDFincaFKTemp);
            if (objBloque == null)
            {
                MessageBox.Show("El Bloque no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDBloqueFKTemp = objBloque.ID_Bloque;
            }
        }

        private void CmbBx_VariedadFrutoFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreVariedadFrutoTemp = CmbBx_VariedadFrutoFK.SelectedItem.ToString();

            OBJVariedadDeFruto objFruto = DatosBoletaCosecha.ConsultarNombresVariedadFruto(NombreVariedadFrutoTemp);
            if (objFruto == null)
            {
                MessageBox.Show("La Variedad del Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDVariedadFrutoFKTemp = objFruto.ID_Variedad_Fruto;
            }
        }

        private void CmbBx_TipoFrutoFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreTipoFrutoTemp = CmbBx_TipoFrutoFK.SelectedItem.ToString();

            OBJTipoDeFruto objFruto = DatosBoletaCosecha.ConsultarNombresTipoFruto(NombreTipoFrutoTemp);
            if (objFruto == null)
            {
                MessageBox.Show("El Tipo de Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDTipoFrutoFKTemp = objFruto.ID_Tipo_De_Fruto;
            }
        }

        private void TxtBx_CantFrutas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela el evento para bloquear la entrada
                e.Handled = true;
            }
        }

        private void TxtBx_Consecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Movimientos(string tipo_mov)
        {
            DateTime FechaHora      = DateTime.Now;

            DateTime Fecha          = FechaHora.Date;

            TimeSpan Hora           = FechaHora.TimeOfDay;

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
            ConsultadoBoleta = false;

            IDBoletaCosechaTemp = 0;

            IDEnvioFKTemp = 0;
            EnvioTemp = "";

            PesoNeto = 0.0m;

            IDBinFKTemp = 0;
            BinTemp = "";
            NumeroBinTemp = 0;

            IDFincaFKTemp = 0;
            NombreFincaTemp = "";

            IDLoteFKTemp = 0;
            NombreLoteTemp = "";

            IDBloqueFKTemp = 0;
            NombreBloqueTemp = "";

            IDVariedadFrutoFKTemp = 0;
            NombreVariedadFrutoTemp = "";

            IDTipoFrutoFKTemp = 0;
            NombreTipoFrutoTemp = "";

            CantidadNBines = 0;
            PesoPiña = 0.0m;

            DTVBines.Rows.Clear();

            CargarComboBoxEnvios();
            CargarComboBoxBines();
            CargarComboBoxVariedadFruto();
            CargarComboBoxTipoFruto();

            TxtBx_Consecutivo.Text = "";
            TxtBx_Cuadrilla.Text = "";
            TxtBx_CantFrutas.Text = "";

            CmbBx_BinFK.Enabled = false;
            CmbBx_FincaFK.Enabled = false;
            CmbBx_LoteFK.Enabled = false;
            CmbBx_BloqueFK.Enabled = false;

            CargarComboBoxLotes();
            CargarComboBoxBloques();
        }

        private void CalcularPesoPromedio() 
        {
            decimal PesoBin = PesoNeto / CantidadNBines;
            PesoPiña = PesoBin / int.Parse(TxtBx_CantFrutas.Text);
        }
    }
}
