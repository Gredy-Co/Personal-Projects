using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosMovimiento
    {

        public static bool GuardarMovimiento(OBJMovimiento M)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "INSERT INTO Movimientos VALUES (" + M.ID_Movimiento + ", " + M.ID_Usuario + ", '" + M.Seccion + "', '"
                    + M.Tipo_Movimiento + "', '" + M.Fecha_Movimiento.ToString("yyyy-MM-dd") + "', '"
                    + M.Hora_Movimiento.ToString(@"hh\:mm\:ss") + "', '" + M.Estado + "' ) ";


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



        public static List<OBJMovimiento> ConsultarTodo()
        {
            List<OBJMovimiento> listaMovimientos = new List<OBJMovimiento>();

            try
            {
                Conexion Conex  = new Conexion();
                string sql      = "SELECT * FROM Movimientos";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJMovimiento movimiento    = new OBJMovimiento();
                    movimiento.ID_Movimiento    = Convert.ToInt32(dr["ID_Movimiento"]);
                    movimiento.ID_Usuario       = Convert.ToInt32(dr["ID_Usuario"]);
                    movimiento.Seccion          = dr["Seccion"].ToString();
                    movimiento.Tipo_Movimiento  = dr["Tipo_Movimiento"].ToString();

                    // Obtener solo la fecha de "Fecha_Movimiento"
                    DateTime fechaMovimiento    = Convert.ToDateTime(dr["Fecha_Movimiento"]);
                    movimiento.Fecha_Movimiento = fechaMovimiento.Date; // Obtener solo la fecha sin la hora

                    movimiento.Hora_Movimiento  = TimeSpan.Parse(dr["Hora_Movimiento"].ToString());
                    movimiento.Estado           = dr["Estado"].ToString();

                    listaMovimientos.Add(movimiento);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaMovimientos;
        }




        public static List<OBJMovimiento> ConsultarMovimientosFecha(DateTime fechaSeleccionada)
        {
            List<OBJMovimiento> listaMovimientos = new List<OBJMovimiento>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT * FROM Recepcion_Envio "
                           + "WHERE Fecha = '" + fechaSeleccionada + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJMovimiento movimiento = new OBJMovimiento();
                    movimiento.ID_Movimiento = Convert.ToInt32(dr["ID_Movimiento"]);
                    movimiento.ID_Usuario = Convert.ToInt32(dr["ID_Usuario"]);
                    movimiento.Seccion = dr["Seccion"].ToString();
                    movimiento.Tipo_Movimiento = dr["Tipo_Movimiento"].ToString();

                    // Obtener solo la fecha de "Fecha_Movimiento"
                    DateTime fechaMovimiento = Convert.ToDateTime(dr["Fecha_Movimiento"]);
                    movimiento.Fecha_Movimiento = fechaMovimiento.Date; // Obtener solo la fecha sin la hora

                    movimiento.Hora_Movimiento = TimeSpan.Parse(dr["Hora_Movimiento"].ToString());
                    movimiento.Estado = dr["Estado"].ToString();


                    listaMovimientos.Add(movimiento);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaMovimientos;
        }


        public static List<int> ObtenerIDsDisponibles()
        {
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Movimiento FROM Movimientos ORDER BY ID_Movimiento";

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
                    sql = "SELECT MAX(ID_Movimiento) as max_id FROM Movimientos"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
