
namespace ShopApp.Framework
{
    partial class DateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentCalenderLabel = new System.Windows.Forms.Label();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.LastMonthButton = new System.Windows.Forms.Button();
            this.LastYearButton = new System.Windows.Forms.Button();
            this.ButtomPanel = new System.Windows.Forms.Panel();
            this.GotoTodayDatebutton = new System.Windows.Forms.Button();
            this.GotoSelectedDateButton = new System.Windows.Forms.Button();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.CalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.Day1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.ButtomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.CurrentCalenderLabel);
            this.TopPanel.Controls.Add(this.NextMonthButton);
            this.TopPanel.Controls.Add(this.NextYearButton);
            this.TopPanel.Controls.Add(this.LastMonthButton);
            this.TopPanel.Controls.Add(this.LastYearButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(441, 41);
            this.TopPanel.TabIndex = 0;
            // 
            // CurrentCalenderLabel
            // 
            this.CurrentCalenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCalenderLabel.Location = new System.Drawing.Point(161, 11);
            this.CurrentCalenderLabel.Name = "CurrentCalenderLabel";
            this.CurrentCalenderLabel.Size = new System.Drawing.Size(114, 23);
            this.CurrentCalenderLabel.TabIndex = 1;
            this.CurrentCalenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Location = new System.Drawing.Point(80, 11);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(75, 23);
            this.NextMonthButton.TabIndex = 0;
            this.NextMonthButton.Text = "ماه بعد";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // NextYearButton
            // 
            this.NextYearButton.Location = new System.Drawing.Point(3, 11);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 23);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = "سال بعد";
            this.NextYearButton.UseVisualStyleBackColor = true;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // LastMonthButton
            // 
            this.LastMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastMonthButton.Location = new System.Drawing.Point(281, 11);
            this.LastMonthButton.Name = "LastMonthButton";
            this.LastMonthButton.Size = new System.Drawing.Size(75, 23);
            this.LastMonthButton.TabIndex = 0;
            this.LastMonthButton.Text = "ماه قبل";
            this.LastMonthButton.UseVisualStyleBackColor = true;
            this.LastMonthButton.Click += new System.EventHandler(this.LastMonthButton_Click);
            // 
            // LastYearButton
            // 
            this.LastYearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastYearButton.Location = new System.Drawing.Point(362, 11);
            this.LastYearButton.Name = "LastYearButton";
            this.LastYearButton.Size = new System.Drawing.Size(75, 23);
            this.LastYearButton.TabIndex = 0;
            this.LastYearButton.Text = "سال قبل";
            this.LastYearButton.UseVisualStyleBackColor = true;
            this.LastYearButton.Click += new System.EventHandler(this.LastYearButton_Click);
            // 
            // ButtomPanel
            // 
            this.ButtomPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtomPanel.Controls.Add(this.GotoTodayDatebutton);
            this.ButtomPanel.Controls.Add(this.GotoSelectedDateButton);
            this.ButtomPanel.Controls.Add(this.SelectedDateLabel);
            this.ButtomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomPanel.Location = new System.Drawing.Point(0, 285);
            this.ButtomPanel.Name = "ButtomPanel";
            this.ButtomPanel.Size = new System.Drawing.Size(441, 41);
            this.ButtomPanel.TabIndex = 1;
            // 
            // GotoTodayDatebutton
            // 
            this.GotoTodayDatebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GotoTodayDatebutton.Location = new System.Drawing.Point(361, 8);
            this.GotoTodayDatebutton.Name = "GotoTodayDatebutton";
            this.GotoTodayDatebutton.Size = new System.Drawing.Size(75, 23);
            this.GotoTodayDatebutton.TabIndex = 4;
            this.GotoTodayDatebutton.Text = "تاریخ امروز";
            this.GotoTodayDatebutton.UseVisualStyleBackColor = true;
            this.GotoTodayDatebutton.Click += new System.EventHandler(this.GotoTodayDatebutton_Click);
            // 
            // GotoSelectedDateButton
            // 
            this.GotoSelectedDateButton.Location = new System.Drawing.Point(14, 7);
            this.GotoSelectedDateButton.Name = "GotoSelectedDateButton";
            this.GotoSelectedDateButton.Size = new System.Drawing.Size(95, 23);
            this.GotoSelectedDateButton.TabIndex = 3;
            this.GotoSelectedDateButton.Text = "تاریخ انتخابی";
            this.GotoSelectedDateButton.UseVisualStyleBackColor = true;
            this.GotoSelectedDateButton.Click += new System.EventHandler(this.GotoSelectedDateButton_Click);
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.Location = new System.Drawing.Point(150, 8);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.Size = new System.Drawing.Size(163, 23);
            this.SelectedDateLabel.TabIndex = 2;
            this.SelectedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarDataGridView
            // 
            this.CalendarDataGridView.AllowUserToAddRows = false;
            this.CalendarDataGridView.AllowUserToDeleteRows = false;
            this.CalendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day1Column,
            this.Day2Column,
            this.Day3Column,
            this.Day4Column,
            this.Day5Column,
            this.Day6Column,
            this.Day7Column});
            this.CalendarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarDataGridView.Location = new System.Drawing.Point(0, 41);
            this.CalendarDataGridView.MultiSelect = false;
            this.CalendarDataGridView.Name = "CalendarDataGridView";
            this.CalendarDataGridView.ReadOnly = true;
            this.CalendarDataGridView.RowHeadersVisible = false;
            this.CalendarDataGridView.Size = new System.Drawing.Size(441, 244);
            this.CalendarDataGridView.TabIndex = 2;
            // 
            // Day1Column
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day1Column.DefaultCellStyle = dataGridViewCellStyle1;
            this.Day1Column.HeaderText = "شنبه";
            this.Day1Column.Name = "Day1Column";
            this.Day1Column.ReadOnly = true;
            // 
            // Day2Column
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day2Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Day2Column.HeaderText = "یکشنبه";
            this.Day2Column.Name = "Day2Column";
            this.Day2Column.ReadOnly = true;
            // 
            // Day3Column
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day3Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.Day3Column.HeaderText = "دوشنبه";
            this.Day3Column.Name = "Day3Column";
            this.Day3Column.ReadOnly = true;
            // 
            // Day4Column
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day4Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.Day4Column.HeaderText = "سه شنبه";
            this.Day4Column.Name = "Day4Column";
            this.Day4Column.ReadOnly = true;
            // 
            // Day5Column
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day5Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Day5Column.HeaderText = "چهارشنبه";
            this.Day5Column.Name = "Day5Column";
            this.Day5Column.ReadOnly = true;
            // 
            // Day6Column
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day6Column.DefaultCellStyle = dataGridViewCellStyle6;
            this.Day6Column.HeaderText = "پنج شنبه";
            this.Day6Column.Name = "Day6Column";
            this.Day6Column.ReadOnly = true;
            // 
            // Day7Column
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day7Column.DefaultCellStyle = dataGridViewCellStyle7;
            this.Day7Column.HeaderText = "جمعه";
            this.Day7Column.Name = "Day7Column";
            this.Day7Column.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalendarDataGridView);
            this.Controls.Add(this.ButtomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "DateTimePicker";
            this.Size = new System.Drawing.Size(441, 326);
            this.Load += new System.EventHandler(this.DateTimePicker_Load);
            this.TopPanel.ResumeLayout(false);
            this.ButtomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ButtomPanel;
        private System.Windows.Forms.DataGridView CalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7Column;
        private System.Windows.Forms.Label CurrentCalenderLabel;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button LastMonthButton;
        private System.Windows.Forms.Button LastYearButton;
        private System.Windows.Forms.Label SelectedDateLabel;
        private System.Windows.Forms.Button GotoTodayDatebutton;
        private System.Windows.Forms.Button GotoSelectedDateButton;
    }
}
