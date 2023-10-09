using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM
{
    public class VentaData
    {
        private static string connectionString = @"Server=Sebasto;Database=SistemaGestion;Trusted_Connection=True;Encrypt=False";

        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Comentarios, IdUsuario FROM Venta";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var venta = new Venta();
                                    {
                                        venta.Id = Convert.ToInt32(dr["Id"]);
                                        venta.Comentarios = dr["Comentarios"].ToString();
                                        venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    }


                                    lista.Add(venta);
                                }
                            }
                        }
                    }


                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Venta ObtenerVenta(int id)
        {
            Venta venta = new Venta();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Comentarios, IdUsuario FROM Venta Where Id=@Id";
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
                                    venta.Id = Convert.ToInt32(dr["Id"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                }
                            }
                        }
                    }

                    
                    conexion.Close();
                }
                return venta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearVenta(Venta venta)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Venta (Comentarios,IdUsuario)" +
                    " VALUES(@Comentarios, @IdUsuario); ";

                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

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

        public static void ModificarVenta(Venta venta)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Venta " +
                    "SET Comentarios = @Comentarios ,IdUsuario = @IdUsuario" +
                    " WHERE Id = @Id";

                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

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

        public static void EliminarVenta(Venta venta)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    string query = "DELETE FROM Venta " +
                    " WHERE Id = @Id";

                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });

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