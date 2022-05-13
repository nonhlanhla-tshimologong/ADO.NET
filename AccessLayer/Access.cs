using System.Data.SqlClient;
namespace AccessLayer
{
    public class Access
    {
        // method grabs string input
        //create a method that would connect to the database
        public static void Connect(string connectionString)
        {
            //create connection
            SqlConnection con = new SqlConnection(connectionString);
          



            ////create query that writes to database
            //string sql = "Insert Into YourTabele(columnName, columnName) values ('value1', value2)";

            ////open connection
            //con.Open();

            ////create a sql command referencing the connection
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();

            ////close connection
            //con.Close();

            //open connection
            con.Open();
            //create query that reads from database
            string sql2 = "SELECT * FROM Category";
            //create a sql command referencing the connection
            SqlCommand cmd2 = new SqlCommand(sql2, con);

            //create sql data reader
            SqlDataReader dataReader = cmd2.ExecuteReader();

            //while its reading
            while (dataReader.Read())
            {
                //store the columns in variables
              
                var itemName = dataReader["CategoryName"].ToString();
                var itemPrice = dataReader["Description"].ToString();

                //write to console
                Console.WriteLine(itemName + " " + itemPrice);


            }
            //close connection
            con.Close();
            //dispose of connection
            con.Dispose();




        }
    }
}