using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderHouse.ADO.NET
{
    public class Ventas : DBHandler
    {
        public List<Ventas> GetVentas()
        {
            List<Ventas> ventas = new List<Ventas>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Venta", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Ventas Venta = new Ventas();

                                Venta.id = Convert.ToInt32(dataReader["Id"]);
                                Venta.comentarios = dataReader["Comentarios"].ToString();
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return ventas;
        }
    }
}
