using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJBoletaCosecha
    {
        private int iDBoleta;
        private int consecutivoBoleta;
        private int envioID;
        private string cuadrilla;
        private DateTime fechaCosecha;
        private TimeSpan horaCosecha;
        private string estado;


        public OBJBoletaCosecha(int iDBoleta, int consecutivoBoleta, int envioID, string cuadrilla, DateTime fechaCosecha, TimeSpan horaCosecha, string estado)
        {
            this.ID_Boleta          = iDBoleta;
            this.Consecutivo_Boleta = consecutivoBoleta;
            this.Envio_ID           = envioID;
            this.Cuadrilla          = cuadrilla;
            this.Fecha_Cosecha      = fechaCosecha;
            this.Hora_Cosecha       = horaCosecha;
            this.Estado             = estado;
        }   


        public OBJBoletaCosecha()
        {
            this.ID_Boleta          = 0;
            this.Consecutivo_Boleta = 0;
            this.Envio_ID           = 0;
            this.Cuadrilla          = "";
            this.Fecha_Cosecha      = DateTime.MinValue;
            this.Hora_Cosecha       = TimeSpan.Zero;
            this.Estado             = "";
        }


        public int ID_Boleta            { get => iDBoleta; set => iDBoleta = value; }
        public int Consecutivo_Boleta   { get => consecutivoBoleta; set => consecutivoBoleta = value; }
        public int Envio_ID             { get => envioID; set => envioID = value; }
        public string Cuadrilla         { get => cuadrilla; set => cuadrilla = value; }
        public DateTime Fecha_Cosecha   { get => fechaCosecha; set => fechaCosecha = value; }
        public TimeSpan Hora_Cosecha    { get => horaCosecha; set => horaCosecha = value; }
        public string Estado            { get => estado; set => estado = value; }
    }
}
