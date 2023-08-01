using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.SystemForrms
{
    public partial class SplashScreenForm : Form
    {
        IDbTools dbTools;
        public SplashScreenForm(IDbTools dbTools)
        {
            this.dbTools = dbTools;
            InitializeComponent();
        }
       
        private async void SplashScreenForm_Load(object sender, EventArgs e)
        {
            if(!await CheckDbConnection())
                DialogResult = DialogResult.Cancel;
            dbTools.RefreshConnectionString();
            if (await CheckDatabase())
            {
                DialogResult = DialogResult.OK;
                return;
            }
               
            DialogResult = DialogResult.Cancel;
        }
        private async Task<bool> CheckDatabase()
        {
            StatusLabel.Text = "در حال بررسی بانک اطلاعاتی....";
            if (!await dbTools.CheckDatabaseExists())
            {
                StatusLabel.Text = "در حال ایجاد اطلاعاتی....";
                if (!await dbTools.CreateDatabase(Properties.Resources.Shobdbscript))
                    return false;
            }
            return true;
        }
        private async Task<bool> CheckDbConnection()
        {
            StatusLabel.Text = "...در حال بررسی ارتباط با سرور";
            if (!await dbTools.CheckDbConnection())
            {
                var container = new StructureMap.Container(new Ioc.TypesRegistry());
                var connectionSettingsForm = container.GetInstance<DbConnectionSettingsForm>();
                var result = connectionSettingsForm.ShowDialog();
                if (result != DialogResult.OK)
                    return false;
            }
            return true;

        }
        private async Task<bool> CheckSqlConnectionAsync()
        {
            var connectionSring = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            var connectionStringBuilder = new SqlConnectionStringBuilder(connectionSring);
            connectionStringBuilder.InitialCatalog = "master";
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

                //var connectionSettingsForm = new Views.SystemForrms.DbConnectionSettingsForm();
                //var result= connectionSettingsForm.ShowDialog();
                //return result == DialogResult.OK;
                return false;
            }
          
        }
        private async Task<bool> CheckDatabaseExists()
        {
            StatusLabel.Text = "در حال بررسی بانک اطلاعاتی....";
            var connectionSring = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            var connectionStringBuilder = new SqlConnectionStringBuilder(connectionSring);
            var tempDbName = connectionStringBuilder.InitialCatalog;
            connectionStringBuilder.InitialCatalog = "master";
            try
            {
                using (var connection = new SqlConnection(connectionSring))
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
                MessageBox.Show("مشکلی در زمان اجرا عملیات پیش آمده است", "پیام سیسنم");

                DialogResult = DialogResult.Cancel;
            }
            return false;
        }
        private async Task<bool> CreateDatabase()
        {
            StatusLabel.Text = "در حال ایجاد اطلاعاتی....";
            var connectionSring = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            var connectionStringBuilder = new SqlConnectionStringBuilder(connectionSring);
            var tempDbName = connectionStringBuilder.InitialCatalog;
            connectionStringBuilder.InitialCatalog = "master";
            try
            {
                using (var connection = new SqlConnection(connectionStringBuilder.ConnectionString))
                {
                    await connection.OpenAsync();
                    var command = connection.CreateCommand();
                    command.CommandText = "CREATE DATABASE "+tempDbName;
                    await command.ExecuteNonQueryAsync();
                    connection.ChangeDatabase(tempDbName);
                    var createTablescommand = connection.CreateCommand();
                    createTablescommand.CommandText = Properties.Resources.Shobdbscript.Replace("Go", "").Replace("[ShopDb]", "["+tempDbName+"]");                     
                    await createTablescommand.ExecuteNonQueryAsync();
                    return true;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی در زمان اجرا عملیات پیش آمده است", "پیام سیسنم");

                DialogResult = DialogResult.Cancel;
            }
            return false;
        }
    }
}
