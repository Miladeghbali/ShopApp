using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.FinacialYears
{
    public partial class List : Framework.ViewBase
    {
        Framework.GridControl<Entities.FinancialYear> grid;
        RepositoryAbstracts.IFinancialYearsRepository yearsRepo;
        public List(RepositoryAbstracts.IFinancialYearsRepository yearsRepo)
        {
            this.yearsRepo = yearsRepo;
            InitializeComponent();
            AddAction("جدید", btn =>
            {
                var view = viewEngine.ViewInForm<Views.FinacialYears.Editor>(editor =>
                {
                    editor.Entity = new Entities.FinancialYear()
                    {
                        StartDate = DateTime.Now,
                        FinishDate = DateTime.Now.AddYears(1)
                    };
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    yearsRepo.Add(view.Entity);
                    grid.AddItem(view.Entity);
                }

            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Views.FinacialYears.Editor>(editor =>
                 {
                     editor.Entity = grid.CurrentItem;
                 }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    yearsRepo.Update(grid.CurrentItem);
                    grid.ResetBindings();
                }
            });
            AddAction("بستن سال مالی", btn =>
            {
                if (grid.CurrentItem.IsClosed)
                {
                    MessageBox.Show("سال مالی قبلا بسته شده است");
                    return;
                }
                if (MessageBox.Show("آیا بستن سال مالی را تایید می کنید؟", "بستن سال مالی", MessageBoxButtons.YesNo) == DialogResult.Yes) { }
                {
                    grid.CurrentItem.IsClosed = true;
                    grid.CurrentItem.CloseDate = DateTime.Now;
                    yearsRepo.Update(grid.CurrentItem);
                }
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            grid = new Framework.GridControl<Entities.FinancialYear>(this);
            grid.AddTextBoxColumn(year=>year.Title,"عنوان");
            grid.AddTextBoxColumn(year=>year.StartDate,"تاریخ شروع");
            grid.AddTextBoxColumn(year=>year.FinishDate,"تاریخ پایان");
            grid.setDataSource(yearsRepo.All());
            base.OnLoad(e); 
        }
        public override string ViewTitle
        { 
            get
            {
                return "مدیریت سال های مالی";
            }
        }
    }
}
