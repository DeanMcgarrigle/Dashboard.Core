using System.Data.SqlClient;
using Dashboard.Core.Properties;
using MachSecure.BusinessObjects;

namespace Dashboard.Core.Nancy
{
    public class ConnectionProvider
    {
        public static SqlConnectionStringBuilder ConnectionString(string dbName)
        {
            return new SqlConnectionStringBuilder
            {
                DataSource = Settings.Default.DBServer,
                IntegratedSecurity = false,
                InitialCatalog = dbName,
                UserID = Settings.Default.DBUser,
                Password = Encryption.Decrypt(Settings.Default.DBPassword)
            };

        }
    }
}
