using Microsoft.Win32;
using ProyectoSunGlow___Progra_3.Datos;
using ProyectoSunGlow___Progra_3.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSunGlow___Progra_3.Interfaz_Grafica
{
    public partial class VenUsuariosCRUD : Form
    {
        public VenUsuariosCRUD()
        {
            InitializeComponent();

            CmbBx_Roles.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBx_Roles.SelectedItem = "Administrador";
        }




        bool ConsultadoEmpleado;

        // Estas variables me sirven para almacenar los datos sin que el usuario las manipule cuando hace CRUD
        int ID_UsuarioTemp;
        string NombreUsuarioTemp;
        string CedulaUsuarioTemp;
        DateTime Fecha_CreacionTemp;
        string RolTemp;
        string EstadoTemp;

        string Seccion = "Gestión De Usuarios";



        private void VenEmpleadosCRUD_Load(object sender, EventArgs e)
        {
            ConsultadoEmpleado = false;
        }


        private void CmbBx_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolTemp = CmbBx_Roles.SelectedItem.ToString();
        }



        // Guarda el Usuario en la base de datos
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Insertar Usuario";
            int IDDis_Empleado = DatosUsuario.ObtenerProximoIDDisponible();

            if (ConsultadoEmpleado)
            {
                MessageBox.Show("Los datos no son de nuevo ingreso.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_NombreUsuario.Texts))
            {
                MessageBox.Show("Debe ingresar un Nombre de Usuario.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Contrasena.Texts))
            {
                MessageBox.Show("Debe ingresar una Contraseña.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Cedula.Texts))
            {
                MessageBox.Show("Debe ingresar la Cédula.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Nombre.Texts))
            {
                MessageBox.Show("Debe ingresar un Nombre.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBx_Apellido1.Texts))
            {
                MessageBox.Show("Debe ingresar el Primer Apellido.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(RolTemp))
            {
                MessageBox.Show("Debe de seleccionar el Rol", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verifica si ya existe un usuario con el mismo nombre de usuario
                OBJUsuario usuarioExistente = DatosUsuario.ConsultarPorUsuario(TxtBx_NombreUsuario.Texts.Trim());
                if (usuarioExistente != null)
                {
                    MessageBox.Show("Ya existe un usuario con el mismo Nombre de Usuario.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verifica si ya existe un usuario con la misma cédula
                usuarioExistente = DatosUsuario.Consultar(TxtBx_Cedula.Texts.Trim());
                if (usuarioExistente != null)
                {
                    MessageBox.Show("Ya existe un usuario con la misma Cédula.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ContrasenaIngresada = TxtBx_Contrasena.Texts.Trim();
                string ContrasenaEncriptada = DatosUsuario.EncriptarContrasena(ContrasenaIngresada);

                OBJUsuario objUsuario       = new OBJUsuario();
                objUsuario.ID_Usuario       = IDDis_Empleado;
                objUsuario.Nombre_Usuario   = TxtBx_NombreUsuario.Texts.Trim();
                objUsuario.Contrasena       = ContrasenaEncriptada;
                objUsuario.Correo           = TxtBx_Correo.Texts.Trim();
                objUsuario.Cedula           = TxtBx_Cedula.Texts.Trim();
                objUsuario.Nombre           = TxtBx_Nombre.Texts.Trim();
                objUsuario.Apellido1        = TxtBx_Apellido1.Texts.Trim();
                objUsuario.Apellido2        = TxtBx_Apellido2.Texts.Trim();
                objUsuario.Fecha_Creacion   = DateTime.Now;
                objUsuario.Rol              = RolTemp;
                objUsuario.Estado           = "Activo";

                if (DatosUsuario.Guardar(objUsuario))
                {
                    MessageBox.Show("Usuario Guardado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Modifica al Usuario en la base de datos
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Modificar Usuario";

            if (ConsultadoEmpleado == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(TxtBx_Cedula.Texts))
            {
                MessageBox.Show("Debe ingresar la Cédula.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Consulta el usuario original
                    OBJUsuario datosDelUsuario = DatosUsuario.ConsultarPorUsuario(NombreUsuarioTemp);
                    if (datosDelUsuario == null)
                    {
                        MessageBox.Show("El Usuario no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica con el ID si el usuario que se está modificando existe en la base de datos
                    OBJUsuario usuarioExistente = DatosUsuario.ConsultarPorIDUsuario(ID_UsuarioTemp);
                    if (usuarioExistente == null)
                    {
                        MessageBox.Show("El usuario que intenta modificar no existe en la base de datos.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica si el nuevo nombre del usuario ya existe en la base de datos, excluyendo el usuario que se está modificando actualmente
                    string nuevoNombreUsuario = TxtBx_NombreUsuario.Texts.Trim();
                    if (nuevoNombreUsuario != datosDelUsuario.Nombre_Usuario)
                    {
                        OBJUsuario UsuarioExistentePorNombre = DatosUsuario.ConsultarPorUsuario(nuevoNombreUsuario);
                        if (UsuarioExistentePorNombre != null && UsuarioExistentePorNombre.ID_Usuario != datosDelUsuario.ID_Usuario)
                        {
                            MessageBox.Show("Ya existe un Usuario con el mismo nombre en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Verifica que no se esté ingresando una cédula ya en el sistema
                    string cedula = TxtBx_Cedula.Texts.Trim();
                    if (cedula != datosDelUsuario.Cedula)
                    {
                        OBJUsuario UsuarioExistentePorCedula = DatosUsuario.Consultar(cedula);
                        if (UsuarioExistentePorCedula != null && UsuarioExistentePorCedula.ID_Usuario != datosDelUsuario.ID_Usuario)
                        {
                            MessageBox.Show("Ya existe un Usuario con la misma Cédula en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Crea un nuevo objeto usuario para la modificación
                    OBJUsuario objUsuario = new OBJUsuario();
                    objUsuario.ID_Usuario = datosDelUsuario.ID_Usuario;

                    // Verifica si se ha modificado la contraseña
                    if (!string.IsNullOrWhiteSpace(TxtBx_Contrasena.Texts))
                    {
                        string ContrasenaIngresada  = TxtBx_Contrasena.Texts.Trim();
                        string ContrasenaEncriptada = DatosUsuario.EncriptarContrasena(ContrasenaIngresada);
                        objUsuario.Contrasena       = ContrasenaEncriptada;
                    }
                    else
                    {
                        // Si no se ha modificado, mantener la contraseña original
                        objUsuario.Contrasena = datosDelUsuario.Contrasena;
                    }

                    // Asigna los otros campos de texto sin modificar si no están vacíos
                    objUsuario.Nombre_Usuario   = string.IsNullOrWhiteSpace(TxtBx_NombreUsuario.Texts)  ? datosDelUsuario.Nombre_Usuario    : TxtBx_NombreUsuario.Texts.Trim();
                    objUsuario.Correo           = string.IsNullOrWhiteSpace(TxtBx_Correo.Texts)         ? datosDelUsuario.Correo            : TxtBx_Correo.Texts.Trim();
                    objUsuario.Cedula           = string.IsNullOrWhiteSpace(TxtBx_Cedula.Texts)         ? datosDelUsuario.Cedula            : TxtBx_Cedula.Texts.Trim();
                    objUsuario.Nombre           = string.IsNullOrWhiteSpace(TxtBx_Nombre.Texts)         ? datosDelUsuario.Nombre            : TxtBx_Nombre.Texts.Trim();
                    objUsuario.Apellido1        = string.IsNullOrWhiteSpace(TxtBx_Apellido1.Texts)      ? datosDelUsuario.Apellido1         : TxtBx_Apellido1.Texts.Trim();
                    objUsuario.Apellido2        = string.IsNullOrWhiteSpace(TxtBx_Apellido2.Texts)      ? datosDelUsuario.Apellido2         : TxtBx_Apellido2.Texts.Trim();
                    objUsuario.Fecha_Creacion   = datosDelUsuario.Fecha_Creacion;

                    // Verifica si se ha seleccionado un nuevo rol en el ComboBox
                    if (CmbBx_Roles.SelectedItem != null)
                    {
                        objUsuario.Rol = CmbBx_Roles.SelectedItem.ToString();
                    }
                    else
                    {
                        // Si no se ha seleccionado un nuevo rol, se mantiene el rol original
                        objUsuario.Rol = datosDelUsuario.Rol;
                    }

                    objUsuario.Estado = datosDelUsuario.Estado;

                    // Actualiza el usuario en la base de datos
                    if (DatosUsuario.Actualizar(objUsuario))
                    {
                        MessageBox.Show("Datos del Usuario modificados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        // Consulta a un Usuario en la base de datos
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Consultar Usuario";

            if (TxtBx_Cedula.Texts.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar la Cédula.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OBJUsuario objUsuario = DatosUsuario.Consultar(TxtBx_Cedula.Texts.Trim());
                if (objUsuario == null)
                {
                    MessageBox.Show("La Cédula no existe en el sistema.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ID_UsuarioTemp              = objUsuario.ID_Usuario;
                    TxtBx_NombreUsuario.Texts   = objUsuario.Nombre_Usuario;
                    NombreUsuarioTemp           = objUsuario.Nombre_Usuario;
                    TxtBx_Contrasena.Texts      = objUsuario.Contrasena;
                    TxtBx_Correo.Texts          = objUsuario.Correo;
                    TxtBx_Cedula.Texts          = objUsuario.Cedula;
                    CedulaUsuarioTemp           = objUsuario.Cedula;
                    TxtBx_Nombre.Texts          = objUsuario.Nombre;
                    TxtBx_Apellido1.Texts       = objUsuario.Apellido1;
                    TxtBx_Apellido2.Texts       = objUsuario.Apellido2;
                    Fecha_CreacionTemp          = objUsuario.Fecha_Creacion;
                    CmbBx_Roles.SelectedItem    = objUsuario.Rol;
                    EstadoTemp                  = objUsuario.Estado;

                    ConsultadoEmpleado = true;
                    Movimientos(Tipo_Mov);
                }
            }
        }




        //  Elimina un usuario poniendo el Estado en Inactivo
        private void Btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Eliminar Usuario";

            if (ConsultadoEmpleado == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el usuario está Inactivo
                    if (EstadoTemp == "Inactivo")
                    {
                        MessageBox.Show("El usuario ya se encuentra Inactivo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJUsuario objUsuario   = new OBJUsuario();
                        objUsuario.ID_Usuario   = ID_UsuarioTemp;
                        objUsuario.Estado       = "Inactivo";

                        if (DatosUsuario.CambiarEstado(objUsuario))
                        {
                            MessageBox.Show("Usuario Eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // Reactiva un usuario poniendo el Estado en Activo
        private void Btn_ReactivarUsuario_Click(object sender, EventArgs e)
        {
            string Tipo_Mov = "Reactivar Usuario";

            if (ConsultadoEmpleado == false)
            {
                MessageBox.Show("Primero debe de consultar algún registro.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Se verifica si el usuario está Activo
                    if (EstadoTemp == "Activo")
                    {
                        MessageBox.Show("El usuario ya se encuentra Activo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("¿Está seguro que desea reactivar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OBJUsuario objUsuario   = new OBJUsuario();
                        objUsuario.ID_Usuario   = ID_UsuarioTemp;
                        objUsuario.Estado       = "Activo";

                        if (DatosUsuario.CambiarEstado(objUsuario))
                        {
                            MessageBox.Show("Usuario Reactivado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Movimientos(Tipo_Mov);
                            LimpiarInformacion();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible reactivar al Usuario.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            OBJMovimiento objMovimiento = new OBJMovimiento();
            objMovimiento.ID_Movimiento = IDDis_Movimiento;
            objMovimiento.ID_Usuario = IDUSER;
            objMovimiento.Seccion = Seccion;
            objMovimiento.Tipo_Movimiento = tipo_mov;
            objMovimiento.Fecha_Movimiento = Fecha;
            objMovimiento.Hora_Movimiento = Hora;
            objMovimiento.Estado = "Activo";

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
            ConsultadoEmpleado          = false;
            ID_UsuarioTemp              = 0;
            CedulaUsuarioTemp           = "";
            NombreUsuarioTemp           = "";
            TxtBx_NombreUsuario.Texts   = "";
            TxtBx_Contrasena.Texts      = "";
            TxtBx_Correo.Texts          = "";
            TxtBx_Cedula.Texts          = "";
            TxtBx_Nombre.Texts          = "";
            TxtBx_Apellido1.Texts       = "";
            TxtBx_Apellido2.Texts       = "";
            Fecha_CreacionTemp          = DateTime.MinValue;
            CmbBx_Roles.SelectedItem    = "Administrador";
            RolTemp                     = "";
            EstadoTemp                  = "";
        }
    }
}
