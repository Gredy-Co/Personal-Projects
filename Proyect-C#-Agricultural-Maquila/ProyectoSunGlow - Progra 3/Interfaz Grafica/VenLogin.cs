using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Logica;
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
    public partial class VenLogin : Form
    {
        public VenLogin()
        {
            InitializeComponent();
            TxtBx_UsuarioVL.KeyDown += TextBox_KeyDown;
            TxtBx_ContrasenaVL.KeyDown += TextBox_KeyDown;
        }

        private void Btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string Nombre_Usuario = TxtBx_UsuarioVL.Texts.Trim();
            string ContrasenaIngresada = TxtBx_ContrasenaVL.Texts.Trim();
            string ContrasenaEncriptada = DatosUsuario.EncriptarContrasena(ContrasenaIngresada);

            // Verificar si los campos obligatorios están vacíos
            if (string.IsNullOrEmpty(Nombre_Usuario) || string.IsNullOrEmpty(ContrasenaIngresada))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario y la contraseña.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consultar usuario y contraseña en la base de datos
            OBJUsuario miuser = DatosUsuario.ConsultarLogin(Nombre_Usuario, ContrasenaEncriptada);

            // Verificar si el usuario existe
            if (miuser == null)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venAdmin            = new Interfaz_Grafica.VenMenuPrincipal(miuser.ID_Usuario, miuser.Rol);
            venAdmin.Correo         = miuser.Correo;
            venAdmin.Nombre_Usuario = miuser.Nombre_Usuario;
            venAdmin.Nombre         = miuser.Nombre;
            venAdmin.Apellido       = miuser.Apellido1;

            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AbrirFormulario(venAdmin);           
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprime el sonido de "beep"
                SendKeys.Send("{TAB}"); // Simula la tecla TAB para mover el foco al siguiente control
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

        private void ChBx_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBx_Mostrar.Checked == true)
            {
                TxtBx_ContrasenaVL.PasswordChar = false;
                OjoCerrado.Visible = false;
            }
            else
            {
                TxtBx_ContrasenaVL.PasswordChar = true;
                OjoCerrado.Visible = true;
            }
        }
    }
}
