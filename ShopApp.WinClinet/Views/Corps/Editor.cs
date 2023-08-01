using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.Corps
{
    public partial class Editor : Framework.EntityEditor<Entities.Corporation>
    {
        public Editor()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            TextBox(entity => entity.Title, "عنوان");
            TextBox(entity => entity.Description, "توضیحات",true);
            TextBox(entity => entity.Address, "آدرس",true);
            var phoneTextBox = TextBox(entity => entity.Telephone, "شماره تماس");
            phoneTextBox.RightToLeft = RightToLeft.No;
            var faxTextBox = TextBox(entity => entity.Fax, "فکس");
            faxTextBox.RightToLeft = RightToLeft.No;
            AdjustControls();
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get
            {
                return Entity.ID==0?"تعریف شرکت جدید":"ویرایش شرکت";
            }
        }
    }
}
