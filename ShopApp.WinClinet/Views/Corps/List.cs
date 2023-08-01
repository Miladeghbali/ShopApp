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
    public partial class List : Framework.ViewBase
    {
        RepositoryAbstracts.ICorporationsRepository corpsRepo;
        Framework.GridControl<Entities.Corporation> corpsGrid;
        public List(RepositoryAbstracts.ICorporationsRepository corpsRepo)
        {
            this.corpsRepo = corpsRepo;
            InitializeComponent();
            AddAction("جدید", btn =>
            {
                var editor = viewEngine.ViewInForm<Editor>(null, true);
                if (editor.DialogResult == DialogResult.OK)
                {
                    corpsRepo.Add(editor.Entity);
                    corpsGrid.AddItem(editor.Entity);
                    corpsGrid.ResetBindings();
                }
            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(editor=>
                {
                    editor.Entity = corpsGrid.CurrentItem;
                },true);
                if (view.DialogResult == DialogResult.OK)
                {
                    corpsRepo.Update(view.Entity);
                }
            });
            AddAction("حذف", btn =>
            {
                if (MessageBox.Show("آیا حذف را تایید می کنید؟","حذف شرکت",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    corpsGrid.CurrentItem.Deleted = true;
                    corpsGrid.CurrentItem.DeleteDate = DateTime.Now;
                    corpsRepo.Update(corpsGrid.CurrentItem);
                    corpsGrid.setDataSource(corpsRepo.GetByDeleted(false));
                }
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            corpsGrid = new Framework.GridControl<Entities.Corporation>(this);
            corpsGrid.AddTextBoxColumn(entity => entity.Title, "عنوان");
            corpsGrid.AddTextBoxColumn(entity => entity.Telephone, "شماره تماس");
            corpsGrid.AddTextBoxColumn(entity => entity.Fax, "فکس");
            corpsGrid.setDataSource(corpsRepo.GetByDeleted(false));
            base.OnLoad(e);
        }
        public override string ViewTitle 
        {
            get
            {
                return "مدیریت شرکت ها";
            }
         }
    }
}
