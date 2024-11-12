using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosVariedadDeFruto
    {
        public static bool Guardar(OBJVariedadDeFruto E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Variedades_De_Frutos VALUES (" + E.ID_Variedad_Fruto + ", '" + E.Nombre_Variedad + "' , '" + E.Descripcion_Variedad + "', '"
                            + E.Temporada_Cosecha + "', '" + E.Estado + "' ) ";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                int cantidad        = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return false;
            }

        }




        public static OBJVariedadDeFruto Consultar(String VariedadDeFruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Variedades_De_Frutos "
                    + "WHERE Nombre_Variedad = '" + VariedadDeFruto + "' ";

                SqlCommand comando                      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr                        = comando.ExecuteReader();
                OBJVariedadDeFruto objVariedadDeFruto   = new OBJVariedadDeFruto();

                if (dr.Read())
                {
                    objVariedadDeFruto.ID_Variedad_Fruto        = Convert.ToInt32(dr["ID_Variedad_Fruto"]);
                    objVariedadDeFruto.Nombre_Variedad          = dr["Nombre_Variedad"].ToString();
                    objVariedadDeFruto.Descripcion_Variedad     = dr["Descripcion_Variedad"].ToString();
                    objVariedadDeFruto.Temporada_Cosecha        = dr["Temporada_Cosecha"].ToString();
                    objVariedadDeFruto.Estado                   = dr["Estado"].ToString();

                    return objVariedadDeFruto;
                }
                else
                {
                    return null;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public static OBJVariedadDeFruto ConsultarPorNombreFruto(string VariedadDeFruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Variedades_De_Frutos "
                    + "WHERE Nombre_Variedad = '" + VariedadDeFruto + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJVariedadDeFruto objVariedadDeFruto = new OBJVariedadDeFruto();

                if (dr.Read())
                {
                    objVariedadDeFruto.ID_Variedad_Fruto = Convert.ToInt32(dr["ID_Variedad_Fruto"]);

                    return objVariedadDeFruto;
                }
                else
                {
                    return null;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }
        }




        public static OBJVariedadDeFruto ConsultarPorIDFruto(int VariedadDeFruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Variedades_De_Frutos "
                    + "WHERE ID_Variedad_Fruto = '" + VariedadDeFruto + "' ";

                SqlCommand comando                      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr                        = comando.ExecuteReader();
                OBJVariedadDeFruto objVariedadDeFruto = new OBJVariedadDeFruto();

                if (dr.Read())
                {
                    objVariedadDeFruto.ID_Variedad_Fruto    = Convert.ToInt32(dr["ID_Variedad_Fruto"]);
                    objVariedadDeFruto.Nombre_Variedad      = dr["Nombre_Variedad"].ToString();

                    return objVariedadDeFruto;
                }
                else
                {
                    return null;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }
        }




        public static bool Actualizar(OBJVariedadDeFruto T)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Variedades_De_Frutos SET Nombre_Variedad = '" + T.Nombre_Variedad + "', Descripcion_Variedad = '"
                    + T.Descripcion_Variedad + "', Temporada_Cosecha = '" + T.Temporada_Cosecha + "', Estado = '" + T.Estado + "' "
                    + "WHERE ID_Variedad_Fruto = " + T.ID_Variedad_Fruto;


                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                int cantidad        = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        public static bool CambiarEstado(OBJVariedadDeFruto T)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Variedades_De_Frutos SET Estado = '" + T.Estado + "' WHERE ID_Variedad_Fruto = " + T.ID_Variedad_Fruto;

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                int cantidad        = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        public static List<int> ObtenerIDsDisponibles()
        {
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Variedad_Fruto FROM Variedades_De_Frutos ORDER BY ID_Variedad_Fruto";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    int currentId = dr.GetInt32(0);
                    idsUtilizados.Add(currentId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            int maxId = idsUtilizados.Count > 0 ? idsUtilizados.Max() : 0;
            for (int i = 1; i <= maxId; i++)
            {
                if (!idsUtilizados.Contains(i))
                {
                    idsDisponibles.Add(i);
                }
            }
            return idsDisponibles;
        }

        public static int ObtenerProximoIDDisponible()
        {
            List<int> idsDisponibles = ObtenerIDsDisponibles();
            int proximoID = 1;

            if (idsDisponibles.Count > 0)
            {
                proximoID = idsDisponibles[0];
            }
            else
            {
                try
                {
                    Conexion Conex = new Conexion();
                    string sql;
                    sql = "SELECT MAX(ID_Variedad_Fruto) as max_id FROM Variedades_De_Frutos"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                    SqlDataReader dr = comando.ExecuteReader();

                    if (dr.Read())
                    {
                        proximoID = dr.IsDBNull(0) ? 1 : dr.GetInt32(0) + 1;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return proximoID;
        }
    }
}
