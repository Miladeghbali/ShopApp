namespace ShopApp.WinClinet.Views.Customers
{
    partial class List
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
            this.dropdown1 = new ShopApp.Framework.Dropdown();
            this.SuspendLayout();
            // 
            // dropdown1
            // 
            this.dropdown1.Location = new System.Drawing.Point(257, 71);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(330, 27);
            this.dropdown1.TabIndex = 1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dropdown1);
            this.Name = "List";
            this.Size = new System.Drawing.Size(644, 391);
            this.Controls.SetChildIndex(this.dropdown1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Dropdown dropdown1;
    }
}
