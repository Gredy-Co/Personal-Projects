using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoSunGlow___Progra_3.Logica;
using System.IO;
using System.Security.Cryptography;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class DatosUsuario
    {

        public static OBJUsuario ConsultarLogin(String Nombre_Usuario, String Contrasena)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Usuarios "
                    + "WHERE Nombre_Usuario = '" + Nombre_Usuario + "' "
                    + "AND Contrasena = '" + Contrasena + "' "
                    + "AND Estado = 'Activo'";

                SqlCommand comando      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr        = comando.ExecuteReader();
                OBJUsuario objUsuario   = new OBJUsuario();

                if (dr.Read())
                {
                    objUsuario.ID_Usuario           = Convert.ToInt32(dr["ID_Usuario"]);
                    objUsuario.Nombre_Usuario       = dr["Nombre_Usuario"].ToString();
                    objUsuario.Contrasena           = dr["Contrasena"].ToString();
                    objUsuario.Correo               = dr["Correo"].ToString();
                    objUsuario.Cedula               = dr["Cedula"].ToString();
                    objUsuario.Nombre               = dr["Nombre"].ToString();
                    objUsuario.Apellido1            = dr["Apellido1"].ToString();
                    objUsuario.Apellido2            = dr["Apellido2"].ToString();
                    objUsuario.Fecha_Creacion       = Convert.ToDateTime(dr["Fecha_Creacion"]);
                    objUsuario.Rol                  = dr["Rol"].ToString();
                    objUsuario.Estado               = dr["Estado"].ToString();

                    return objUsuario;
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



        public static OBJUsuario ConsultarPorUsuario(String Usuario)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Usuarios "
                    + "WHERE Nombre_Usuario = '" + Usuario + "' ";

                SqlCommand comando      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr        = comando.ExecuteReader();
                OBJUsuario objUsuario   = new OBJUsuario();

                if (dr.Read())
                {
                    objUsuario.ID_Usuario       = Convert.ToInt32(dr["ID_Usuario"]);
                    objUsuario.Nombre_Usuario   = dr["Nombre_Usuario"].ToString();
                    objUsuario.Contrasena       = dr["Contrasena"].ToString();
                    objUsuario.Correo           = dr["Correo"].ToString();
                    objUsuario.Cedula           = dr["Cedula"].ToString();
                    objUsuario.Nombre           = dr["Nombre"].ToString();
                    objUsuario.Apellido1        = dr["Apellido1"].ToString();
                    objUsuario.Apellido2        = dr["Apellido2"].ToString();
                    objUsuario.Fecha_Creacion   = Convert.ToDateTime(dr["Fecha_Creacion"]);
                    objUsuario.Rol              = dr["Rol"].ToString();
                    objUsuario.Estado           = dr["Estado"].ToString();

                    return objUsuario;
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



        public static OBJUsuario ConsultarPorIDUsuario(int Usuario)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Usuarios "
                    + "WHERE ID_Usuario = '" + Usuario + "' ";

                SqlCommand comando = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                OBJUsuario objUsuario = new OBJUsuario();

                if (dr.Read())
                {
                    objUsuario.Nombre_Usuario = dr["ID_Usuario"].ToString();

                    return objUsuario;
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



        public static OBJUsuario Consultar(String Cedula)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "SELECT * FROM Usuarios "
                    + "WHERE Cedula = '" + Cedula + "' ";

                SqlCommand comando      = new SqlCommand(sql, Conex.Conectar());
                SqlDataReader dr        = comando.ExecuteReader();
                OBJUsuario objUsuario   = new OBJUsuario();

                if (dr.Read())
                {
                    objUsuario.ID_Usuario           = Convert.ToInt32(dr["ID_Usuario"]);
                    objUsuario.Nombre_Usuario       = dr["Nombre_Usuario"].ToString();
                    objUsuario.Contrasena           = dr["Contrasena"].ToString();
                    objUsuario.Correo               = dr["Correo"].ToString();
                    objUsuario.Cedula               = dr["Cedula"].ToString();
                    objUsuario.Nombre               = dr["Nombre"].ToString();
                    objUsuario.Apellido1            = dr["Apellido1"].ToString();
                    objUsuario.Apellido2            = dr["Apellido2"].ToString();
                    objUsuario.Fecha_Creacion       = Convert.ToDateTime(dr["Fecha_Creacion"]);
                    objUsuario.Rol                  = dr["Rol"].ToString();
                    objUsuario.Estado               = dr["Estado"].ToString();

                    return objUsuario;
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



        public static bool Guardar(OBJUsuario E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = " INSERT INTO Usuarios VALUES (" + E.ID_Usuario + ", '" + E.Nombre_Usuario + "' , '" + E.Contrasena + "', '"
                    + E.Correo + "', '" + E.Cedula + "', '" + E.Nombre + "', '" + E.Apellido1 + "', '" + E.Apellido2 + "', '" 
                    + E.Fecha_Creacion.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + E.Rol + "', '" + E.Estado + "' ) ";
                
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



        public static bool Actualizar(OBJUsuario E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Usuarios SET Nombre_Usuario = '" + E.Nombre_Usuario + "', Contrasena = '" + E.Contrasena + "', Correo = '" + E.Correo + "', Cedula = '"
                    + E.Cedula + "', Nombre = '" + E.Nombre + "', Apellido1 = '" + E.Apellido1 + "', Apellido2 = '" + E.Apellido2 + "', "
                    + "Fecha_Creacion = '" + E.Fecha_Creacion.ToString("yyyy-MM-dd HH:mm:ss") + "', Rol = '" + E.Rol + "', Estado = '" + E.Estado + "' "
                    + "WHERE ID_Usuario = " + E.ID_Usuario;


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




        public static bool CambiarEstado(OBJUsuario E)
        {
            try
            {
                Conexion Conex = new Conexion();
                string sql;
                sql = "UPDATE Usuarios SET Estado = '" + E.Estado + "' WHERE ID_Usuario = " + E.ID_Usuario;

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




        // Llaves para encripcion AES de la Contraseña
        private static string publickey = "12345678";
        private static string secretkey = "87654321";

        public static string EncriptarContrasena(string s)
        {
            string cadenaEncriptada = "";
            byte[] secretkeyByte = { };
            byte[] publickeyByte = { };
            byte[] sEncriptarByte = { };

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = null;

            try
            {
                secretkeyByte = Encoding.UTF8.GetBytes(secretkey);
                publickeyByte = Encoding.UTF8.GetBytes(publickey);
                sEncriptarByte = Encoding.UTF8.GetBytes(s);

                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeyByte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(sEncriptarByte, 0, sEncriptarByte.Length);
                    cs.FlushFinalBlock();

                    cadenaEncriptada = Convert.ToBase64String(ms.ToArray());
                }
                return cadenaEncriptada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
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
                sql = "SELECT ID_Usuario FROM Usuarios ORDER BY ID_Usuario";

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
                    sql = "SELECT MAX(ID_Usuario) as max_id FROM Usuarios"; 
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
