using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosReporte
    {

        // Hago la consulta para proporcionar los datos del Reporte 1
        public static double CantidadCajasEmpacadasXDia(DateTime fecha)
        {
            int cantidadTotalCajas = 0;

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT SUM(Cantidad_Cajas) AS Total_Cajas " +
                             "FROM Empaque " +
                             "WHERE Fecha_Empaque = '" + fecha + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();


                if (dr.Read())
                {
                    cantidadTotalCajas = Convert.ToInt32(dr["Total_Cajas"]);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
                return -1;
            }

            return cantidadTotalCajas;
        }



        // Hago la consulta para proporcionar los datos del Reporte 2
        public static double CantidadPalletsEmpacadosXDia(DateTime fecha)
        {
            int cantidadTotalPallets = 0;

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT COUNT(Numero_Pallet) AS Total_Pallets " +
                             "FROM Palletizado " +
                             "WHERE Fecha_Palletizado = '" + fecha + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    cantidadTotalPallets = Convert.ToInt32(dr["Total_Pallets"]);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones aquí
                return -1;
            }

            return cantidadTotalPallets;
        }



        public static List<Tuple<string, string, string, string, string, int>> ProcedenciaFrutaXDia(DateTime fecha)
        {
            List<Tuple<string, string, string, string, string, int>> listaProcedencia = new List<Tuple<string, string, string, string, string, int>>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT F.Nombre_Finca, L.Nombre_Lote, B.Nombre_Bloque, V.Nombre_Variedad, T.Tipos_De_Frutos, SUM(D.Cantidad_Fruta) AS Total_Fruta " +
                             "FROM Detalle_Cosecha D " +
                             "INNER JOIN Fincas F ON D.Finca_ID = F.ID_Finca " +
                             "INNER JOIN Lotes L ON D.Lote_ID = L.ID_Lote " +
                             "INNER JOIN Bloques B ON D.Bloque_ID = B.ID_Bloque " +
                             "INNER JOIN Variedades_De_Frutos V ON D.Variedad_Fruto_ID = V.ID_Variedad_Fruto " +
                             "INNER JOIN Tipos_De_Frutos T ON D.Tipo_Fruto_ID = T.ID_Tipo_De_Fruto " +
                             "WHERE D.Boleta_ID IN (SELECT ID_Boleta FROM Boleta_Cosecha WHERE Fecha_Cosecha = '" + fecha + "' ) " +
                             "GROUP BY F.Nombre_Finca, L.Nombre_Lote, B.Nombre_Bloque, V.Nombre_Variedad, T.Tipos_De_Frutos";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());

                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    var tuple = new Tuple<string, string, string, string, string, int>(
                        dr["Nombre_Finca"].ToString(),
                        dr["Nombre_Lote"].ToString(),
                        dr["Nombre_Bloque"].ToString(),
                        dr["Nombre_Variedad"].ToString(),
                        dr["Tipos_De_Frutos"].ToString(),
                        Convert.ToInt32(dr["Total_Fruta"])
                    );

                    listaProcedencia.Add(tuple);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaProcedencia;
        }






    }
}
