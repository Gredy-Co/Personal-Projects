using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJRecepcionEnvio
    {
        private int iDRecepcion;
        private string nombreConductor;
        private string placaCamion;
        private string cedula;
        private int nBines;
        private TimeSpan horaEnvio;
        private TimeSpan horaLlegada;
        private DateTime fecha;
        private decimal pesoNeto;
        private string estado;


        public OBJRecepcionEnvio(int iDRecepcion, string nombreConductor, string placaCamion, string cedula, int nBines, TimeSpan horaEnvio, TimeSpan horaLlegada, DateTime fecha, decimal pesoNeto, string estado)
        {
            this.ID_Recepcion       = iDRecepcion;
            this.Nombre_Conductor   = nombreConductor;
            this.Placa_Camion       = placaCamion;
            this.Cedula             = cedula;
            this.N_Bines            = nBines;
            this.Hora_Envio         = horaEnvio;
            this.Hora_Llegada       = horaLlegada;
            this.Fecha              = fecha;
            this.Peso_Neto          = pesoNeto;
            this.Estado             = estado;
        }


        public OBJRecepcionEnvio()
        {
            this.ID_Recepcion       = 0;
            this.Nombre_Conductor   = "";
            this.Placa_Camion       = "";
            this.Cedula             = "";
            this.N_Bines            = 0;
            this.Hora_Envio         = TimeSpan.Zero;
            this.Hora_Llegada       = TimeSpan.Zero;
            this.Fecha              = DateTime.MinValue;
            this.Peso_Neto          = 0;
            this.Estado             = "";
        }


        public int ID_Recepcion         { get => iDRecepcion; set => iDRecepcion = value; }
        public string Nombre_Conductor  { get => nombreConductor; set => nombreConductor = value; }
        public string Placa_Camion      { get => placaCamion; set => placaCamion = value; }
        public string Cedula            { get => cedula; set => cedula = value; }
        public int N_Bines              { get => nBines; set => nBines = value; }
        public TimeSpan Hora_Envio      { get => horaEnvio; set => horaEnvio = value; }
        public TimeSpan Hora_Llegada    { get => horaLlegada; set => horaLlegada = value; }
        public DateTime Fecha           { get => fecha; set => fecha = value; }
        public decimal Peso_Neto        { get => pesoNeto; set => pesoNeto = value; }
        public string Estado            { get => estado; set => estado = value; }
    }
}
