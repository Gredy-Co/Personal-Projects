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
    public partial class VenEmpaqueYPalletizadoCRUD : Form
    {
        public VenEmpaqueYPalletizadoCRUD()
        {
            InitializeComponent();
        }

        private void Btn_Empacar_Click(object sender, EventArgs e)
        {

            DateTime FechaHora = DateTime.Now;
            DateTime Fecha = FechaHora.Date;
            TimeSpan Hora = FechaHora.TimeOfDay;

            int frutas = DatosEmpaque.CantidadTotalFrutasBoletasEnInmersion();
            Random rnd = new Random();

            // Defini los tamaños posibles
            int[] tamanos = { 4, 5, 6, 7, 8, 9, 10 };

            // Crea un diccionario para almacenar la cantidad de frutas por tamaño
            Dictionary<int, int> frutasPorTamano = new Dictionary<int, int>();

            // Inicializa el diccionario
            foreach (int tamano in tamanos)
            {
                frutasPorTamano[tamano] = 0;
            }

            // Asigna tamaños a las frutas
            for (int i = 0; i < frutas; i++)
            {
                // Escoge un tamaño aleatorio
                int tamano = tamanos[rnd.Next(tamanos.Length)];

                // Incrementa la cantidad de frutas de ese tamaño
                frutasPorTamano[tamano]++;
            }

            // Ahora frutasPorTamano contiene la cantidad de frutas por cada tamaño
            List<OBJEmpaque> listaEmpaques = new List<OBJEmpaque>();
            List<OBJPalletizado> listaPallets = new List<OBJPalletizado>();
            int numeroPallet = 1;
            string mensaje = "";
            int cajasTotales = 0;

            foreach (KeyValuePair<int, int> entry in frutasPorTamano)
            {
                OBJEmpaque empaque      = new OBJEmpaque();
                empaque.ID_Empaque      = DatosEmpaque.ObtenerProximoIDDisponible();
                empaque.Tamano_Fruta    = entry.Key;
                empaque.Cantidad_Fruta  = entry.Value;
                empaque.Cantidad_Cajas  = (int)Math.Ceiling((double)entry.Value / entry.Key); // Calcular la cantidad de cajas
                empaque.Fecha_Empaque   = Fecha;
                empaque.Hora_Empaque    = Hora;
                empaque.Estado          = "Activo";


                listaEmpaques.Add(empaque);

                if (DatosEmpaque.Guardar(empaque))
                {
                    //MessageBox.Show("Empaque Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible guardar los datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Agregar la información al mensaje
                mensaje += "Tamaño de fruta: " + empaque.Tamano_Fruta + ", Cantidad de frutas: " + empaque.Cantidad_Fruta + ", Cajas: " + empaque.Cantidad_Cajas + "\n";

                // Sumar a las cajas totales
                cajasTotales += empaque.Cantidad_Cajas;
            }

            // Crear pallets para las cajas
            while (cajasTotales > 0)
            {
                OBJPalletizado pallet           = new OBJPalletizado();
                pallet.ID_Palletizado           = DatosPalletizado.ObtenerProximoIDDisponible();
                pallet.Numero_Pallet            = numeroPallet++;
                pallet.Cantidad_Cajas_En_Pallet = (cajasTotales >= 80) ? 80 : cajasTotales; // Mínimo 80 cajas por pallet excepto el último
                pallet.Fecha_Palletizado        = Fecha;
                pallet.Hora_Palletizado         = Hora;
                pallet.Destino_Pallet           = "Santa Rosa";
                pallet.Estado                   = "Activo";

                listaPallets.Add(pallet);

                cajasTotales -= pallet.Cantidad_Cajas_En_Pallet;

                if (DatosPalletizado.Guardar(pallet))
                {
                    //MessageBox.Show("Empaque Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible guardar los datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Mostrar el mensaje
            MessageBox.Show(mensaje, "Información de empaque");

            // Mostrar la cantidad total de pallets en un MessageBox
            MessageBox.Show("Se crearon " + listaPallets.Count + " pallets.", "Información de palletizado");

            DatosEmpaque.ActualizarEstadoInmersion();

        }
    }
}
