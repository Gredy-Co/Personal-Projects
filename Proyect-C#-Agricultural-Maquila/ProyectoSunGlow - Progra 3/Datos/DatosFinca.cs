using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosFinca
    {

        public static OBJFinca ConsultarPorNombreFinca(String Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Fincas "
                    + "WHERE Nombre_Finca = '" + Finca + "' ";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();
                OBJFinca objFinca   = new OBJFinca();

                if (dr.Read())
                {
                    objFinca.Nombre_Finca = dr["Nombre_Finca"].ToString();

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



        public static List<string> ConsultarNombresFincas()
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



        public static List<string> ConsultarProveedores()
        {
            List<string> proveedoresFincas = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Proveedor FROM Proveedores";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    proveedoresFincas.Add(dr["Nombre_Proveedor"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return proveedoresFincas;
        }



        public static OBJProveedor ConsultarPorNombreProveedor(string Proveedor)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Proveedores "
                    + "WHERE Nombre_Proveedor = '" + Proveedor + "' ";

                SqlCommand comando          = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr            = comando.ExecuteReader();
                OBJProveedor objProveedor   = new OBJProveedor();

                if (dr.Read())
                {
                    objProveedor.ID_Proveedor = Convert.ToInt32(dr["ID_Proveedor"]);
                    objProveedor.Nombre_Proveedor = dr["Nombre_Proveedor"].ToString();


                    return objProveedor;
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



        public static OBJFinca ConsultarPorIDFinca(int Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Fincas "
                    + "WHERE ID_Finca = '" + Finca + "' ";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();
                OBJFinca objFinca   = new OBJFinca();

                if (dr.Read())
                {
                    objFinca.ID_Finca = Convert.ToInt32(dr["ID_Finca"]);
                    objFinca.Nombre_Finca = dr["Nombre_Finca"].ToString();

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



        public static bool Guardar(OBJFinca E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Fincas VALUES (" + E.ID_Finca + ", '" + E.Nombre_Finca + "' , '" + E.Ubicacion + "', '"
                            + E.Area_Total + "', '" + E.Tipo_Suelo + "', '" + E.Proveedor_ID + "', '" + E.Estado + "' ) ";

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



        public static OBJFinca Consultar(String Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Fincas "
                    + "WHERE Nombre_Finca = '" + Finca + "' ";

                SqlCommand comando          = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr            = comando.ExecuteReader();
                OBJFinca objFinca           = new OBJFinca();

                if (dr.Read())
                {
                    objFinca.ID_Finca       = Convert.ToInt32(dr["ID_Finca"]);
                    objFinca.Nombre_Finca   = dr["Nombre_Finca"].ToString();
                    objFinca.Ubicacion      = dr["Ubicacion"].ToString();
                    objFinca.Area_Total     = Convert.ToDecimal(dr["Area_Total"]);
                    objFinca.Tipo_Suelo     = dr["Tipo_Suelo"].ToString();
                    objFinca.Proveedor_ID   = Convert.ToInt32(dr["Proveedor_ID"]);
                    objFinca.Estado         = dr["Estado"].ToString();

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



        public static bool Actualizar(OBJFinca E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Fincas SET Nombre_Finca = '" + E.Nombre_Finca + "', Ubicacion = '" + E.Ubicacion + "', Area_Total = '" + E.Area_Total + "', Tipo_Suelo = '"
                    + E.Tipo_Suelo + "', Proveedor_ID = '" + E.Proveedor_ID + "', Estado = '" + E.Estado + "' "
                    + "WHERE ID_Finca = " + E.ID_Finca;


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



        public static bool CambiarEstado(OBJFinca E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Fincas SET Estado = '" + E.Estado + "' WHERE ID_Finca = " + E.ID_Finca;

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
            List<int> idsUtilizados     = new List<int>();
            List<int> idsDisponibles    = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Finca FROM Fincas ORDER BY ID_Finca";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

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
                    sql = "SELECT MAX(ID_Finca) as max_id FROM Fincas"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
