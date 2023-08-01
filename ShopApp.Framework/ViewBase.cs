using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public partial class ViewBase : UserControl
    {
        public ViewBase()
        {
            InitializeComponent();
        }
        public DialogResult DialogResult { get; set; }
        public virtual string ViewTitle { get; }
        public virtual string ViewIdentifier
        {
         get{ return this.GetType().FullName; }
        }
       
        protected Button AddAction(string title,Action<Button> onClick)
        {
            if (!ButtonsBar.Visible)
                ButtonsBar.Visible = true; 
            var button = new Button();
            button.Text = title;
            button.Click += (obj, e) =>
            {
                onClick(button);
            };
            var totalButtons = ButtonsBar.Controls.Count;
            var left = ((totalButtons + 1) * 5) + (totalButtons * 85);
            button.Location = new Point(left, 7);
            button.Size = new Size(85, 23);
            ButtonsBar.Controls.Add(button);            
            return button;
        }
        protected void CloseView(DialogResult? dialogResult=null)
        {
            viewEngine.CloseView(this,dialogResult);
        }
        public ViewEngine viewEngine
        {
            get;
            internal set;
        }
       
    }
}
