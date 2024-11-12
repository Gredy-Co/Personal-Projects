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
    public partial class VenBloquesCRUD : Form
    {
        public VenBloquesCRUD()
        {
            InitializeComponent();
            CmbBx_Lotes.DropDownStyle   = ComboBoxStyle.DropDownList;
            CmbBx_Frutos.DropDownStyle  = ComboBoxStyle.DropDownList;

        }



        bool ConsultadoBloque;

        string Seccion = "Gestión De Bloques";

        int IDBloqueTemp;
        int IDLoteTemp;
        int IDFrutoTemp;

        string NombreBloqueTemp;
        string NombreLoteTemp;
        string NombreFrutoTemp;

        string EstadoTemp;



        // Guarda los datos de los Bloques
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Bloque";
            int IDDis_Bloque = DatosBloque.ObtenerProximoIDDisponible();

            if (ConsultadoBloque)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreBloque.Texts.Trim()))
            {
                MessageBox.Show("Debe de ingresar el Nombre del Bloque", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe un bloque con el mismo nombre
                OBJBloque bloqueExistente = DatosBloque.ConsultarBloqID(TxtBx_NombreBloque.Texts.Trim(), IDLoteTemp);
                if (bloqueExistente != null && bloqueExistente.Lote_ID == IDLoteTemp)
                {
                    MessageBox.Show("Ya existe un Bloque con el mismo nombre en el Lote.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                OBJBloque objBloque         = new OBJBloque();
                objBloque.ID_Bloque         = IDDis_Bloque;
                objBloque.Nombre_Bloque     = TxtBx_NombreBloque.Texts.Trim();
                objBloque.Lote_ID           = IDLoteTemp;
                objBloque.Variedad_Fruto_ID = IDFrutoTemp;
                objBloque.Estado            = "Activo";

                if (DatosBloque.Guardar(objBloque))
                {
                    MessageBox.Show("Bloque Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Movimientos(Tipo_Mov);
                    LimpiarInformacion();
                    CargarComboBoxLotes();
                    CargarComboBoxFrutos();
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



        //Modifica los datos de los Bloques
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Bloque";

            if (ConsultadoBloque == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_NombreBloque.Texts))
            {
                MessageBox.Show("Debe ingresar el Nombre del Lote.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el Lote original
                    OBJBloque datosBloque = DatosBloque.Consultar(NombreBloqueTemp);
                    if (datosBloque == null)
                    {
                        MessageBox.Show("El Bloque no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el Bloque que se está modificando existe en la base de datos
                    OBJBloque bloqueExistente = DatosBloque.ConsultarPorIDBloque(IDBloqueTemp);
                    if (bloqueExistente == null)
                    {
                        MessageBox.Show("El Bloque que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    OBJBloque BloqueExistentePorNombre = DatosBloque.ConsultarBloqID(datosBloque.Nombre_Bloque, IDLoteTemp);

                    if (BloqueExistentePorNombre != null && BloqueExistentePorNombre.Nombre_Bloque == TxtBx_NombreBloque.Texts.Trim() && BloqueExistentePorNombre.Lote_ID == IDLoteTemp)
                    {
                        MessageBox.Show("Ya existe un Bloque con el mismo nombre en el Lote.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Crea un nuevo objeto Bloque para la modificación
                    OBJBloque objBloque         = new OBJBloque();
                    objBloque.ID_Bloque         = datosBloque.ID_Bloque;

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objBloque.Nombre_Bloque     = string.IsNullOrWhiteSpace(TxtBx_NombreBloque.Texts) ? datosBloque.Nombre_Bloque : TxtBx_NombreBloque.Texts.Trim();
                    objBloque.Lote_ID           = IDLoteTemp;
                    objBloque.Variedad_Fruto_ID = IDFrutoTemp;
                    objBloque.Estado            = datosBloque.Estado;

                    // Actualiza el Bloque en la base de datos
                    if (DatosBloque.Actualizar(objBloque))
                    {
                        MessageBox.Show("Datos del Bloque modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Movimientos(Tipo_Mov);
                        LimpiarInformacion();
                        CargarComboBoxLotes();
                        CargarComboBoxFrutos();
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



        //Consulta los datos del Bloque
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Bloque";

            if (TxtBx_NombreBloque.Texts.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el Nombre del Bloque.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJBloque objBloque = DatosBloque.ConsultarBloqID(TxtBx_NombreBloque.Texts.Trim(), IDLoteTemp);
                if (objBloque == null)
                {
                    MessageBox.Show("El Bloque no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    IDBloqueTemp                = objBloque.ID_Bloque;
                    NombreBloqueTemp            = objBloque.Nombre_Bloque;

                    IDLoteTemp                  = objBloque.Lote_ID;
                    OBJLote objLote             = DatosLote.ConsultarPorIDLote(IDLoteTemp);
                    NombreLoteTemp              = objLote.Nombre_Lote;
                    CmbBx_Lotes.SelectedItem    = NombreLoteTemp;

                    IDFrutoTemp                 = objBloque.Variedad_Fruto_ID;
                    OBJVariedadDeFruto objFruto =  DatosVariedadDeFruto.ConsultarPorIDFruto(IDFrutoTemp);
                    NombreFrutoTemp             = objFruto.Nombre_Variedad;
                    CmbBx_Frutos.SelectedItem   = NombreFrutoTemp;
                                      
                    EstadoTemp                  = objBloque.Estado;

                    ConsultadoBloque = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }



        // "Elimina" el Bloque cambiándole el estado a Inactivo
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Bloque";

            if (ConsultadoBloque == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Bloque está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El Bloque ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Bloque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJBloque objBloque = new OBJBloque();
                        objBloque.ID_Bloque = IDLoteTemp;
                        objBloque.Estado    = "Inactivo";

                        if (DatosBloque.CambiarEstado(objBloque))
                        {
                            MessageBox.Show("Bloque Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar el Bloque.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //Reactiva el Bloque en la a Activo
        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Bloque";

            if (ConsultadoBloque == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el Bloque está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El Bloque ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar el Bloque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJBloque objBloque = new OBJBloque();
                        objBloque.ID_Bloque = IDLoteTemp;
                        objBloque.Estado    = "Activo";

                        if (DatosBloque.CambiarEstado(objBloque))
                        {
                            MessageBox.Show("Bloque Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar el Bloque.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        // Carga en el ComboBox los Lotes a los que desea ligar el Bloque
        private void CargarComboBoxLotes()
        {
            List<string> nombresLotes = Datos.DatosBloque.ConsultarLotes();

            // Limpiar ComboBox
            CmbBx_Lotes.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresLotes)
            {
                CmbBx_Lotes.Items.Add(nombre);
            }
        }




        // Carga en el ComboBox los Frutos a los que desea ligar el Bloque
        private void CargarComboBoxFrutos()
        {
            List<string> nombresFrutos = Datos.DatosBloque.ConsultarFrutos();

            // Limpiar ComboBox
            CmbBx_Frutos.Items.Clear();

            // Agregar los nombres al ComboBox
            foreach (string nombre in nombresFrutos)
            {
                CmbBx_Frutos.Items.Add(nombre);
            }
        }



        // Selecciona el dato del Fruto que desea
        private void CmbBx_Frutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreFruto = CmbBx_Frutos.SelectedItem.ToString();

            OBJVariedadDeFruto objFruto = DatosVariedadDeFruto.ConsultarPorNombreFruto(nombreFruto);
            if (objFruto == null)
            {
                MessageBox.Show("La Variedad de este fruto no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDFrutoTemp = objFruto.ID_Variedad_Fruto;
                NombreFrutoTemp = objFruto.Nombre_Variedad;
            }
        }




        // Selecciona el dato del Lote que desea
        private void CmbBx_Lotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreLote = CmbBx_Lotes.SelectedItem.ToString();

            OBJLote objLote = DatosLote.Consultar(nombreLote);
            if (objLote == null)
            {
                MessageBox.Show("El Bloque no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDLoteTemp      = objLote.ID_Lote;
                NombreLoteTemp  = objLote.Nombre_Lote;
            }
        }



        // Guarda en la Bitácora el Movimiento Realizado
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

            // Actualiza el proveedor en la base de datos
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
            ConsultadoBloque            = false;
            IDBloqueTemp                = 0;
            IDLoteTemp                  = 0;
            IDFrutoTemp                 = 0;


            NombreBloqueTemp            = "";
            NombreLoteTemp              = "";
            NombreFrutoTemp             = "";

            TxtBx_NombreBloque.Texts    = "";
            EstadoTemp                  = "";
        }

        //Carga los datos de los Lotes y Frutos al cargar la Ventana 
        private void VenBloquesCRUD_Load(object sender, EventArgs e)
        {
            CargarComboBoxFrutos();
            CargarComboBoxLotes();
        }
    }
}
