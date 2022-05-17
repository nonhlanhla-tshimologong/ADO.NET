using System;
using Accessing;
namespace usingStatementDeclaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connect = "Server = ; Database = ; Trusted_Connection=true;";

            AccessClass.Connect(connect);
        }
    }
}