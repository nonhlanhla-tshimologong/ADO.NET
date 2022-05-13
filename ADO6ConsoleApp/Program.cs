using System;
using AccessLayer;
namespace AD06ConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a connection string which is used to store the details.
            string connect = "Server=LAPTOP-K8GSBMR5; Database=BethanysPieShop;Trusted_Connection=true;";

            //access the function from the access layer
            Access.Connect(connect);
           
        }
    }
}

