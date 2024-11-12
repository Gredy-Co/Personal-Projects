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

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica.Administrador
{
    public partial class VenTiposDeFrutosCRUD : Form
    {
        public VenTiposDeFrutosCRUD()
        {
            InitializeComponent();
        }



        bool ConsultadoTipoDeFruto;

        int ID_TipoFrutoTemp;
        string TipoDeFrutoTemp;
        string EstadoTemp;

        string Seccion = "Gestión De Tipos de Frutos";



        private void VenTiposDeFrutosCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoTipoDeFruto = false;
        }



        // Guarda el tipo de fruto en la bae de datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Tipo De Fruto";
            int IDDis_TipoDeFruto = DatosTipoDeFruto.ObtenerProximoIDDisponible();

            if (ConsultadoTipoDeFruto)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe un tipo de fruto
                OBJTipoDeFruto tipodefrutoExistente = DatosTipoDeFruto.Consultar(TxtBx_TipoDeFruto.Texts.Trim());
                if (tipodefrutoExistente != null)
                {
                    MessageBox.Show("Ya existe el Tipo de Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OBJTipoDeFruto objTipoDeFruto               = new OBJTipoDeFruto();
                objTipoDeFruto.ID_Tipo_De_Fruto             = IDDis_TipoDeFruto;
                objTipoDeFruto.Tipo_De_Fruto                = TxtBx_TipoDeFruto.Texts.Trim();
                objTipoDeFruto.Descripcion_Tipo_De_Fruto    = TxtBx_Descripcion.Texts.Trim();
                objTipoDeFruto.Estado                       = "Activo";

                if (DatosTipoDeFruto.Guardar(objTipoDeFruto))
                {
                    MessageBox.Show("Tipo De Fruto Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Modifica el tipo de fruto en la base de datos
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Tipo de Fruto";

            if (ConsultadoTipoDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_TipoDeFruto.Texts))
            {
                MessageBox.Show("Debe ingresar el Tipo de Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el tipo de fruto original
                    OBJTipoDeFruto datosDelTipoFruto = DatosTipoDeFruto.Consultar(TipoDeFrutoTemp);
                    if (datosDelTipoFruto == null)
                    {
                        MessageBox.Show("El Tipo de Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el Tipo de Fruto que se está modificando existe en la base de datos
                    OBJTipoDeFruto tipofrutoExistente = DatosTipoDeFruto.ConsultarPorIDTipoFruto(ID_TipoFrutoTemp);
                    if (tipofrutoExistente == null)
                    {
                        MessageBox.Show("El Tipo de Fruto que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del Tipo de fruto ya existe en la base de datos, excluyendo el fruto que se está modificando actualmente
                    string nuevoNombreTipoFruto = TxtBx_TipoDeFruto.Texts.Trim();
                    if (nuevoNombreTipoFruto != datosDelTipoFruto.Tipo_De_Fruto)
                    {
                        OBJTipoDeFruto TipoFrutoExistentePorNombre = DatosTipoDeFruto.Consultar(nuevoNombreTipoFruto);
                        if (TipoFrutoExistentePorNombre != null && TipoFrutoExistentePorNombre.ID_Tipo_De_Fruto != datosDelTipoFruto.ID_Tipo_De_Fruto)
                        {
                            MessageBox.Show("Ya existe el Tipo De Fruto con el mismo nombre en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    // Crea un nuevo objeto Tioo De Fruto para la modificación
                    OBJTipoDeFruto objTipoDeFruto = new OBJTipoDeFruto();
                    objTipoDeFruto.ID_Tipo_De_Fruto = datosDelTipoFruto.ID_Tipo_De_Fruto;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objTipoDeFruto.Tipo_De_Fruto                = string.IsNullOrWhiteSpace(TxtBx_TipoDeFruto.Texts) ? datosDelTipoFruto.Tipo_De_Fruto              : TxtBx_TipoDeFruto.Texts.Trim();
                    objTipoDeFruto.Descripcion_Tipo_De_Fruto    = string.IsNullOrWhiteSpace(TxtBx_Descripcion.Texts) ? datosDelTipoFruto.Descripcion_Tipo_De_Fruto  : TxtBx_Descripcion.Texts.Trim();
                    objTipoDeFruto.Estado                       = datosDelTipoFruto.Estado;

                    // Actualiza el Tipo de Fruto en la base de datos
                    if (DatosTipoDeFruto.Actualizar(objTipoDeFruto))
                    {
                        MessageBox.Show("Datos del Tipo De Fruto modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Consulta el Tipo de Fruto en la base de datos
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Tipo De Fruto";

            if (TxtBx_TipoDeFruto.Texts.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar el Tipo De Fruto.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJTipoDeFruto objTipoDeFruto = DatosTipoDeFruto.Consultar(TxtBx_TipoDeFruto.Texts.Trim());
                if (objTipoDeFruto == null)
                {
                    MessageBox.Show("El Tipo De Fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ID_TipoFrutoTemp        = objTipoDeFruto.ID_Tipo_De_Fruto;
                    TipoDeFrutoTemp         = objTipoDeFruto.Tipo_De_Fruto;
                    TxtBx_Descripcion.Texts = objTipoDeFruto.Descripcion_Tipo_De_Fruto;
                    EstadoTemp              = objTipoDeFruto.Estado;
              
                    ConsultadoTipoDeFruto = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }




        // Elimina el tipo de Fruto poniendo el Estado en Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Tipo De Fruto";

            if (ConsultadoTipoDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el tipo de fruto está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El Tipo de Fruto ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Tipo de Fruto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJTipoDeFruto objTipoDeFruto   = new OBJTipoDeFruto();
                        objTipoDeFruto.ID_Tipo_De_Fruto = ID_TipoFrutoTemp;
                        objTipoDeFruto.Estado           = "Inactivo";

                        if (DatosTipoDeFruto.CambiarEstado(objTipoDeFruto))
                        {
                            MessageBox.Show("Tipo De Fruto Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar al Usuario.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Reactiva el tipo de fruto poniendo el estado en Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Tipo De Fruto";

            if (ConsultadoTipoDeFruto == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el tipo de fruto está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El Tipo de Fruto ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar el Tipo de Fruto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJTipoDeFruto objTipoDeFruto = new OBJTipoDeFruto();
                        objTipoDeFruto.ID_Tipo_De_Fruto = ID_TipoFrutoTemp;
                        objTipoDeFruto.Estado = "Activo";

                        if (DatosTipoDeFruto.CambiarEstado(objTipoDeFruto))
                        {
                            MessageBox.Show("Tipo De Fruto Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar el Tipo de Fruto.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        // Guarda todos los movimientos en la Bitácora
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

            // Guarda el movimiento en la base de datos
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
            ConsultadoTipoDeFruto   = false;
            ID_TipoFrutoTemp        = 0;
            TipoDeFrutoTemp         = "";
            TxtBx_TipoDeFruto.Texts = "";
            TxtBx_Descripcion.Texts = "";
        }
    }
}
