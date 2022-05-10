using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //string connectionString = "Data Source =(localdb);Initial Catalog=Northwind;";

            //provide the query string with a parameter placeholder.
            string queryString = "SELECT ProductID, UnitPrice, ProductName FROM dbo.products"
                         + "WHERE UnitPrice > @pricePoint "
                         + "ORDER BY UnitProce DESC;";

            //specify the parameter value 
            int paramValue = 5;

            //Create and open the connection in a using block. This ensures that all resources will be closed and disposed 
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Create the command and parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);

                //open the connection in a try/catch block.
                //create and execute the dataReader, writing the results set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}

