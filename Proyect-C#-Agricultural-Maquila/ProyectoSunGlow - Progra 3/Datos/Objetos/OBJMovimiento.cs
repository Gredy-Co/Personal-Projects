using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class OBJMovimiento
    {
        private int iD_Movimiento;
        private int iD_Usuario;
        private string seccion;
        private string tipo_Movimiento;
        private DateTime fecha_Movimiento;
        private TimeSpan hora_Movimiento;
        private string estado;


        public OBJMovimiento(int iD_Movimiento, int iD_Usuario, string seccion, string tipo_Movimiento, DateTime fecha_Movimiento, TimeSpan hora_Movimiento, string estado)
        {
            this.ID_Movimiento      = iD_Movimiento;
            this.ID_Usuario         = iD_Usuario;
            this.Seccion            = seccion;
            this.Tipo_Movimiento    = tipo_Movimiento;
            this.Fecha_Movimiento   = fecha_Movimiento;
            this.Hora_Movimiento    = hora_Movimiento;
            this.Estado             = estado;
        }


        public OBJMovimiento()
        {
            this.ID_Movimiento      = 0;
            this.ID_Usuario         = 0;
            this.Seccion            = "";
            this.Tipo_Movimiento    = "";
            this.Fecha_Movimiento   = DateTime.MinValue;
            this.Hora_Movimiento    = TimeSpan.Zero;
            this.Estado             = "";
        }

        public int ID_Movimiento            { get => iD_Movimiento; set => iD_Movimiento = value; }
        public int ID_Usuario               { get => iD_Usuario; set => iD_Usuario = value; }
        public string Seccion               { get => seccion; set => seccion = value; }
        public string Tipo_Movimiento       { get => tipo_Movimiento; set => tipo_Movimiento = value; }
        public DateTime Fecha_Movimiento    { get => fecha_Movimiento; set => fecha_Movimiento = value; }
        public TimeSpan Hora_Movimiento     { get => hora_Movimiento; set => hora_Movimiento = value; }
        public string Estado                { get => estado; set => estado = value; }
    }
}

