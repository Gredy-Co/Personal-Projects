using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosTipoDeFruto
    { 

        public static OBJTipoDeFruto Consultar(String TipoDeFruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Tipos_De_Frutos "
                    + "WHERE Tipo_De_Fruto = '" + TipoDeFruto + "' ";

                SqlCommand comando              = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr                = comando.ExecuteReader();
                OBJTipoDeFruto objTipoDeFruto   = new OBJTipoDeFruto();

                if (dr.Read())
                {
                    objTipoDeFruto.ID_Tipo_De_Fruto             = Convert.ToInt32(dr["ID_Tipo_De_Fruto"]);
                    objTipoDeFruto.Tipo_De_Fruto                = dr["Tipo_De_Fruto"].ToString();
                    objTipoDeFruto.Descripcion_Tipo_De_Fruto    = dr["Descripcion_Tipo_De_Fruto"].ToString();
                    objTipoDeFruto.Estado                       = dr["Estado"].ToString();

                    return objTipoDeFruto;
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



        public static OBJTipoDeFruto ConsultarPorIDTipoFruto(int TipoDeFruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Tipos_De_Frutos "
                    + "WHERE ID_Tipo_De_Fruto = '" + TipoDeFruto + "' ";

                SqlCommand comando              = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr                = comando.ExecuteReader();
                OBJTipoDeFruto objTipoDeFruto   = new OBJTipoDeFruto();

                if (dr.Read())
                {
                    objTipoDeFruto.ID_Tipo_De_Fruto = Convert.ToInt32(dr["ID_Tipo_De_Fruto"]);

                    return objTipoDeFruto;
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



        public static bool Guardar(OBJTipoDeFruto E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Tipos_De_Frutos VALUES (" + E.ID_Tipo_De_Fruto + ", '" + E.Tipo_De_Fruto + "' , '" + E.Descripcion_Tipo_De_Fruto + "', '"
                            + E.Estado + "' ) ";

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



        public static bool Actualizar(OBJTipoDeFruto T)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Tipos_De_Frutos SET Tipo_De_Fruto = '" + T.Tipo_De_Fruto + "', Descripcion_Tipo_De_Fruto = '" 
                    + T.Descripcion_Tipo_De_Fruto + "', Estado = '" + T.Estado + "' "
                    + "WHERE ID_Tipo_De_Fruto = " + T.ID_Tipo_De_Fruto;


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



        public static bool CambiarEstado(OBJTipoDeFruto T)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Tipos_De_Frutos SET Estado = '" + T.Estado + "' WHERE ID_Tipo_De_Fruto = " + T.ID_Tipo_De_Fruto;

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
                sql = "SELECT ID_Tipo_De_Fruto FROM Tipos_De_Frutos ORDER BY ID_Tipo_De_Fruto";

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
                    sql = "SELECT MAX(ID_Tipo_De_Fruto) as max_id FROM Tipos_De_Frutos"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
