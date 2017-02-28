using System;
using System.Data.SqlClient;

namespace Creational.Singleton {
    public class SqlConnectionSingleton {
        private static volatile SqlConnection connection;
        private static object syncRoot = new Object();
        private static Guid HashCode;

        private SqlConnectionSingleton() {
            HashCode = Guid.NewGuid();
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

        public string GetString() {
            return HashCode.ToString();
        }
    }
}