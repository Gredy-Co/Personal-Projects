using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJBloque
    {
        private int iDBloque;
        private string nombreBloque;
        private int loteID;
        private int variedadFrutoID;
        private string estado;

        public OBJBloque(int iDBloque, string nombreBloque, int loteID, int variedadFrutoID, string estado)
        {
            this.ID_Bloque          = iDBloque;
            this.Nombre_Bloque      = nombreBloque;
            this.Lote_ID            = loteID;
            this.Variedad_Fruto_ID  = variedadFrutoID;
            this.Estado             = estado;
        }

        public OBJBloque()
        {
            this.ID_Bloque          = 0;
            this.Nombre_Bloque      = "";
            this.Lote_ID            = 0;
            this.Variedad_Fruto_ID  = 0;
            this.Estado             = "";
        }

        public int ID_Bloque            { get => iDBloque; set => iDBloque = value; }
        public string Nombre_Bloque     { get => nombreBloque; set => nombreBloque = value; }
        public int Lote_ID              { get => loteID; set => loteID = value; }
        public int Variedad_Fruto_ID    { get => variedadFrutoID; set => variedadFrutoID = value; }
        public string Estado            { get => estado; set => estado = value; }
    }
}
