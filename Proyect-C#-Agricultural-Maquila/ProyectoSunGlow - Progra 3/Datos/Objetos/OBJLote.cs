using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJLote
    {
        private int iDLote;
        private string nombreLote;
        private decimal areaTotal;
        private int fincaID;
        private string estado;

        public OBJLote(int iDLote, string nombreLote, decimal areaTotal, int fincaID, string estado)
        {
            this.ID_Lote        = iDLote;
            this.Nombre_Lote    = nombreLote;
            this.Area_Total     = areaTotal;
            this.Finca_ID       = fincaID;
            this.Estado         = estado;
        }

        public OBJLote()
        {
            this.ID_Lote        = 0;
            this.Nombre_Lote    = "";
            this.Area_Total     = 0;
            this.Finca_ID       = 0;
            this.Estado         = "";
        }

        public int ID_Lote          { get => iDLote; set => iDLote = value; }
        public string Nombre_Lote   { get => nombreLote; set => nombreLote = value; }
        public decimal Area_Total   { get => areaTotal; set => areaTotal = value; }
        public int Finca_ID         { get => fincaID; set => fincaID = value; }
        public string Estado        { get => estado; set => estado = value; }
    }
}
