using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosLote
    {

        public static List<string> ConsultarFincas()
        {
            List<string> nombresFincas = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Finca FROM Fincas";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

                while (dr.Read())
                {
                    nombresFincas.Add(dr["Nombre_Finca"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return nombresFincas;
        }



        public static OBJFinca ConsultarPorNombreFinca(String Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Fincas "
                    + "WHERE Nombre_Finca = '" + Finca + "' ";

                SqlCommand comando          = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr            = comando.ExecuteReader();
                OBJFinca objFinca            = new OBJFinca();

                if (dr.Read())
                {
                    objFinca.ID_Finca        = Convert.ToInt32(dr["ID_Finca"]);
                    objFinca.Nombre_Finca    = dr["Nombre_Finca"].ToString();

                    return objFinca;
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



        public static OBJLote ConsultarPorIDLote(int Lote)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Lotes "
                    + "WHERE ID_Lote = '" + Lote + "' ";

                SqlCommand comando          = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr            = comando.ExecuteReader();
                OBJLote objLote             = new OBJLote();

                if (dr.Read())
                {
                    objLote.ID_Lote     = Convert.ToInt32(dr["ID_Lote"]);
                    objLote.Nombre_Lote = dr["Nombre_Lote"].ToString();

                    return objLote;
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

        public static OBJLote Consultar(String Lote)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Lotes "
                    + "WHERE Nombre_Lote = '" + Lote + "' ";

                SqlCommand comando          = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr            = comando.ExecuteReader();
                OBJLote objLote             = new OBJLote();

                if (dr.Read())
                {
                    objLote.ID_Lote         = Convert.ToInt32(dr["ID_Lote"]);
                    objLote.Nombre_Lote     = dr["Nombre_Lote"].ToString();
                    objLote.Area_Total      = Convert.ToDecimal(dr["Area_Total"]);
                    objLote.Finca_ID        = Convert.ToInt32(dr["Finca_ID"]);
                    objLote.Estado          = dr["Estado"].ToString();

                    return objLote;
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



        public static bool Guardar(OBJLote E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Lotes VALUES (" + E.ID_Lote + ", '" + E.Nombre_Lote + "' , '" + E.Area_Total + "', '"
                            + E.Finca_ID + "', '" + E.Estado + "' ) ";

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



        public static bool Actualizar(OBJLote E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Lotes SET Nombre_Lote = '" + E.Nombre_Lote + "', Area_Total = '" + E.Area_Total + "', Finca_ID = '" + E.Finca_ID + "', "
                    + "Estado = '" + E.Estado + "' "
                    + "WHERE ID_Lote = " + E.ID_Lote;


                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

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



        public static bool CambiarEstado(OBJLote E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Lotes SET Estado = '" + E.Estado + "' WHERE ID_Lote = " + E.ID_Lote;

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

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
            List<int> idsUtilizados     = new List<int>();
            List<int> idsDisponibles    = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Lote FROM Lotes ORDER BY ID_Lote";

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
                    sql = "SELECT MAX(ID_Lote) as max_id FROM Lotes"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
