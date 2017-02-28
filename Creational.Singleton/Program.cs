using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Read();
        }
    }
}
