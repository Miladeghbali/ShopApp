using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.Framework.ExtensionMethods;

namespace ShopApp.WinClinet.Views.Customers
{
    public partial class List : Framework.ViewBase
    {
        public List()
        {
            InitializeComponent();
            //AddAction("مشتری جدید", button =>
            // {
            //     viewEngine.ViewInForm<Views.Customers.Editor>(null, true);

            // });
            //AddAction("حذف مشتری", button => MessageBox.Show("حذف مشتری"));
           
           
        }
        protected override void OnLoad(EventArgs e)
        {

            dropdown1.Value = DateTime.Now.ToString("yyyy/MM/dd");
            dropdown1.RightToLeft = RightToLeft.No;
            dropdown1.InputMask = "0000/00/00";
            dropdown1.OnValueChanged += (obj, args) =>
            {
                dropdown1.Tag = dropdown1.Value.ConvertToDate();
            };
            dropdown1.GetDropdownControl += () =>
            {
                var picker = new Framework.DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) =>
                {
                    dropdown1.CloseDropdown();
                };
                if (dropdown1.Tag != null)
                {
                    picker.SelectedDate = (DateTime)dropdown1.Tag;
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    dropdown1.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    dropdown1.Tag = picker.SelectedDate;
                };
                return  picker;
            };
            //List<ShopApp.Entities.Product> products = new List<Entities.Product>();
            //var grid = new Framework.GridControl<Entities.Product>(this);
            //grid.AddTextBoxColumn(product => product.ID, "شناسه ");
            //grid.AddTextBoxColumn(product => product.Title, " عنوان ");
            //grid.AddTextBoxColumn(product => product.Code, "کد محصول ");
            //grid.setDataSource(products);
            base.OnLoad(e);
        }
        
        public override string ViewTitle
        {
            get
            {
                return "لیست مشتریان";
            }
        }
       
    }
}
