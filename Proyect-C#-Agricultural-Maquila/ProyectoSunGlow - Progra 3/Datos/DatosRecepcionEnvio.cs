using ProyectoSunGlow___Progra_3.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos.Objetos
{
    internal class DatosRecepcionEnvio
    {

        public static List<OBJRecepcionEnvio> ConsultarEntradas(DateTime fechaSeleccionada)
        {
            List<OBJRecepcionEnvio> listaEntradas = new List<OBJRecepcionEnvio>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT * FROM Recepcion_Envio "
                           +"WHERE Fecha = '" + fechaSeleccionada + "' ";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJRecepcionEnvio objEnvio      = new OBJRecepcionEnvio();
                    objEnvio.ID_Recepcion           = Convert.ToInt32(dr["ID_Recepcion"]);
                    objEnvio.Nombre_Conductor       = dr["Nombre_Conductor"].ToString();
                    objEnvio.Placa_Camion           = dr["Placa_Camion"].ToString();
                    objEnvio.Cedula                 = dr["Cedula"].ToString();
                    objEnvio.N_Bines                = Convert.ToInt32(dr["N_Bines"]);
                    objEnvio.Hora_Envio             = TimeSpan.Parse(dr["Hora_Envio"].ToString());
                    objEnvio.Hora_Llegada           = TimeSpan.Parse(dr["Hora_Llegada"].ToString());

                    // Obtener solo la fecha de "Fecha_Movimiento"
                    DateTime fecha                  = Convert.ToDateTime(dr["Fecha"]);
                    objEnvio.Fecha                  = fecha.Date; // Obtener solo la fecha sin la hora

                    objEnvio.Peso_Neto              = Convert.ToDecimal(dr["Peso_Neto"]);
                    objEnvio.Estado                 = dr["Estado"].ToString();


                    listaEntradas.Add(objEnvio);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaEntradas;
        }

        public static OBJRecepcionEnvio Consultar(int Envio)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Recepcion_Envio "
                    + "WHERE ID_Recepcion = '" + Envio + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJRecepcionEnvio objEnv = new OBJRecepcionEnvio();

                if (dr.Read())
                {
                    objEnv.ID_Recepcion     = Convert.ToInt32(dr["ID_Recepcion"]);
                    objEnv.Nombre_Conductor = dr["Nombre_Conductor"].ToString();
                    objEnv.Placa_Camion     = dr["Placa_Camion"].ToString();
                    objEnv.Cedula           = dr["Cedula"].ToString();
                    objEnv.N_Bines          = Convert.ToInt32(dr["N_Bines"]);
                    objEnv.Hora_Envio       = TimeSpan.Parse(dr["Hora_Envio"].ToString());
                    objEnv.Hora_Llegada     = TimeSpan.Parse(dr["Hora_Llegada"].ToString());
                    objEnv.Fecha            = Convert.ToDateTime(dr["Fecha"]);
                    objEnv.Peso_Neto        = Convert.ToDecimal(dr["Peso_Neto"]);
                    objEnv.Estado           = dr["Estado"].ToString();


                    return objEnv;
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


        public static bool Guardar(OBJRecepcionEnvio E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "INSERT INTO Recepcion_Envio VALUES (" + E.ID_Recepcion + ", '" + E.Nombre_Conductor + "', '" + E.Placa_Camion + "', '" + E.Cedula + "', " + E.N_Bines + ", '" + E.Hora_Envio.ToString(@"hh\:mm\:ss") + "', '"
                + E.Hora_Llegada.ToString(@"hh\:mm\:ss") + "', '" + E.Fecha.ToString("yyyy-MM-dd") + "', " + E.Peso_Neto + ", '" + E.Estado + "' ) ";

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



        public static bool Actualizar(OBJRecepcionEnvio E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Recepcion_Envio SET Nombre_Conductor = '" + E.Nombre_Conductor + "', Placa_Camion = '" + E.Placa_Camion + "', Cedula = '" + E.Cedula + "', " +
                    "N_Bines = " + E.N_Bines + ", Hora_Envio = '" + E.Hora_Envio.ToString(@"hh\:mm\:ss") + "', Hora_Llegada = '" + E.Hora_Llegada.ToString(@"hh\:mm\:ss") + "', Fecha = '" + E.Fecha.ToString("yyyy-MM-dd") + "', " +
                    "Peso_Neto = " + E.Peso_Neto + ", Estado = '" + E.Estado + "' " +
                    "WHERE ID_Recepcion = " + E.ID_Recepcion;


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



        public static bool CambiarEstado(OBJRecepcionEnvio E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Recepcion_Envio SET Estado = '" + E.Estado + "' WHERE ID_Recepcion = " + E.ID_Recepcion;

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
                sql = "SELECT ID_Recepcion FROM Recepcion_Envio ORDER BY ID_Recepcion";

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
                    sql = "SELECT MAX(ID_Recepcion) as max_id FROM Recepcion_Envio";
                    SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                    SqlDataReader dr    = comando.ExecuteReader();

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
