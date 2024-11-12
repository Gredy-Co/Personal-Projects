using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJInmersion
    {
        private int idInmersion;
        private int detalleBolID;
        private int nBin;
        private DateTime fechaInmersion;
        private TimeSpan horaInmersion;
        private decimal temperaturaAgua;
        private int duracionInmersion;
        private string estado;

        public OBJInmersion(int idInmersion, int detalleBolID, int nBin, DateTime fechaInmersion, TimeSpan horaInmersion, decimal temperaturaAgua, int duracionInmersion, string estado)
        {
            this.idInmersion = idInmersion;
            this.detalleBolID = detalleBolID;
            this.nBin = nBin;
            this.fechaInmersion = fechaInmersion;
            this.horaInmersion = horaInmersion;
            this.temperaturaAgua = temperaturaAgua;
            this.duracionInmersion = duracionInmersion;
            this.estado = estado;
        }

        public OBJInmersion()
        {
            this.idInmersion = 0;
            this.detalleBolID = 0;
            this.nBin = 0;
            this.fechaInmersion = DateTime.MinValue;
            this.horaInmersion = TimeSpan.Zero;
            this.temperaturaAgua = 0;
            this.duracionInmersion = 0;
            this.estado = "";
        }

        public int ID_Inmersion { get => idInmersion; set => idInmersion = value; }
        public int DetalleBol_ID { get => detalleBolID; set => detalleBolID = value; }
        public int N_Bin { get => nBin; set => nBin = value; }
        public DateTime Fecha_Inmersion { get => fechaInmersion; set => fechaInmersion = value; }
        public TimeSpan Hora_Inmersion { get => horaInmersion; set => horaInmersion = value; }
        public decimal Temperatura_Agua { get => temperaturaAgua; set => temperaturaAgua = value; }
        public int Duracion_Inmersion { get => duracionInmersion; set => duracionInmersion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
