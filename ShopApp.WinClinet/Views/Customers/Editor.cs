using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.Customers
{
    public partial class Editor : Framework.ViewBase
    {
        public Editor()
        {
            InitializeComponent();           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            viewEngine.ViewInTab<Views.Customers.Add>(view=>
            {
                view.Id = int.Parse(textBox1.Text);
            });
        }
        public override string ViewIdentifier
        {
            get
            {
                return "ویرایش مشتری ";
            }
        }
    }
}
