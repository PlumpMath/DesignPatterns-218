using System;

/// <summary>
/// A class of which only a single instance can exist 
/// </summary>
namespace Creational.Singleton {
    class Program {
        static void Main(string[] args) {
            System.Data.SqlClient.SqlConnection connectionFirst = SqlConnectionSingleton.Connection;
            Console.WriteLine("Connection First  : {0}", connectionFirst.GetHashCode());
            System.Data.SqlClient.SqlConnection connectionSecond = SqlConnectionSingleton.Connection;
            Console.WriteLine("Connection Second : {0}", connectionSecond.GetHashCode());
            System.Data.SqlClient.SqlConnection connectionServer = SqlConnectionServerSingleton.Connection;
            Console.WriteLine("Connection Server : {0}", connectionServer.GetHashCode());
            System.Data.SqlClient.SqlConnection connectionLocal = SqlConnectionLocalSingleton.Connection;
            Console.WriteLine("Connection Local  : {0}", connectionLocal.GetHashCode());
            Console.Read();
            
        }
    }
}
