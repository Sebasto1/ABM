using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM
{
    public class UsuarioData
    {
        private static string connectionString = @"Server=Sebasto;Database=SistemaGestion;Trusted_Connection=True;Encrypt=False";


        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = new Usuario();


            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario Where Id=@Id";

                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = id });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.Contraseña = dr["Contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                }
                            }
                        }
                        


                    }

                    conexion.Close();
                }   
                return usuario;

            } 
            catch(Exception ex)
            {
                return null;
            }

        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();



            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var usuario = new Usuario();
                                    {
                                        usuario.Id = Convert.ToInt32(dr["Id"]);
                                        usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                        usuario.Nombre = dr["Nombre"].ToString();
                                        usuario.Apellido = dr["Apellido"].ToString();
                                        usuario.Contraseña = dr["Contraseña"].ToString();
                                        usuario.Mail = dr["Mail"].ToString();
                                    }


                                    lista.Add(usuario);
                                }
                            }
                        }
                    }
                    conexion.Close();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static void CrearUsuario(Usuario usuario)
        {


            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Usuario (NombreUsuario, Nombre, Apellido, Contraseña, Mail)" +
                    "VALUES(@NombreUsuario, @Nombre, @Apellido, @Contraseña, @Mail);";

                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario});
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre});
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido});
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña});
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail});

                        comando.ExecuteNonQuery();



                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void ModificarUsuario( Usuario usuario)
        {

            try
            {
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Usuario " +
                        "SET NombreUsuario = @NombreUsuario, Nombre = @Nombre, Apellido = @Apellido, Contraseña = @Contraseña, Mail = @Mail " +
                        "WHERE Id = @Id";
                        conexion.Open();

                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            
                            comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                            comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                            comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                            comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                            comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                            comando.ExecuteNonQuery();



                        }

                       conexion.Close();

                    }
            }
             catch (Exception ex)
            {
                throw;
            }

        }

        public static void EliminarUsuario(Usuario usuario)
        {
            

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Usuario WHERE Id = @Id";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = usuario.Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
