using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class Conexion
    {
        // Variable de Conexion
        SqlConnection Con;


        // Constructor 
        public Conexion()
        {
            Con = new SqlConnection("Data Source=Greddy;Initial Catalog=SunGlow;Integrated Security=True");
        }


        // Método para Abrir la conexión
        public SqlConnection Conectar()
        {
            try
            {
                Con.Open();
                return Con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        // Método para Cerrar la conexión
        public bool Desconectar()
        {
            try
            {
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
