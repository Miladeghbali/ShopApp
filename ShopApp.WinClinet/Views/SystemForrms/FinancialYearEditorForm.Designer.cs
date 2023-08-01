namespace ShopApp.WinClinet.Views.SystemForrms
{
    partial class FinancialYearEditorForm
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsBarPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.StartDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FinishMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.FinishDateLabel = new System.Windows.Forms.Label();
            this.ButtonsBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(399, 62);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(49, 13);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "توضیحات";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(394, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(82, 13);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "عنوان سال مالی";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(13, 38);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(380, 76);
            this.DescriptionTextBox.TabIndex = 7;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(380, 20);
            this.TitleTextBox.TabIndex = 5;
            // 
            // ButtonsBarPanel
            // 
            this.ButtonsBarPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsBarPanel.Controls.Add(this.CancelButton);
            this.ButtonsBarPanel.Controls.Add(this.AcceptButton);
            this.ButtonsBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsBarPanel.Location = new System.Drawing.Point(0, 186);
            this.ButtonsBarPanel.Name = "ButtonsBarPanel";
            this.ButtonsBarPanel.Size = new System.Drawing.Size(476, 39);
            this.ButtonsBarPanel.TabIndex = 11;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 31);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "صرفنظر";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 3);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 31);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "تایید";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StartDateMaskedTextBox
            // 
            this.StartDateMaskedTextBox.Location = new System.Drawing.Point(12, 120);
            this.StartDateMaskedTextBox.Mask = "0000/00/00";
            this.StartDateMaskedTextBox.Name = "StartDateMaskedTextBox";
            this.StartDateMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateMaskedTextBox.Size = new System.Drawing.Size(380, 20);
            this.StartDateMaskedTextBox.TabIndex = 12;
            // 
            // FinishMaskedTextBox
            // 
            this.FinishMaskedTextBox.Location = new System.Drawing.Point(12, 146);
            this.FinishMaskedTextBox.Mask = "0000/00/00";
            this.FinishMaskedTextBox.Name = "FinishMaskedTextBox";
            this.FinishMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinishMaskedTextBox.Size = new System.Drawing.Size(380, 20);
            this.FinishMaskedTextBox.TabIndex = 12;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(399, 120);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(62, 13);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "تاریخ شروع";
            // 
            // FinishDateLabel
            // 
            this.FinishDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishDateLabel.AutoSize = true;
            this.FinishDateLabel.Location = new System.Drawing.Point(399, 153);
            this.FinishDateLabel.Name = "FinishDateLabel";
            this.FinishDateLabel.Size = new System.Drawing.Size(58, 13);
            this.FinishDateLabel.TabIndex = 6;
            this.FinishDateLabel.Text = "تاریخ پایان";
            // 
            // FinancialYearEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 225);
            this.Controls.Add(this.FinishMaskedTextBox);
            this.Controls.Add(this.StartDateMaskedTextBox);
            this.Controls.Add(this.ButtonsBarPanel);
            this.Controls.Add(this.FinishDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "FinancialYearEditorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سال مالی";
            this.Load += new System.EventHandler(this.FinancialYearEditorForm_Load);
            this.ButtonsBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Panel ButtonsBarPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.MaskedTextBox StartDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox FinishMaskedTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label FinishDateLabel;
    }
}