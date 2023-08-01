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
    public partial class DbConnectionSettingsForm : Form
    {
        IDbTools dbTools;
        public DbConnectionSettingsForm(IDbTools dbTools)
        {
            this.dbTools = dbTools;
            InitializeComponent();
        }

        private void DbConnectionSettingsForm_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            Helpers.ConfigurationTools.UpdateConnectionString("DbConnectionString", DataSourceTextBox.Text, DatabaseTextBox.Text, !UserIdCheckBox.Checked, UserIdTextBox.Text, PasswordTextBox.Text);
            dbTools.RefreshConnectionString();
            var userIdChecked = UserIdCheckBox.Checked;
            ChangeControlsStatus(false);
            var connected = await dbTools.CheckDbConnection();
            ChangeControlsStatus(true);
            UserIdCheckBox.Checked = userIdChecked;
            if (!connected)
                MessageBox.Show("تنظیمات ارتباطی صحیح نمی باشد.لطفا مقادیر وارد شده را بررسی کنید.", "پیام سیستم");
           else
            {
                MessageBox.Show("برقراری ارتباط با موفقیت انجام شد.", "پیام سیستم");
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void FillControls()
        {
          
            var connectionSring = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            var connectionStringBuilder = new SqlConnectionStringBuilder(connectionSring);
            DatabaseTextBox.Text = connectionStringBuilder.DataSource;
            UserIdCheckBox.Checked = !connectionStringBuilder.IntegratedSecurity;
            if (!connectionStringBuilder.IntegratedSecurity)
            {
                UserIdCheckBox.Text = connectionStringBuilder.UserID;
                PasswordTextBox.Text = connectionStringBuilder.Password;
            }
            DatabaseTextBox.Text = connectionStringBuilder.InitialCatalog;
        }
        private void ChangeControlsStatus(bool status)
        {
            AcceptButton.Enabled = CancelButton.Enabled = DatabaseTextBox.Enabled = UserIdCheckBox.Enabled = UserIdTextBox.Enabled = PasswordTextBox.Enabled = DatabaseTextBox.Enabled = status;
            WaitingProgressBar.Visible = !status;
        }
    }
}
