using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM
{
    public class ProductoData
    {
        private static string connectionString = @"Server=Sebasto;Database=SistemaGestion;Trusted_Connection=True;Encrypt=False";

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, IdUsuario, Costo, PrecioVenta, Stock,Descripciones FROM Producto";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var producto = new Producto();
                                    {
                                        producto.Id = Convert.ToInt32(dr["Id"]);
                                        producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                        producto.Descripciones = dr["Descripciones"].ToString();
                                        producto.Costo = Convert.ToDouble(dr["Costo"]);
                                        producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                        producto.Stock = Convert.ToInt32(dr["Stock"]);
                                        
                                    }

                                    lista.Add(producto);
                                }
                            }
                        }
                    }


                    conexion.Close();

                    return lista;
                }
            } catch(Exception ex) 
            {
                return null;
            }


        }
        public static Producto ObtenerProducto(int id)
        {
            Producto producto = new Producto();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto Where Id=@Id";
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
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDouble(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                }
                            }
                        }
                    }

                    
                    conexion.Close();
                }
                return producto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearProducto(Producto producto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Producto (Descripciones,Costo, PrecioVenta,Stock, IdUsuario)" +
                    "VALUES(@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario); ";

                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });


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

        public static void ModificarProducto(Producto producto)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Producto " +
                    "SET Descripciones = @Descripcion ,Costo = @Costo, PrecioVenta = @PrecioVenta,Stock = @Stock, IdUsuario=@IdUsuario " +
                     " WHERE Id = @Id";
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });
                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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

        public static void EliminarProducto(Producto producto)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Producto " +
                    " WHERE Id = @Id";

                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

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
