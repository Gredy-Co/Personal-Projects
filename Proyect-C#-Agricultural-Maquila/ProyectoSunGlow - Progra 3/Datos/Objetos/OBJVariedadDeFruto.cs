using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJVariedadDeFruto
    {
        private int iDVariedadFruto;
        private string nombreVariedad;
        private string descripcionVariedad;
        private string temporadaCosecha;
        private string estado;


        public OBJVariedadDeFruto(int iDVariedadFruto, string nombreVariedad, string descripcionVariedad, string temporadaCosecha, string estado)
        {
            this.ID_Variedad_Fruto      = iDVariedadFruto;
            this.Nombre_Variedad        = nombreVariedad;
            this.Descripcion_Variedad   = descripcionVariedad;
            this.Temporada_Cosecha      = temporadaCosecha;
            this.Estado                 = estado;
        }


        public OBJVariedadDeFruto()
        {
            this.ID_Variedad_Fruto      = 0;
            this.Nombre_Variedad        = "";
            this.Descripcion_Variedad   = "";
            this.Temporada_Cosecha      = "";
            this.Estado                 = "";
        }


        public int ID_Variedad_Fruto        { get => iDVariedadFruto; set => iDVariedadFruto = value; }
        public string Nombre_Variedad       { get => nombreVariedad; set => nombreVariedad = value; }
        public string Descripcion_Variedad  { get => descripcionVariedad; set => descripcionVariedad = value; }
        public string Temporada_Cosecha     { get => temporadaCosecha; set => temporadaCosecha = value; }
        public string Estado                { get => estado; set => estado = value; }
    }
}
