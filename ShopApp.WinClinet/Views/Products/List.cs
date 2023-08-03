using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.Products
{
    public partial class List : Framework.ViewBase
    {

        RepositoryAbstracts.IProductsRepository productsRepo;
        Framework.GridControl<Entities.Product> productsGrid;
        public int? ProductCategoryId { get; set; }
        public List(RepositoryAbstracts.IProductsRepository productsRepo)
        {
            InitializeComponent();
            this.productsRepo = productsRepo;

            AddAction("جدید", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(null, true);
                if(view.DialogResult == DialogResult.OK) 
                {
                    productsRepo.Add(view.Entity);
                    productsGrid.AddItem(view.Entity);
                    productsGrid.ResetBindings();
                }
            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.Entity = productsGrid.CurrentItem;
                },true);
                if (view.DialogResult == DialogResult.OK)
                {
                    productsRepo.Update(view.Entity);
                    productsGrid.ResetBindings();
                }
            });
            AddAction("حذف", btn => 
            {
                if (MessageBox.Show("آیا حذف را تایید می کنید؟", "حذف محصول", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productsRepo.Remove(productsGrid.CurrentItem);
                    productsGrid.RemoveCurrent();
                    productsGrid.ResetBindings();
                }
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            productsGrid = new Framework.GridControl<Entities.Product>(this);           
            productsGrid.AddTextBoxColumn(p => p.ProductCategoryId, " دسته بندی");
            productsGrid.AddTextBoxColumn(p => p.Title, "عنوان محصول");  
            if(ProductCategoryId.HasValue)
                productsGrid.setDataSource(productsRepo.GetByProductCategoryId(ProductCategoryId.Value));
            else
                 productsGrid.setDataSource(productsRepo.All());
            base.OnLoad(e); 
        }
        public override string ViewTitle =>"مدیریت محصولات";
    }
}
