using System;
using System.Data.SqlClient;

namespace Creational.Singleton {
    public class SqlConnectionServerSingleton {
        private static volatile SqlConnection connection;
        private static object syncRoot = new Object();

        private SqlConnectionServerSingleton() {
        }

        public static SqlConnection Connection {
            get {
                if (connection == null) {
                    lock (syncRoot) {
                        if (connection == null)
                            connection = (SqlConnection)((ICloneable)SqlConnectionSingleton.Connection).Clone();
                    }
                }
                return connection;
            }
        }
    }
}
