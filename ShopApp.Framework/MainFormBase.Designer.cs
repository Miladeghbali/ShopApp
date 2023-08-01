namespace ShopApp.Framework
{
    partial class MainFormBase
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
            this.components = new System.ComponentModel.Container();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CloseCurrentTab = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(439, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // StatusBarStrip
            // 
            this.StatusBarStrip.Location = new System.Drawing.Point(0, 374);
            this.StatusBarStrip.Name = "StatusBarStrip";
            this.StatusBarStrip.Size = new System.Drawing.Size(439, 22);
            this.StatusBarStrip.TabIndex = 1;
            this.StatusBarStrip.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 350);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "صفحه نخست";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CloseCurrentTab
            // 
            this.CloseCurrentTab.AutoSize = true;
            this.CloseCurrentTab.Location = new System.Drawing.Point(6, 34);
            this.CloseCurrentTab.Name = "CloseCurrentTab";
            this.CloseCurrentTab.Size = new System.Drawing.Size(13, 13);
            this.CloseCurrentTab.TabIndex = 0;
            this.CloseCurrentTab.TabStop = true;
            this.CloseCurrentTab.Text = "X";
            this.CloseCurrentTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseCurrentTab_LinkClicked);
            // 
            // MainFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 396);
            this.Controls.Add(this.CloseCurrentTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusBarStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainFormBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی برنامه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.StatusStrip StatusBarStrip;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel CloseCurrentTab;
    }
}