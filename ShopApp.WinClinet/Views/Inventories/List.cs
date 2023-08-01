using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.Inventories
{
    public partial class List : Framework.ViewBase
    {
        Framework.GridControl<Entities.Inventory> invGrid;
        RepositoryAbstracts.IInventoriesRepository invRepo;
        public List(RepositoryAbstracts.IInventoriesRepository invRepo)
        {
            this.invRepo = invRepo;
            InitializeComponent();
            AddAction("جدید", btn =>
             {
                 var view=viewEngine.ViewInForm<Editor>(null,true);
                 if (view.DialogResult==DialogResult.OK)
                 {
                     invRepo.Add(view.Entity);
                     invGrid.AddItem(view.Entity);
                     invGrid.ResetBindings();
                 }
             }); 
            AddAction("ویرایش", btn =>
             {
                 var view=viewEngine.ViewInForm<Editor>(editor =>
                 {
                     editor.Entity = invGrid.CurrentItem;
                 }, true);
                 if(view.DialogResult==DialogResult.OK)
                      invRepo.Update(invGrid.CurrentItem);
                 invGrid.ResetBindings();
             });
            AddAction("حذف", OnDeleteAction);

        }
        private void OnDeleteAction(Button button)
        {
            if (invGrid.CurrentItem == null)
                return;
            if (MessageBox.Show("آیا حذف انبار را تایید می کنید؟","حذف انبار",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                invRepo.Remove(invGrid.CurrentItem);
                invGrid.RemoveCurrent();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            invGrid = new Framework.GridControl<Entities.Inventory>(this);
            invGrid.AddTextBoxColumn(inv => inv.CorporationsId, "شناسه شرکت");
            invGrid.AddTextBoxColumn(inv => inv.Title, "عنوان انبار");
            invGrid.AddTextBoxColumn(inv => inv.Description, "توضیحات");
            invGrid.setDataSource(invRepo.All());
            base.OnLoad(e);
        }
        public override string ViewTitle {
            get 
            {
                return "مدیریت انبار ها ";
            } 
        }
    }
}
