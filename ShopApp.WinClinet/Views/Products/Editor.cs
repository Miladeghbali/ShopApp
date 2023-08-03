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
    public partial class Editor :Framework.EntityEditor<Entities.Product>
    {
        RepositoryAbstracts.IProductCategoriesRepository catRepo;
        RepositoryAbstracts.IProductUnitsRepository unitsRepo;
        public Editor(RepositoryAbstracts.IProductCategoriesRepository catRepo, RepositoryAbstracts.IProductUnitsRepository unitsRepo)
        {
            this.catRepo = catRepo;
            this.unitsRepo = unitsRepo;
            InitializeComponent();    
        
        }
        protected override void OnLoad(EventArgs e)
        {
            ComboBox(p => p.ProductCategoryId, "دسته بندی", catRepo.All(), cat => cat.Title, cat => cat.ID);
            TextBox(p => p.Code, "کد محصول");
            TextBox(p => p.Title, "عنوان محصول");
            ComboBox(p => p.ProductUnitId, "واحد اندازه گیری", unitsRepo.All(), unit => unit.Title, unit => unit.ID);
            TextBox(p => p.Description, "توضیحات",true);
            AdjustControls();
            base.OnLoad(e);
        }
    }
}
