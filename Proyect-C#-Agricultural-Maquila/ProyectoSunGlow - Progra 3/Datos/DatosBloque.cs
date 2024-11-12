using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosBloque
    {

        public static List<string> ConsultarLotes()
        {
            List<string> nombresLotes = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Lote FROM Lotes";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

                while (dr.Read())
                {
                    nombresLotes.Add(dr["Nombre_Lote"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return nombresLotes;
        }



        public static List<string> ConsultarFrutos()
        {
            List<string> nombresFrutos = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Variedad FROM Variedades_De_Frutos";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    nombresFrutos.Add(dr["Nombre_Variedad"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return nombresFrutos;
        }



        public static OBJBloque ConsultarBloqID(string nombreBloque, int idLote)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bloques "
                    + "WHERE Nombre_Bloque = '" + nombreBloque + "' "
                    + "AND Lote_ID = " + idLote;

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJBloque objBloque = null;

                if (dr.Read())
                {
                    objBloque = new OBJBloque();
                    objBloque.ID_Bloque = Convert.ToInt32(dr["ID_Bloque"]);
                    objBloque.Nombre_Bloque = dr["Nombre_Bloque"].ToString();
                    objBloque.Lote_ID = Convert.ToInt32(dr["Lote_ID"]);
                }

                Conex.Desconectar();
                return objBloque;
            }
            catch (Exception ex)
            {
                return null;
            }
        }





        public static OBJBloque ConsultarPorIDBloque(int Bloque)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bloques "
                    + "WHERE ID_Bloque = '" + Bloque + "' ";

                SqlCommand comando      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr        = comando.ExecuteReader();
                OBJBloque objBloque     = new OBJBloque();

                if (dr.Read())
                {
                    objBloque.ID_Bloque = Convert.ToInt32(dr["ID_Bloque"]);

                    return objBloque;
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



        public static bool Guardar(OBJBloque E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Bloques VALUES (" + E.ID_Bloque + ", '" + E.Nombre_Bloque + "' , '" + E.Lote_ID + "', '"
                            + E.Variedad_Fruto_ID + "', '" + E.Estado + "' ) ";

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



        public static OBJBloque Consultar(String Bloque)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bloques "
                    + "WHERE Nombre_Bloque = '" + Bloque + "' ";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();
                OBJBloque objBloque   = new OBJBloque();

                if (dr.Read())
                {
                    objBloque.ID_Bloque         = Convert.ToInt32(dr["ID_Bloque"]);
                    objBloque.Nombre_Bloque     = dr["Nombre_Bloque"].ToString();
                    objBloque.Lote_ID           = Convert.ToInt32(dr["Lote_ID"]);
                    objBloque.Variedad_Fruto_ID = Convert.ToInt32(dr["Variedad_Fruto_ID"]);
                    objBloque.Estado            = dr["Estado"].ToString();

                    return objBloque;
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



        public static bool Actualizar(OBJBloque E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Bloques SET Nombre_Bloque = '" + E.Nombre_Bloque + "', Lote_ID = '" + E.Lote_ID + "', Variedad_Fruto_ID = '" + E.Variedad_Fruto_ID + "', "
                    + "Estado = '" + E.Estado + "' "
                    + "WHERE ID_Bloque = " + E.ID_Bloque;


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



        public static bool CambiarEstado(OBJBloque E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Bloques SET Estado = '" + E.Estado + "' WHERE ID_Bloque = " + E.ID_Bloque;

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
                sql = "SELECT ID_Bloque FROM Bloques ORDER BY ID_Bloque";

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
                    sql = "SELECT MAX(ID_Bloque) as max_id FROM Bloques"; 
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
