using ProyectoSunGlow___Progra_3.Datos.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosBoletaCosecha
    {

        public static bool Guardar(OBJBoletaCosecha E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Boleta_Cosecha VALUES (" + E.ID_Boleta + ", '" + E.Consecutivo_Boleta + "', '" + E.Envio_ID + "', '"
                            + E.Cuadrilla + "', '" + E.Fecha_Cosecha.ToString("yyyy-MM-dd") + "', '" + E.Hora_Cosecha.ToString(@"hh\:mm\:ss") + "', '" + E.Estado + "' ) ";

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



        public static List<OBJDetalleCosecha> DetallesLigadosBoleta(int detalles)
        {
            List<OBJDetalleCosecha> listaDetalleLigado = new List<OBJDetalleCosecha>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT * FROM Detalle_Cosecha "
                           + "WHERE Boleta_ID = '" + detalles + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJDetalleCosecha detalle = new OBJDetalleCosecha();
                    detalle.ID_Detalle = Convert.ToInt32(dr["ID_Detalle"]);
                    detalle.Boleta_ID = Convert.ToInt32(dr["Boleta_ID"]);
                    detalle.N_Bin = Convert.ToInt32(dr["N_Bin"]);
                    detalle.Cantidad_Fruta = Convert.ToInt32(dr["Cantidad_Fruta"]);
                    detalle.Promedio_Fruta = Convert.ToDecimal(dr["Promedio_Fruta"]);
                    detalle.Finca_ID = Convert.ToInt32(dr["Finca_ID"]);
                    detalle.Lote_ID = Convert.ToInt32(dr["Lote_ID"]);
                    detalle.Bloque_ID = Convert.ToInt32(dr["Bloque_ID"]);
                    detalle.Variedad_Fruto_ID = Convert.ToInt32(dr["Variedad_Fruto_ID"]);
                    detalle.Tipo_Fruto_ID = Convert.ToInt32(dr["Tipo_Fruto_ID"]);
                    detalle.Estado = dr["Tipo_Fruto_ID"].ToString();

                    listaDetalleLigado.Add(detalle);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaDetalleLigado;
        }




        public static List<string> ConsultarEnvios()
        {
            List<string> numerosBines = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Recepcion FROM Recepcion_Envio";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    numerosBines.Add(dr["ID_Recepcion"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return numerosBines;
        }

        public static List<string> ConsultarNumerosBines()
        {
            List<string> numerosBines = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Numero_Bin FROM Bines";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    numerosBines.Add(dr["Numero_Bin"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return numerosBines;
        }



        // Consulta las Boletas y las coloca en la Ventana de Entrada Boletas
        public static List<OBJBoletaCosecha> ConsultarBoletas(DateTime fechaSeleccionada)
        {
            List<OBJBoletaCosecha> listaBoletas = new List<OBJBoletaCosecha>();

            try
            {
                Conexion Conex = new Conexion();
                string sql = "SELECT * FROM Boleta_Cosecha "
                           + "WHERE Fecha_Cosecha = '" + fechaSeleccionada + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    OBJBoletaCosecha objBoleta = new OBJBoletaCosecha();
                    objBoleta.ID_Boleta = Convert.ToInt32(dr["ID_Boleta"]);
                    objBoleta.Consecutivo_Boleta = Convert.ToInt32(dr["Consecutivo_Boleta"]);
                    objBoleta.Envio_ID = Convert.ToInt32(dr["Envio_ID"]);
                    objBoleta.Cuadrilla = dr["Cuadrilla"].ToString();

                    // Obtener solo la fecha de "Fecha_Movimiento"
                    DateTime fecha = Convert.ToDateTime(dr["Fecha_Cosecha"]);
                    objBoleta.Fecha_Cosecha = fecha.Date; // Obtener solo la fecha sin la hora

                    objBoleta.Hora_Cosecha = TimeSpan.Parse(dr["Hora_Cosecha"].ToString());
                    objBoleta.Estado = dr["Estado"].ToString();


                    listaBoletas.Add(objBoleta);
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {
                return null;
            }

            return listaBoletas;
        }



        //Carga el ComboBox Inicialmente con las Fincas
        public static List<string> CargarNombresFincas()
        {
            List<string> nombresFincas = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Finca FROM Fincas";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

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


        //Carga el ComboBox Inicialmente con las Fincas
        public static List<string> CargarNombresLotes(int Finca)
        {
            List<string> nombresLotes = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Lote FROM Lotes "
                    + "WHERE Finca_ID = '" + Finca + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

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


        public static List<string> CargarNombresBloques(int Lote)
        {
            List<string> nombresBloques = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Bloque FROM Bloques "
                    + "WHERE Lote_ID = '" + Lote + "' ";


                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    nombresBloques.Add(dr["Nombre_Bloque"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return nombresBloques;
        }


        //Carga el ComboBox Inicialmente con los Frutos
        public static List<string> CargarNombresVariedadFruto()
        {
            List<string> nombresFrutos = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Nombre_Variedad FROM Variedades_De_Frutos";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

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


        public static List<string> CargarTipoFruto()
        {
            List<string> tipoFrutos = new List<string>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT Tipo_De_Fruto FROM Tipos_De_Frutos";

                SqlCommand comando  = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr    = comando.ExecuteReader();

                while (dr.Read())
                {
                    tipoFrutos.Add(dr["Tipo_De_Fruto"].ToString());
                }

                Conex.Desconectar();
            }
            catch (Exception ex)
            {

            }

            return tipoFrutos;
        }



        //Pregunta si existe la Finca
        public static OBJFinca ConsultarNombresFincas(String Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Fincas "
                    + "WHERE Nombre_Finca = '" + Finca + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJFinca objFinca = new OBJFinca();

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


        //Pregunta busca los Lotes que pertenecen a la finca que se eligió
        public static OBJLote ConsultarNombresLotes(int Finca)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Lotes "
                    + "WHERE Finca_ID = '" + Finca + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJLote objLote = new OBJLote();

                if (dr.Read())
                {
                    objLote.ID_Lote         = Convert.ToInt32(dr["ID_Lote"]);
                    objLote.Nombre_Lote     = dr["Nombre_Lote"].ToString();

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


        //Pregunta busca los bloques que pertenecen al lote que se eligió
        public static OBJBloque ConsultarNombresBloques(int Lote)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Bloques "
                    + "WHERE Lote_ID = '" + Lote + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJBloque objBloque = new OBJBloque();

                if (dr.Read())
                {
                    objBloque.ID_Bloque = Convert.ToInt32(dr["ID_Bloque"]);
                    objBloque.Nombre_Bloque = dr["Nombre_Bloque"].ToString();

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


        //Pregunta busca los bloques que pertenecen al lote que se eligió
        public static OBJVariedadDeFruto ConsultarNombresVariedadFruto(String Fruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Variedades_De_Frutos "
                    + "WHERE Nombre_Variedad = '" + Fruto + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJVariedadDeFruto objFruto = new OBJVariedadDeFruto();

                if (dr.Read())
                {
                    objFruto.ID_Variedad_Fruto = Convert.ToInt32(dr["ID_Variedad_Fruto"]);
                    objFruto.Nombre_Variedad = dr["Nombre_Variedad"].ToString();

                    return objFruto;
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


        //Pregunta busca los bloques que pertenecen al lote que se eligió
        public static OBJTipoDeFruto ConsultarNombresTipoFruto(String Fruto)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Tipos_De_Frutos "
                    + "WHERE Tipo_De_Fruto = '" + Fruto + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJTipoDeFruto objFruto = new OBJTipoDeFruto();

                if (dr.Read())
                {
                    objFruto.ID_Tipo_De_Fruto = Convert.ToInt32(dr["ID_Tipo_De_Fruto"]);
                    objFruto.Tipo_De_Fruto = dr["Tipo_De_Fruto"].ToString();

                    return objFruto;
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


        public static List<int> ObtenerIDsDisponibles()
        {
            List<int> idsUtilizados = new List<int>();
            List<int> idsDisponibles = new List<int>();

            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT ID_Boleta FROM Boleta_Cosecha ORDER BY ID_Boleta";

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
                    sql = "SELECT MAX(ID_Boleta) as max_id FROM Boleta_Cosecha"; 
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
