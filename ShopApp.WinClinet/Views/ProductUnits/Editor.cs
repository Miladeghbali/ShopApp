using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.ProductUnits
{
    public partial class Editor : Framework.EntityEditor<Entities.ProductUnit>
    {
        public Editor()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            TextBox(entity => entity.Title, "عنوان");
            TextBox(entity => entity.Description, "توضیحات");
            AdjustControls();
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get
            {
                return Entity.ID == 0 ? "تعریف واحد اندازه گیری جدید" : " ویرایش واحد اندازه گیری";
            }
        }
    }
}
