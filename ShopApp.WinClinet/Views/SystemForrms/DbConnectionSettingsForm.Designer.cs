namespace ShopApp.WinClinet.Views.SystemForrms
{
    partial class DbConnectionSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.WaitingProgressBar = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.WaitingProgressBar);
            this.ButtonsPanel.Controls.Add(this.CancelButton);
            this.ButtonsPanel.Controls.Add(this.AcceptButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 121);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(462, 37);
            this.ButtonsPanel.TabIndex = 8;
            // 
            // WaitingProgressBar
            // 
            this.WaitingProgressBar.Location = new System.Drawing.Point(174, 3);
            this.WaitingProgressBar.Name = "WaitingProgressBar";
            this.WaitingProgressBar.Size = new System.Drawing.Size(275, 29);
            this.WaitingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.WaitingProgressBar.TabIndex = 2;
            this.WaitingProgressBar.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 29);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "صرفنظر";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 3);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 29);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "تایید";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(12, 13);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataSourceTextBox.Size = new System.Drawing.Size(330, 21);
            this.DataSourceTextBox.TabIndex = 1;
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(348, 13);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(115, 13);
            this.DataSourceLabel.TabIndex = 0;
            this.DataSourceLabel.Text = "نام سرور(Data Source)";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(12, 39);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserIdTextBox.Size = new System.Drawing.Size(330, 21);
            this.UserIdTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 65);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(330, 21);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(410, 73);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "کلمه عبور";
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(12, 91);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseTextBox.Size = new System.Drawing.Size(330, 21);
            this.DatabaseTextBox.TabIndex = 7;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(391, 98);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(72, 13);
            this.DatabaseLabel.TabIndex = 6;
            this.DatabaseLabel.Text = "بانک اطلاعاتی";
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(365, 39);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(94, 17);
            this.UserIdCheckBox.TabIndex = 2;
            this.UserIdCheckBox.Text = "شناسه کاربری";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // DbConnectionSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 158);
            this.Controls.Add(this.UserIdCheckBox);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DataSourceLabel);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.DataSourceTextBox);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbConnectionSettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات ارتباط با بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.DbConnectionSettingsForm_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ProgressBar WaitingProgressBar;
    }
}