using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static CoderHouse.PropiedadesModelo;

namespace CoderHouse.ADO.NET
{
    public class ProductosVendido : DbHandler
    {
        public List<ProductoVendido> GetProductosVendidos()
        {
            List<ProductoVendido> ProductoVendido = new List<ProductoVendido>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM ProductoVendido", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        // Me aseguro que haya filas que leer
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                ProductoVendido productoVendido = new ProductoVendido();

                                productoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                productoVendido.Stock = Convert.ToBoolean(dataReader["Stock"]);
                                productoVendido.IdProducto = dataReader["IdProducto"].ToString();
                                productoVendido.IdVenta = dataReader["IdVenta"].ToString();
                            }
                        }

                        sqlConnection.Close();
                    }
                }

                return ProductoVendido;
            }
        }
    }   
}
