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

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    public partial class VenBinesCRUD : Form
    {
        public VenBinesCRUD()
        {
            InitializeComponent();
        }


        bool ConsultadoBin;

        int IDBinTemp;
        int NumeroBinTemp;
        string EstadoTemp;

        string Seccion = "Gestión De Bines";



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Bin";
            int IDDis_Bin = DatosBin.ObtenerProximoIDDisponible();

            if (ConsultadoBin)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NBin.Text.Trim()))
            {
                MessageBox.Show("Debe de ingresar el Número del Bin", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int NumBin;
            if (int.TryParse(TxtBx_NBin.Text, out NumBin))
            {
            }

            try
            {
                // Verifica si ya existe un Bin con el mismo numero
                OBJBin binExistente = DatosBin.Consultar(NumBin);
                if (binExistente != null)
                {
                    MessageBox.Show("Ya existe un Bin con el mismo Número.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OBJBin objBin       = new OBJBin();
                objBin.ID_Bin       = IDDis_Bin;
                objBin.Numero_Bin   = NumBin;
                objBin.Detalle      = TxtBx_DetalleBin.Texts.Trim();
                objBin.Estado       = "Activo";
         
                if (DatosBin.Guardar(objBin))
                {
                    MessageBox.Show("Bin Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                }
                else
                {
                    MessageBox.Show("No fue posible guardar los datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe revisar la información digitada.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Bin";

            if (ConsultadoBin == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NBin.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el Número del Bin.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el Bin original
                    OBJBin datosDelBin = DatosBin.Consultar(NumeroBinTemp);
                    if (datosDelBin == null)
                    {
                        MessageBox.Show("El Bin no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si lel Bin que se está modificando existe en la base de datos
                    OBJBin binExistente = DatosBin.ConsultarIDBIN(IDBinTemp);
                    if (binExistente == null)
                    {
                        MessageBox.Show("El Bin que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del Bin ya existe en la base de datos, excluyendo el Bin que se está modificando actualmente
                    int NumBin;
                    if (int.TryParse(TxtBx_NBin.Text, out NumBin))
                    {
                    }

                    if (NumBin != datosDelBin.Numero_Bin)
                    {
                        OBJBin BinExistenteNum = DatosBin.Consultar(NumBin);
                        if (BinExistenteNum != null && BinExistenteNum.ID_Bin == datosDelBin.ID_Bin)
                        {
                            MessageBox.Show("Ya existe un Bin con el mismo número en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Crea un nuevo objeto Bin para la modificación
                    OBJBin objBin       = new OBJBin();
                    objBin.ID_Bin       = datosDelBin.ID_Bin;
                    objBin.Numero_Bin   = NumBin;
                    objBin.Detalle      = string.IsNullOrWhiteSpace(TxtBx_DetalleBin.Texts) ? datosDelBin.Detalle : TxtBx_DetalleBin.Texts.Trim();
                    objBin.Estado       = datosDelBin.Estado;

                    // Actualiza la Finca en la base de datos
                    if (DatosBin.Actualizar(objBin))
                    {
                        MessageBox.Show("Datos del Bin modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Movimientos(Tipo_Mov);
                        LimpiarInformacion();       
                    }
                    else
                    {
                        MessageBox.Show("No fue posible modificar los datos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Bin";

            if (TxtBx_NBin.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el Número del Bin.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {

                int NumBin;
                if (int.TryParse(TxtBx_NBin.Text, out NumBin))
                {
                }

                OBJBin objBin = DatosBin.Consultar(NumBin);
                if (objBin == null)
                {
                    MessageBox.Show("El Bin no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    IDBinTemp               = objBin.ID_Bin;
                    NumeroBinTemp           = objBin.Numero_Bin;
                    TxtBx_NBin.Text         = objBin.Numero_Bin.ToString();
                    TxtBx_DetalleBin.Texts  = objBin.Detalle.ToString();
                    EstadoTemp              = objBin.Estado;
                        
                    ConsultadoBin = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }



        // Si un Bin está Activo permite eliminarlo de manera sencilla
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Bin";

            if (ConsultadoBin == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Bin está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El Bin ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Bin?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJBin objBin = new OBJBin();
                        objBin.ID_Bin = IDBinTemp;
                        objBin.Estado = "Inactivo";

                        if (DatosBin.CambiarEstado(objBin))
                        {
                            MessageBox.Show("Bin Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar el Bin.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //Si un Bin está Inactivo permite que se reactive de manera sencilla
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Bin";

            if (ConsultadoBin == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Bin está Inactivo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El Bin ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar el Bin?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJBin objBin = new OBJBin();
                        objBin.ID_Bin = IDBinTemp;
                        objBin.Estado = "Activo";

                        if (DatosBin.CambiarEstado(objBin))
                        {
                            MessageBox.Show("Bin Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar el Bin.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //Se guarda cada movimiento que el usuario realiza en la Bitácora
        private void Movimientos(string tipo_mov)
        {
            DateTime FechaHora = DateTime.Now;

            DateTime Fecha = FechaHora.Date;

            TimeSpan Hora = FechaHora.TimeOfDay;

            int IDDis_Movimiento = DatosMovimiento.ObtenerProximoIDDisponible();
            int IDUSER = VenMenuPrincipal.ObtenerIDActivo();

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
            ConsultadoBin           = false;
            IDBinTemp               = 0;
            NumeroBinTemp           = 0;
            TxtBx_NBin.Text         = "";
            TxtBx_DetalleBin.Texts  = "";
            EstadoTemp              = "";
        }



        private void TxtBx_NBin_KeyPress(object sender, KeyPressEventArgs e)
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
