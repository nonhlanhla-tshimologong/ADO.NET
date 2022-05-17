using System.Data.SqlClient;
namespace Accessing
{
    public class AccessClass
    {
        public static void Connect(string conn)
        {
            string manyLines = @"This is line one
                                 This is line two
                                 Here is line three
                                 The penultimate line is line four
                                 This is the final, fifth line";

            //using (var reader = new StringReader(manyLines))
            //{
            //    string item;
            //    do
            //    {
            //        item = reader.ReadLine();
            //        Console.WriteLine(item);
            //    }
            //    while (item != null);
            //}

            ////method 2
            //using var reader = new StringReader(manyLines);
            //string? item;
            //do
            //{
            //    item = reader.ReadLine();
            //    Console.WriteLine(item);
            //}
            //while(item != null);

            //method 3

            {
                var reader = new StringReader(manyLines);
                try
                {
                    string? item;
                    do
                    {
                        item = reader.ReadLine();
                        Console.WriteLine(item);
                    }
                    while (item != null);
                }
                finally
                {
                    reader.Close();
                }
            }

        }
    }
}