using Connector.Library.Contracts;
using Connector.Library.DataAccess;
using System;
using System.Configuration;

namespace Connector.Library
{
    public static class GlobalConfiguration
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.Sql:
                    var sql = new SqlConnector();
                    Connection = sql;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(databaseType), databaseType, null);
            }
        }

        public static string GetConnectionString(string connectionString) =>
            ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
    }
}
