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
    public partial class List : Framework.ViewBase
    {
       
        RepositoryAbstracts.IProductUnitsRepository unitsRepo;
        Framework.GridControl<Entities.ProductUnit> unitsGrid;
        public List(RepositoryAbstracts.IProductUnitsRepository UnitsRepo)
        {
            this.unitsRepo = UnitsRepo;
            InitializeComponent();
            AddAction("جدید", btn =>
            {
                var editor = viewEngine.ViewInForm<Editor>(null, true);
                if (editor.DialogResult == DialogResult.OK)
                {
                    unitsRepo.Add(editor.Entity);
                    unitsGrid.AddItem(editor.Entity);
                    unitsGrid.ResetBindings();
                }
            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.Entity = unitsGrid.CurrentItem;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    unitsRepo.Update(view.Entity);
                }
            });
            AddAction("حذف", btn =>
            {
                if (MessageBox.Show("آیا حذف را تایید می کنید؟", "حذف واحد  اندازه گیری", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    unitsGrid.CurrentItem.Deleted = true;
                    unitsGrid.CurrentItem.DeleteDate = DateTime.Now;
                    unitsRepo.Update(unitsGrid.CurrentItem);
                    unitsGrid.setDataSource(unitsRepo.GetByDeleted(false));
                }
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            unitsGrid = new Framework.GridControl<Entities.ProductUnit>(this);
            unitsGrid.AddTextBoxColumn(entity => entity.Title, "عنوان");
            unitsGrid.setDataSource(unitsRepo.GetByDeleted(false));
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get
            {
                return "مدیریت واحد های اندازه گیری";
            }

        } 
    }
}
