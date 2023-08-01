using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.WinClinet.Helpers
{
    public class ConfigurationTools
    {
        public static void UpdateConnectionString(string connectionName,string dataSource,string initialCatalog,bool integratedSecurity,string userId, string password)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStrings = (ConnectionStringsSection)config.GetSection("connectionStrings");
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = dataSource;
            connectionStringBuilder.IntegratedSecurity = !integratedSecurity;
            if (!integratedSecurity)
            {
                connectionStringBuilder.UserID = userId;
                connectionStringBuilder.Password = password;
            }
            connectionStringBuilder.InitialCatalog = initialCatalog;
            connectionStrings.ConnectionStrings[connectionName].ConnectionString = connectionStringBuilder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
