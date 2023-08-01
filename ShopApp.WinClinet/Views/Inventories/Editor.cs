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
    public partial class Editor : Framework.EntityEditor<Entities.Inventory>
    {
        RepositoryAbstracts.ICorporationsRepository corpsRepo;
        public Editor(RepositoryAbstracts.ICorporationsRepository corpsRepo)
        {
            this.corpsRepo = corpsRepo;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            ComboBox<int, Entities.Corporation>(inv => inv.CorporationsId, "شرکت/موسسه", corpsRepo.All(), corp => corp.Title, corp => corp.ID);
            TextBox(inv => inv.Title, "نام انبار ");
            TextBox(inv => inv.Description, "توضیحات ", true);
            AdjustControls();
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get
            {
                if (Entity.ID == 0)
                    return "تعریف انبار جدید";
                return "ویرایش انبار";
            }
        }
    }
}
