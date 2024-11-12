using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosEmpaque
    {

        public static int CantidadTotalFrutasBoletasEnInmersion()
        {
            int cantidadTotalFrutas = 0;

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT I.ID_Inmersion, D.Boleta_ID, D.Cantidad_Fruta " +
                             "FROM Inmersion I " +
                             "JOIN Detalle_Cosecha D ON I.DetalleBol_ID = D.ID_Detalle " +
                             "WHERE I.Estado = 'Activo'";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cantidadTotalFrutas += Convert.ToInt32(dr["Cantidad_Fruta"]);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
                return -1;
            }

            return cantidadTotalFrutas;
        }


        public static bool Guardar(OBJEmpaque E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Empaque VALUES (" + E.ID_Empaque + ", '" + E.Tamano_Fruta + "' , '" + E.Cantidad_Fruta + "', '"
                            + E.Cantidad_Cajas + "', '" + E.Fecha_Empaque.ToString("yyyy-MM-dd") + "', '" + E.Hora_Empaque.ToString(@"hh\:mm\:ss") + "', '" + E.Estado + "' ) ";

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


        public static bool ActualizarEstadoInmersion()
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql = "UPDATE Inmersion SET Estado = 'Inactivo' WHERE Estado = 'Activo'";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());

                int filasAfectadas = comando.ExecuteNonQuery();

                Conex.Desconectar();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
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
                sql = "SELECT ID_Empaque FROM Empaque ORDER BY ID_Empaque";

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
                    sql = "SELECT MAX(ID_Empaque) as max_id FROM Empaque";
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
