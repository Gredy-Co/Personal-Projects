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
    public partial class VenAdminMenu : Form
    {
        private VenMenuPrincipal principal;

        public VenAdminMenu(VenMenuPrincipal prin)
        {
            InitializeComponent();
            this.principal = prin;
        }

        private void Btn_UsuariosVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.VenUsuariosCRUD());
        }

        private void Btn_ProveedoresVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.VenProveedoresCRUD());
            
        }

        private void Btn_TipoDeFrutoVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenTiposDeFrutosCRUD());
        }

        private void Btn_FincasVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenFincasCRUD());
        }


        private void Btn_EmpaquePalletizadoVD_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Digitador.VenEmpaqueYPalletizadoCRUD());
        }

        private void Btn_BoletaCosechaVD_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Digitador.VenEntradaEnvios(principal));
        }

        private void Btn_InmersionVD_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Digitador.VenInmersion());
        }

        private void Btn_LotesVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenLotesCRUD());
        }

        private void Btn_BloquesVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenBloquesCRUD());
        }

        private void Btn_VariedadFrutoVA_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenVariedadDeFrutoCRUD());
        }

        private void Btn_Bines_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.Administrador.VenBinesCRUD());
        }

        private void Btn_Bitacora_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.VenReportes());
        }

        private void Btn_RepBitacora_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new Interfaz_Grafica.VenRepMovimientos());
        }
    }
}
