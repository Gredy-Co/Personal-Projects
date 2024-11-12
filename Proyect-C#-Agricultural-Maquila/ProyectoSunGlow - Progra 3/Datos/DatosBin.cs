using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosBin
    {

        public static OBJBin Consultar(int Bin)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bines "
                    + "WHERE Numero_Bin = '" + Bin + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJBin objBin = new OBJBin();

                if (dr.Read())
                {
                    objBin.ID_Bin = Convert.ToInt32(dr["ID_Bin"]);
                    objBin.Numero_Bin = Convert.ToInt32(dr["Numero_Bin"]);
                    objBin.Detalle = dr["Detalle"].ToString();
                    objBin.Estado = dr["Estado"].ToString();

                    return objBin;
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

        public static OBJBin ConsultarIDBIN(int Bin)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bines "
                    + "WHERE ID_Bin = '" + Bin + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJBin objBin = new OBJBin();

                if (dr.Read())
                {
                    objBin.ID_Bin = Convert.ToInt32(dr["ID_Bin"]);
                    objBin.Numero_Bin = Convert.ToInt32(dr["Numero_Bin"]);
                    objBin.Detalle = dr["Detalle"].ToString();
                    objBin.Estado = dr["Estado"].ToString();

                    return objBin;
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


        public static bool Guardar(OBJBin E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Bines VALUES (" + E.ID_Bin + ", '" + E.Numero_Bin + "' , '" + E.Detalle + "', '"
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



        public static bool Actualizar(OBJBin E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Bines SET Numero_Bin = '" + E.Numero_Bin + "', Detalle = '" + E.Detalle + "', Estado = '" + E.Estado + "' "
                    + "WHERE ID_Bin = " + E.ID_Bin;


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



        public static bool CambiarEstado(OBJBin E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Bines SET Estado = '" + E.Estado + "' WHERE ID_Bin = " + E.ID_Bin;

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
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Bin FROM Bines ORDER BY ID_Bin";

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
                    sql = "SELECT MAX(ID_Bin) as max_id FROM Bines"; 
                    SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
