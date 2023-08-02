using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.ProductCategories
{
    public partial class Editor : Framework.EntityEditor<Entities.ProductCategory>
    {
        public Entities.ProductCategory ParentCategory { get; set; }
        RepositoryAbstracts.IInventoriesRepository invRepo;
        public Editor(RepositoryAbstracts.IInventoriesRepository invRepo)
        {
            this.invRepo = invRepo;
            InitializeComponent();
           
        }
        protected override void OnLoad(EventArgs e)
        {
            if (ParentCategory != null)
            {
                Entity.ParentCategoryId = ParentCategory.ID;
                var txt= TextBox("دسته بندی پدر", false);
                txt.Text = ParentCategory.Title;
                txt.Enabled = false;

            }
            if (ParentCategory == null)
                ComboBox(cat => cat.InventoryId, "انبار", invRepo.All(), inv => inv.Title, inv => inv.ID);
            else
                Entity.InventoryId = ParentCategory.InventoryId;
            TextBox(cat => cat.Title, "عنوان");
            TextBox(cat => cat.Description, "توضیحات",true);
            AdjustControls();
            base.OnLoad(e); 
        }
    }
}
