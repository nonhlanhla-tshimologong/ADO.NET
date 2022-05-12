using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSQLServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");

            var datasource = "(localdb)\\MSSQLLocalDB";
            //var datasource = "laptop - k8gsbmr5";
            var database = "Northwind";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.Read();
        }
    }
}
