using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    public partial class VenMenu : Form
    {
        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Rol {  get; set; }

        public VenMenu(string rol)
        {
            InitializeComponent();

            HoraInterfaz.Tick += Timer_Tick;
            HoraInterfaz.Start(); // Iniciar el Timer

            Rol = rol;

            if (Rol == "Administrador")
            {
                AbrirFormulario(new Interfaz_Grafica.VenAdminMenu());
            }
            else if (Rol == "Digitador")
            {
                AbrirFormulario(new Interfaz_Grafica.Digitador.VenDigiMenu());
            }
        }


        private void AbrirFormulario(object Formulario)
        {
            //Limpiar el contenedor
            Pnl_Contenedor.Controls.Clear();

            Form FH = Formulario as Form; // Crea formulario FH, con el objeto que recibe
            FH.TopLevel = false; // Cambia el nivel del Form, asignandolo como hijo
            FH.Dock = DockStyle.Fill; // Acoplarse al tamaño del panel contenedor 

            this.Pnl_Contenedor.Controls.Add(FH); // Agrega la ventana al panel
            this.Pnl_Contenedor.Tag = FH; // Instancia al panel como contenedor de datos
            FH.Show(); // Mostrar el formulario 
        }



        private void VenAdministrador_Load(object sender, EventArgs e)
        {
            string NombreU = Nombre;
            string ApellidoU = Apellido;

            Lbl_NombreUser.Text = NombreU + " " + ApellidoU;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;

            // Actualizar el Text del Label con la hora actual formateada
            Lbl_Tiempo.Text = horaActual.ToString("HH:mm:ss"); // Formato de hora: horas:minutos:segundos
        }

        private void Btn_MenuAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Interfaz_Grafica.VenAdminMenu());
        }


    }
}
