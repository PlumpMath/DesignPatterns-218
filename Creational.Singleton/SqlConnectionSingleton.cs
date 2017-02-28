using System;
using System.Data.SqlClient;

namespace Creational.Singleton {
    public class SqlConnectionSingleton {
        private static volatile SqlConnection connection;
        private static object syncRoot = new Object();
      
        private SqlConnectionSingleton() {
        }

        public static SqlConnection Connection {
            get {
                if (connection == null) {
                    lock (syncRoot) {
                        if (connection == null)
                            connection = new SqlConnection();
                    }
                }
                return connection;
            }
        }
    }
}