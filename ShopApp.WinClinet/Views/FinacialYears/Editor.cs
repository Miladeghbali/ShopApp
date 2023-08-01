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
    public partial class Editor : Framework.EntityEditor<Entities.FinancialYear>
    {
        RepositoryAbstracts.ICorporationsRepository corpsRepo;
        public Editor(RepositoryAbstracts.ICorporationsRepository corpsRepo)
        {
            this.corpsRepo = corpsRepo;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            ComboBox<int, Entities.Corporation>(entity => entity.CorporationsId, "شرکت/موسسه", corpsRepo.All(), corp => corp.Title, corp => corp.ID);
            TextBox(entity => entity.Title, "عنوان ");
            TextBox(entity => entity.Description, "توضیحات ", true);
            DatePicker(entity => entity.StartDate, "تاریخ شروع ");        
            DatePicker(entity => entity.FinishDate, "تاریخ پایان ");       
            AdjustControls();
            base.OnLoad(e);
        }
        public override string ViewTitle
        {
            get
            {
                return Entity.ID == 0 ? "تعریف سال مالی" : "ویرایش سال مالی";
            }
        }
    }
}
