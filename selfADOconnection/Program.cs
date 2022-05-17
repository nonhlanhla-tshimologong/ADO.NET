using System;
using AccessLayer2;
namespace selfADOconnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connect = "Server=LAPTOP-K8GSBMR5; Database=BethanysPieShop; Trusted_Connection=true";

            Access2.Connect(connect);
        }
    }

}