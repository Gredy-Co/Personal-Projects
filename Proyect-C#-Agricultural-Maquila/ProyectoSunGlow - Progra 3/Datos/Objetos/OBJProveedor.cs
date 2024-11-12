using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class OBJProveedor
    {
        private int iD_Proveedor;
        private string nombre_Proveedor;
        private string direccion;
        private string ciudad;
        private string pais;
        private string telefono;
        private string correo;
        private string categoria_Producto_Servicio;
        private string estado;
    

        public OBJProveedor(int iD_Proveedor, string nombre_Proveedor, string direccion, string ciudad, string pais, string telefono, string correo, string categoria_Producto_Servicio, string estado)
        {
            this.ID_Proveedor               = iD_Proveedor;
            this.Nombre_Proveedor           = nombre_Proveedor;
            this.Direccion                  = direccion;
            this.Ciudad                     = ciudad;
            this.Pais                       = pais;
            this.Telefono                   = telefono;
            this.Correo                     = correo;
            this.Categoria_Producto_Servicio  = categoria_Producto_Servicio;
            this.Estado                     = estado;
        }


        public OBJProveedor()
        {
            this.ID_Proveedor                 = 0;
            this.Nombre_Proveedor             = "";
            this.Direccion                    = "";
            this.Ciudad                       = "";
            this.Pais                         = "";
            this.Telefono                     = "";
            this.Correo                       = "";
            this.Categoria_Producto_Servicio  = "";
            this.Estado                       = "";
        }


        public int ID_Proveedor                 { get => iD_Proveedor; set => iD_Proveedor = value; }
        public string Nombre_Proveedor          { get => nombre_Proveedor; set => nombre_Proveedor = value; }
        public string Direccion                 { get => direccion; set => direccion = value; }
        public string Ciudad                    { get => ciudad; set => ciudad = value; }
        public string Pais                      { get => pais; set => pais = value; }
        public string Telefono                  { get => telefono; set => telefono = value; }
        public string Correo                    { get => correo; set => correo = value; }
        public string Categoria_Producto_Servicio { get => categoria_Producto_Servicio; set => categoria_Producto_Servicio = value; }
        public string Estado                    { get => estado; set => estado = value; }
    }
}
