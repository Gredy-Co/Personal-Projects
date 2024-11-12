using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class OBJFinca
    {
        private int iDFinca;
        private string nombreFinca;
        private string ubicacion;
        private decimal areaTotal;
        private string tipoSuelo;
        private int proveedorID;
        private string estado;


        public OBJFinca(int iDFinca, string nombreFinca, string ubicacion, decimal areaTotal, string tipoSuelo, int proveedorID, string estado)
        {
            this.ID_Finca       = iDFinca;
            this.Nombre_Finca   = nombreFinca;
            this.Ubicacion      = ubicacion;
            this.Area_Total     = areaTotal;
            this.Tipo_Suelo     = tipoSuelo;
            this.Proveedor_ID   = proveedorID;
            this.Estado         = estado;
        }


        public OBJFinca()
        {
            this.ID_Finca       = 0;
            this.Nombre_Finca   = "";
            this.Ubicacion      = "";
            this.Area_Total     = 0;
            this.Tipo_Suelo     = "";
            this.Proveedor_ID   = 0;
            this.Estado         = "";
        }


        public int ID_Finca         { get => iDFinca; set => iDFinca = value; }
        public string Nombre_Finca  { get => nombreFinca; set => nombreFinca = value; }
        public string Ubicacion     { get => ubicacion; set => ubicacion = value; }
        public decimal Area_Total   { get => areaTotal; set => areaTotal = value; }
        public string Tipo_Suelo    { get => tipoSuelo; set => tipoSuelo = value; }
        public int Proveedor_ID     { get => proveedorID; set => proveedorID = value; }
        public string Estado        { get => estado; set => estado = value; }
    }
}
