using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJDetalleCosecha
    {
        private int iDDetalle;
        private int boletaID;
        private int nBin;
        private int cantidadFruta;
        private decimal promedioFruta;
        private int fincaID;
        private int loteID;
        private int bloqueID;
        private int variedadFrutoID;
        private int tipoFrutoID;
        private string estado;


        public OBJDetalleCosecha(int iDDetalle, int boletaID, int nBin, int cantidadFruta, decimal promedioFruta, int fincaID, int loteID, int bloqueID, int variedadFrutoID, int tipoFrutoID, string estado)
        {
            this.ID_Detalle         = iDDetalle;
            this.Boleta_ID          = boletaID;
            this.N_Bin              = nBin;
            this.Cantidad_Fruta     = cantidadFruta;
            this.Promedio_Fruta     = promedioFruta;
            this.Finca_ID           = fincaID;
            this.Lote_ID            = loteID;
            this.Bloque_ID          = bloqueID;
            this.Variedad_Fruto_ID  = variedadFrutoID;
            this.Tipo_Fruto_ID      = tipoFrutoID;
            this.Estado             = estado;
        }


        public OBJDetalleCosecha()
        {
            this.ID_Detalle         = 0;
            this.Boleta_ID          = 0;
            this.N_Bin              = 0;
            this.Cantidad_Fruta     = 0;
            this.Promedio_Fruta     = 0;
            this.Finca_ID           = 0;
            this.Lote_ID            = 0;
            this.Bloque_ID          = 0;
            this.Variedad_Fruto_ID  = 0;
            this.Tipo_Fruto_ID      = 0;
            this.Estado             = "";
        }


        public int ID_Detalle           { get => iDDetalle; set => iDDetalle = value; }
        public int Boleta_ID            { get => boletaID; set => boletaID = value; }
        public int N_Bin                { get => nBin; set => nBin = value; }
        public int Cantidad_Fruta       { get => cantidadFruta; set => cantidadFruta = value; }
        public decimal Promedio_Fruta   { get => promedioFruta; set => promedioFruta = value; }
        public int Finca_ID             { get => fincaID; set => fincaID = value; }
        public int Lote_ID              { get => loteID; set => loteID = value; }
        public int Bloque_ID            { get => bloqueID; set => bloqueID = value; }
        public int Variedad_Fruto_ID    { get => variedadFrutoID; set => variedadFrutoID = value; }
        public int Tipo_Fruto_ID        { get => tipoFrutoID; set => tipoFrutoID = value; }
        public string Estado            { get => estado; set => estado = value; }
    }
}
