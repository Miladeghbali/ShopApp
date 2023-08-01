namespace ShopApp.Framework
{
    partial class ViewBase
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
            this.ButtonsBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonsBar
            // 
            this.ButtonsBar.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonsBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsBar.Location = new System.Drawing.Point(0, 502);
            this.ButtonsBar.Name = "ButtonsBar";
            this.ButtonsBar.Size = new System.Drawing.Size(603, 37);
            this.ButtonsBar.TabIndex = 0;
            this.ButtonsBar.Visible = false;
            // 
            // ViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonsBar);
            this.Name = "ViewBase";
            this.Size = new System.Drawing.Size(603, 539);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsBar;
    }
}
