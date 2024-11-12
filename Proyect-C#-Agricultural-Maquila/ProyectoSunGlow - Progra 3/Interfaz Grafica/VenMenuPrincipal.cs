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
    public partial class VenMenuPrincipal : Form
    {
        public static int ID_Usuario { get; set; }
        public string Correo { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }

        public VenMenuPrincipal(int idUsuario, string rol)
        {
            InitializeComponent();

            HoraInterfaz.Tick += Timer_Tick;
            HoraInterfaz.Start(); // Inicia el Timer

            Rol = rol;
            ID_Usuario = idUsuario;

            if (Rol == "Administrador")
            {
                AbrirFormulario(new Interfaz_Grafica.VenAdminMenu(this));
            }
            else if (Rol == "Digitador")
            {
                AbrirFormulario(new Interfaz_Grafica.Digitador.VenDigiMenu(this));
            }
        }

        private void MostrarFechaActual()
        {
            DateTime fechaActual = DateTime.Now;

            string fechaFormateada = fechaActual.ToString("dd/MM/yyyy");

            Lbl_Fecha.Text = fechaFormateada;
        }

        public void AbrirFormulario(object Formulario)
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
            string CorreoU = Correo;

            Lbl_NombreUser.Text = NombreU + " " + ApellidoU;
            Lbl_Correo.Text = CorreoU;

            MostrarFechaActual();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;

            // Actualiza el Text del Label con la hora actual formateada
            Lbl_Tiempo.Text = horaActual.ToString("HH:mm:ss"); // Formato de hora: horas:minutos:segundos
        }

        private void Btn_MenuPrin_Click(object sender, EventArgs e)
        {
            if (Rol == "Administrador")
            {
                AbrirFormulario(new Interfaz_Grafica.VenAdminMenu(this));
            }
            else if (Rol == "Digitador")
            {
                AbrirFormulario(new Interfaz_Grafica.Digitador.VenDigiMenu(this));
            }
        }


        public static int ObtenerIDActivo()
        {
            return ID_Usuario;
        }
    }
}
