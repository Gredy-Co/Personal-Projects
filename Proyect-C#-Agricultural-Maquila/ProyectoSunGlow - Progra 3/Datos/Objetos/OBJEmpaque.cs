using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class OBJEmpaque
    {
        private int idEmpaque;
        private int tamanoFruta;
        private int cantidadFruta;
        private int cantidadcajas;
        private DateTime fechaEmpaque;
        private TimeSpan horaEmpaque;
        private string estado;

        public OBJEmpaque(int idEmpaque, int inmersionID, int tamanoFruta, int cantidadFruta, int cantidadcajas, DateTime fechaEmpaque, TimeSpan horaEmpaque, string estado)
        {
            this.idEmpaque = idEmpaque;
            this.tamanoFruta = tamanoFruta;
            this.cantidadFruta = cantidadFruta;
            this.cantidadcajas = cantidadcajas;
            this.fechaEmpaque = fechaEmpaque;
            this.horaEmpaque = horaEmpaque;
            this.estado = estado;
        }

        public OBJEmpaque()
        {
            this.idEmpaque = 0;
            this.tamanoFruta = 0;
            this.cantidadFruta= 0;
            this.cantidadcajas= 0;
            this.fechaEmpaque = DateTime.MinValue;
            this.horaEmpaque = TimeSpan.Zero;
            this.estado = "";
        }

        public int ID_Empaque { get => idEmpaque; set => idEmpaque = value; }
        public int Tamano_Fruta { get => tamanoFruta; set => tamanoFruta = value; }
        public int Cantidad_Fruta { get => cantidadFruta; set => cantidadFruta = value; }
        public int Cantidad_Cajas { get => cantidadcajas; set => cantidadcajas = value; }
        public DateTime Fecha_Empaque { get => fechaEmpaque; set => fechaEmpaque = value; }
        public TimeSpan Hora_Empaque { get => horaEmpaque; set => horaEmpaque = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
