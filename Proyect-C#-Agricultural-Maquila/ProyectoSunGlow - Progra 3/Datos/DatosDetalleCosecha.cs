using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosDetalleCosecha
    {

        public static List<OBJDetalleCosecha> ConsultarDetalles(int Boleta)
        {
            List<OBJDetalleCosecha> listaDetalles = new List<OBJDetalleCosecha>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT * FROM Detalle_Cosecha "
                           + "WHERE Boleta_ID = '" + Boleta + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJDetalleCosecha objDetalle = new OBJDetalleCosecha();
                    objDetalle.ID_Detalle = Convert.ToInt32(dr["ID_Detalle"]);
                    objDetalle.Boleta_ID = Convert.ToInt32(dr["Boleta_ID"]);
                    objDetalle.N_Bin = Convert.ToInt32(dr["N_Bin"]);
                    objDetalle.Cantidad_Fruta = Convert.ToInt32(dr["Cantidad_Fruta"]);
                    objDetalle.Promedio_Fruta = Convert.ToInt32(dr["Promedio_Fruta"]);
                    objDetalle.Finca_ID = Convert.ToInt32(dr["Finca_ID"]);
                    objDetalle.Lote_ID = Convert.ToInt32(dr["Lote_ID"]);
                    objDetalle.Bloque_ID = Convert.ToInt32(dr["Bloque_ID"]);
                    objDetalle.Variedad_Fruto_ID = Convert.ToInt32(dr["Variedad_Fruto_ID"]);
                    objDetalle.Tipo_Fruto_ID = Convert.ToInt32(dr["Tipo_Fruto_ID"]);
                    objDetalle.Estado = dr["Estado"].ToString();


                    listaDetalles.Add(objDetalle);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaDetalles;
        }

        public static bool Guardar(OBJDetalleCosecha E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Detalle_Cosecha VALUES (" + E.ID_Detalle + ", '" + E.Boleta_ID + "', '" + E.N_Bin + "', '" + E.Cantidad_Fruta + "', '" + E.Promedio_Fruta + "', '"
                            + E.Finca_ID + "', '" + E.Lote_ID + "', '" + E.Bloque_ID + "', '" + E.Variedad_Fruto_ID + "', '" + E.Tipo_Fruto_ID + "', '" + E.Estado + "' ) ";
                 
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



        public static List<int> ObtenerIDsDisponibles()
        {
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Detalle FROM Detalle_Cosecha ORDER BY ID_Detalle";

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
                    sql = "SELECT MAX(ID_Detalle) as max_id FROM Detalle_Cosecha";
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
