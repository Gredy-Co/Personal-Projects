using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Logica;
using ProyectoSunGlow___Progra_3.ToolBox_Personalizado;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace ProyectoSunGlow___Progra_3
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
            AbrirFormulario(new Interfaz_Grafica.VenLogin());
        }

        bool Movimiento = false; //Variable Control Movimiento Ventana

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btn_Restaurar.Visible = true;
            Btn_Maximizar.Visible = false;
        }

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Si el usuario confirma, se cierra la sesión
                AbrirFormulario(new Interfaz_Grafica.VenLogin());

            }
        }

        private void Pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento = true;
        }

        private void Pnl_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            Movimiento = false;
        }

        private void Pnl_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movimiento == true)
            {
                this.Location = Cursor.Position;
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suprime el sonido de "beep"
                SendKeys.Send("{TAB}"); // Simula la tecla TAB para mover el foco al siguiente control
            }
        }

        private void Btn_Cerrar_MouseHover(object sender, EventArgs e)
        {
            string Info = "Cerrar Programa";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Cerrar, Info);
        }

        private void Btn_Maximizar_MouseHover(object sender, EventArgs e)
        {
            string Info = "Maximizar Ventana";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Maximizar, Info);
        }

        private void Btn_Restaurar_MouseHover(object sender, EventArgs e)
        {
            string Info = "Restaurar Ventana";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Restaurar, Info);
        }

        private void Btn_Minimizar_MouseHover(object sender, EventArgs e)
        {
            string Info = "Minimizar Ventana";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_Minimizar, Info);
        }

        private void Btn_CerrarSesion_MouseHover(object sender, EventArgs e)
        {
            string Info = "Cerrar Sesión";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btn_CerrarSesion, Info);
        }
    }
}

    
    

