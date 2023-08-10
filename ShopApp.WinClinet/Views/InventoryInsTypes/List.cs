using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.InventoryInsTypes
{
    public partial class List : Framework.ViewBase
    {
        Framework.GridControl<Entities.InventoryInsType> grid;
        RepositoryAbstracts.IInventoryInsTypesRepository typesRepo;
        public List(RepositoryAbstracts.IInventoryInsTypesRepository typesRepo)
        {
            InitializeComponent();

            AddAction("جدید", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(null,true);
                 if(view.DialogResult== DialogResult.OK)
                {
                    typesRepo.Add(view.Entity);
                    grid.AddItem(view.Entity);
                    grid.ResetBindings();  
                }
            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(v =>
                {
                    v.Entity = grid.CurrentItem;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    typesRepo.Update(view.Entity);                    
                    grid.ResetBindings();
                }
            });
            AddAction("حذف", btn =>
            {
                if (MessageBox.Show("آیا حذف را تایید می کنید؟", "حذف نوع رسید", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    typesRepo.Remove(grid.CurrentItem);
                    grid.RemoveCurrent();
                    grid.ResetBindings();
                }
            });
            this.typesRepo = typesRepo;
        }
        protected override void OnLoad(EventArgs e)
        {
            grid = new Framework.GridControl<Entities.InventoryInsType>(this);
            grid.AddTextBoxColumn(type => type.Title, "عنوان");
            grid.setDataSource(typesRepo.All());
            base.OnLoad(e);
        }
        public override string ViewTitle => "مدیریت انواع رسید";
    }
}
