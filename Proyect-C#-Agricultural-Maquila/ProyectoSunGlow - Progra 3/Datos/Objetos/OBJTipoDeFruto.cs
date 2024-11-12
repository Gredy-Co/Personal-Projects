using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class OBJTipoDeFruto
    {
        private int iD_Tipo_De_Fruto;
        private string tipo_De_Fruto;
        private string descripcion_Tipo_De_Fruto;
        private string estado;


        public OBJTipoDeFruto(int iD_Tipo_De_Fruto, string tipo_De_Fruto, string descripcion_Tipo_De_Fruto, string estado)
        {
            this.ID_Tipo_De_Fruto           = iD_Tipo_De_Fruto;
            this.Tipo_De_Fruto              = tipo_De_Fruto;
            this.Descripcion_Tipo_De_Fruto  = descripcion_Tipo_De_Fruto;
            this.Estado                     = estado;
        }


        public OBJTipoDeFruto()
        {
        this.ID_Tipo_De_Fruto           = 0;
        this.Tipo_De_Fruto              = "";
        this.Descripcion_Tipo_De_Fruto  = "";
        this.Estado                     = "";
        }


        public int ID_Tipo_De_Fruto             { get => iD_Tipo_De_Fruto; set => iD_Tipo_De_Fruto = value; }
        public string Tipo_De_Fruto             { get => tipo_De_Fruto; set => tipo_De_Fruto = value; }
        public string Descripcion_Tipo_De_Fruto { get => descripcion_Tipo_De_Fruto; set => descripcion_Tipo_De_Fruto = value; }
        public string Estado                    { get => estado; set => estado = value; }
    }
}
