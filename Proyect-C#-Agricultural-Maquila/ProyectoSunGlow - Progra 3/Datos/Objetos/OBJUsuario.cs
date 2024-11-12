using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Logica
{
    internal class OBJUsuario
    {
        private int         iD_Usuario;
        private string      nombre_Usuario;
        private string      contrasena;
        private string      correo;
        private string      cedula;
        private string      nombre;
        private string      apellido1;
        private string      apellido2;
        private DateTime    fecha_Creacion;
        private string      rol;
        private string      estado;


        public OBJUsuario(int iD_Usuario, string nombre_Usuario, string contrasena, string correo, string cedula, string nombre, string apellido1, string apellido2, DateTime fecha_Creacion, string rol, string estado)
        {
            this.ID_Usuario     = iD_Usuario;
            this.Nombre_Usuario = nombre_Usuario;
            this.Contrasena     = contrasena;
            this.Correo         = correo;
            this.Cedula         = cedula;
            this.Nombre         = nombre;
            this.Apellido1      = apellido1;
            this.Apellido2      = apellido2;
            this.Fecha_Creacion = fecha_Creacion;
            this.Rol            = rol;
            this.Estado         = estado;
        }


        public OBJUsuario()
        {
            this.ID_Usuario         = 0;
            this.Nombre_Usuario     = "";
            this.Contrasena         = "";
            this.Cedula             = "";
            this.Nombre             = "";
            this.Apellido1          = "";
            this.Apellido2          = "";
            this.Fecha_Creacion     = DateTime.MinValue;
            this.Rol                = "";
            this.Estado             = "";
        }

        public int ID_Usuario           { get => iD_Usuario; set => iD_Usuario = value; }
        public string Nombre_Usuario    { get => nombre_Usuario; set => nombre_Usuario = value; }
        public string Contrasena        { get => contrasena; set => contrasena = value; }
        public string Correo            { get => correo; set => correo = value; }
        public string Cedula            { get => cedula; set => cedula = value; }
        public string Nombre            { get => nombre; set => nombre = value; }
        public string Apellido1         { get => apellido1; set => apellido1 = value; }
        public string Apellido2         { get => apellido2; set => apellido2 = value; }
        public DateTime Fecha_Creacion  { get => fecha_Creacion; set => fecha_Creacion = value; }
        public string Rol               { get => rol; set => rol = value; }
        public string Estado            { get => estado; set => estado = value; }

    }
}
