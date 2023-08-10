using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet
{
    public partial class MainForm : Framework.MainFormBase
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "مدیریت انبار و فروش";
            TypesRegistry = new Ioc.TypesRegistry();
            var baseInfo = AddMenu("اطلاعات پایه");
            baseInfo.AddMenu("شرکت ها", null, (s, e) =>
              {
                  ViewEngine.ViewInTab<Views.Corps.List>();
              });        
            baseInfo.AddMenu("سال های مالی",null, (s,e)=>
            {
                ViewEngine.ViewInTab<Views.FinacialYears.List>();
            });
            baseInfo.AddMenu("واحد های اندازه گیری ", null, (s, e) =>
            {
                ViewEngine.ViewInTab<Views.ProductUnits.List>();
            });
            baseInfo.AddSeparator();
            baseInfo.AddMenu("انبار ها", null, (s, e) => { ViewEngine.ViewInTab<Views.Inventories.List>(); });
            baseInfo.AddMenu("دسته بندی محصولات",null,(s,e)=>ViewEngine.ViewInTab<Views.ProductCategories.List>());
            baseInfo.AddMenu("محصولات",null, (s, e) => ViewEngine.ViewInTab<Views.Products.List>());
            baseInfo.AddMenu("انواع رسید",null, (s, e) => ViewEngine.ViewInTab<Views.InventoryInsTypes.List>());

            //-------------------
            var inventoryMenu = AddMenu("انبار");
            inventoryMenu.AddMenu("رسید ها",null,(s,e)=> 
            {
                ViewEngine.ViewInTab<Views.InventoryIns.List>();
            });
            //baseInfo.AddMenu("گروه های کالا");
            //baseInfo.AddMenu("کالا ها ");
            //-------------------------------
            //baseInfo.AddMenu("مشتریان", null, CustomersOnClick);

            //baseInfo.AddMenu("انبار ها", null, (sender, e) => { ViewEngine.ViewInTab<Views.Inventories.List>(); });

            //baseInfo.AddSeparator();
            //baseInfo.AddMenu("واحد های اندازه گیری");
        }

        private void CustomersOnClick(object sender, EventArgs e)
        {
            ViewEngine.ViewInTab<Views.Customers.List>();
        }
    }
}
