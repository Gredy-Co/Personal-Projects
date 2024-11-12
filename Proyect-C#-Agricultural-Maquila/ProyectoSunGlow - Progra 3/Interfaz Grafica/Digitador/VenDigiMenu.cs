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
    public partial class VenDigiMenu : Form
    {
        private VenMenuPrincipal principal;

        public VenDigiMenu(VenMenuPrincipal prin)
        {
            InitializeComponent();
            this.principal = prin;
        }

        private void AbrirFormulario(object Formulario)
        {
            //Limpiar el contenedor
            Pnl_MenuDigi.Controls.Clear();

            Form FH = Formulario as Form; // Crea formulario FH, con el objeto que recibe
            FH.TopLevel = false; // Cambia el nivel del Form, asignandolo como hijo
            FH.Dock = DockStyle.Fill; // Acoplarse al tamaño del panel contenedor 

            this.Pnl_MenuDigi.Controls.Add(FH); // Agrega la ventana al panel
            this.Pnl_MenuDigi.Tag = FH; // Instancia al panel como contenedor de datos
            FH.Show(); // Mostrar el formulario 
        }

        private void Btn_BoletaCosechaVD_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new VenEntradaEnvios(principal));
        }

        private void Btn_InmersionVD_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Interfaz_Grafica.Digitador.VenInmersion());
        }

        private void Btn_EmpaquePalletizadoVD_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Interfaz_Grafica.Digitador.VenEmpaqueYPalletizadoCRUD());
        }

        private void Btn_RepBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Interfaz_Grafica.VenRepMovimientos());
        }

        private void Btn_ReportesVD_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Interfaz_Grafica.VenReportes());
        }
    }
}
