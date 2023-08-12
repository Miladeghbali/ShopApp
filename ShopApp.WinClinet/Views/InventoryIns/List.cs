using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.InventoryIns
{
    public partial class List : Framework.ViewBase
    {
        Framework.GridControl<Entities.InventoryInsHeader> grid;
        RepositoryAbstracts.IInventoryInsHeadersRepository headersRepo;
        public List(RepositoryAbstracts.IInventoryInsHeadersRepository headersRepo)
        {
            InitializeComponent();
            this.headersRepo = headersRepo;
            AddAction("جدید", btn =>
            {
                 viewEngine.ViewInForm<Editor>(null,true);
                 grid.setDataSource(headersRepo.All());
            });
          
        }
        protected override void OnLoad(EventArgs e)
        {
            grid = new Framework.GridControl<Entities.InventoryInsHeader>(this);
            grid.AddTextBoxColumn(ins => ins.Title, "عنوان");
            grid.AddTextBoxColumn(ins => ins.Date, "تاریخ");
            grid.setDataSource(headersRepo.All());
            base.OnLoad(e);
        }
        public override string ViewTitle => "مدیریت رسیدها";
    }
}
