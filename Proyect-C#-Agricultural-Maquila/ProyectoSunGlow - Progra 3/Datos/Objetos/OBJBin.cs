using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJBin
    {
        private int iDBin;
        private int numeroBin;
        private string detalle;
        private string estado;

        public OBJBin(int iDBin, int numeroBin, string detalle, string estado)
        {
            this.ID_Bin     = iDBin;
            this.Numero_Bin = numeroBin;
            this.Detalle    = detalle;
            this.Estado     = estado;
        }

        public OBJBin()
        {
            this.ID_Bin     = 0;
            this.Numero_Bin = 0;
            this.Detalle    = "";
            this.Estado     = "";
        }

        public int ID_Bin       { get => iDBin; set => iDBin = value; }
        public int Numero_Bin   { get => numeroBin; set => numeroBin = value; }
        public string Detalle   { get => detalle; set => detalle = value; }
        public string Estado    { get => estado; set => estado = value; }
    }
}
