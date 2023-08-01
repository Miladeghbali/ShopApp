using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Repositories
{
    public class SqlDbTools : IDbTools
    {
        private SqlConnectionStringBuilder connectionStringBuilder;
        private string tempDbName;
        public SqlDbTools()
        {
            RefreshConnectionString();
        }
        public async Task<bool> CheckDatabaseExists()
        {
             try
            {
                using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
                {
                    await connection.OpenAsync();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE [name]=@dbname";
                    command.Parameters.Add(new SqlParameter("dbname", tempDbName));
                    var result = (int)await command.ExecuteScalarAsync();
                    return result > 0;

                }
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public async Task<bool> CheckDbConnection()
        {
            try
            {
                using(var connection=new SqlConnection(connectionStringBuilder.ConnectionString))
                {
                   await connection.OpenAsync();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> CreateDatabase(string dbScript)
        {
            try
            {
                using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
                {
                    await connection.OpenAsync();
                    var command = connection.CreateCommand();
                    command.CommandText = "CREATE DATABASE " + tempDbName;
                    await command.ExecuteNonQueryAsync();
                    connection.ChangeDatabase(tempDbName);
                    var createTablescommand = connection.CreateCommand();
                    createTablescommand.CommandText = dbScript.Replace("Go", "").Replace("[ShopDb]", "[" + tempDbName + "]");
                    await createTablescommand.ExecuteNonQueryAsync();
                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void RefreshConnectionString()
        {
            var connectionSring = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            connectionStringBuilder = new SqlConnectionStringBuilder(connectionSring);
            tempDbName = connectionStringBuilder.InitialCatalog;
            connectionStringBuilder.InitialCatalog = "master";
        }
    }
}
