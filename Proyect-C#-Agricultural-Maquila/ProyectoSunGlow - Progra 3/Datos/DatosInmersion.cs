using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosInmersion
    {

        public static bool Guardar(OBJInmersion E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Inmersion VALUES (" + E.ID_Inmersion + ", '" + E.DetalleBol_ID + "', '" + E.N_Bin + "', '" + E.Fecha_Inmersion.ToString("yyyy-MM-dd") + "', '" + E.Hora_Inmersion.ToString(@"hh\:mm\:ss") + "', '"
                            + E.Temperatura_Agua + "', '" + E.Duracion_Inmersion + "', '" + E.Estado + "' ) ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();

                if (cantidad > 0)
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

        public static List<OBJDetalleCosecha> BinesDisponibles()
        {
            List<OBJDetalleCosecha> listaBinesDisponibles = new List<OBJDetalleCosecha>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT DC.ID_Detalle, DC.N_Bin, DC.Boleta_ID " +
                             "FROM Detalle_Cosecha DC " +
                             "LEFT JOIN Inmersion I ON DC.ID_Detalle = I.DetalleBol_ID AND DC.N_Bin = I.N_Bin " +
                             "WHERE I.ID_Inmersion IS NULL";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJDetalleCosecha objDetalle = new OBJDetalleCosecha();
                    objDetalle.ID_Detalle = Convert.ToInt32(dr["ID_Detalle"]);
                    objDetalle.Boleta_ID = Convert.ToInt32(dr["Boleta_ID"]);
                    objDetalle.N_Bin = Convert.ToInt32(dr["N_Bin"]);

                    listaBinesDisponibles.Add(objDetalle);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
                return null;
            }

            return listaBinesDisponibles;
        }





        public static List<int> ObtenerIDsDisponibles()
        {
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Inmersion FROM Inmersion ORDER BY ID_Inmersion";

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
                    sql = "SELECT MAX(ID_Inmersion) as max_id FROM Inmersion";
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
