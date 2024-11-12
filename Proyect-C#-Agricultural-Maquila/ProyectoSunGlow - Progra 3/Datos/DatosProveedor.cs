using ProyectoSunGlow___Progra_3.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosProveedor
    {

        public static OBJProveedor ConsultarPorNombreProveedor(String Proveedor)
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



        public static OBJProveedor ConsultarPorIDProveedor(int Proveedor)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Proveedores "
                    + "WHERE ID_Proveedor = '" + Proveedor + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJProveedor objProveedor = new OBJProveedor();

                if (dr.Read())
                {
                    objProveedor.ID_Proveedor = Convert.ToInt32(dr["ID_Proveedor"]);

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



        public static OBJProveedor ConsultarPorProveedorPais(String Proveedor, String Pais)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Proveedores "
                    + "WHERE Pais = '" + Proveedor + "' "
                    + "AND Pais = '" + Pais + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJProveedor objProveedor = new OBJProveedor();

                if (dr.Read())
                {
                    objProveedor.Nombre_Proveedor = dr["Nombre_Proveedor"].ToString();
                    objProveedor.Pais = dr["Pais"].ToString();

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



        public static bool Guardar(OBJProveedor E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Proveedores VALUES (" + E.ID_Proveedor + ", '" + E.Nombre_Proveedor + "' , '" + E.Direccion + "', '"
                            + E.Ciudad + "', '" + E.Pais + "', '" + E.Telefono + "', '"
                            + E.Correo + "', '" + E.Categoria_Producto_Servicio + "', '" + E.Estado + "' ) ";

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




        public static OBJProveedor Consultar(String Proveedor)
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
                    objProveedor.ID_Proveedor                   = Convert.ToInt32(dr["ID_Proveedor"]);
                    objProveedor.Nombre_Proveedor               = dr["Nombre_Proveedor"].ToString();
                    objProveedor.Direccion                      = dr["Direccion"].ToString();
                    objProveedor.Ciudad                         = dr["Ciudad"].ToString();
                    objProveedor.Pais                           = dr["Pais"].ToString();
                    objProveedor.Telefono                       = dr["Telefono"].ToString();
                    objProveedor.Correo                         = dr["Correo_Electronico"].ToString();
                    objProveedor.Categoria_Producto_Servicio    = dr["Categoria_Producto_Servicio"].ToString();
                    objProveedor.Estado                         = dr["Estado"].ToString();

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





        public static bool Actualizar(OBJProveedor E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Proveedores SET Nombre_Proveedor = '" + E.Nombre_Proveedor + "', Direccion = '" + E.Direccion + "', Ciudad = '" + E.Ciudad + "', Pais = '"
                    + E.Pais + "', Telefono = '" + E.Telefono + "', Correo_Electronico = '" + E.Correo + "', Categoria_Producto_Servicio = '" + E.Categoria_Producto_Servicio + "', "
                    + "Estado = '" + E.Estado + "' "
                    + "WHERE ID_Proveedor = " + E.ID_Proveedor;


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




        public static bool CambiarEstado(OBJProveedor E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Proveedores SET Estado = '" + E.Estado + "' WHERE ID_Proveedor = " + E.ID_Proveedor;

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
                sql = "SELECT ID_Proveedor FROM Proveedores ORDER BY ID_Proveedor";

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
                    sql = "SELECT MAX(ID_Proveedor) as max_id FROM Proveedores"; SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
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
