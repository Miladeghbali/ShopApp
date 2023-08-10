using ShopApp.Framework.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;


namespace ShopApp.WinClinet.Views.InventoryIns
{
    public partial class Editor : Framework.ViewBase
    {
        public Entities.InventoryInsHeader InvHeader { get; set; }
        RepositoryAbstracts.IInventoriesRepository invRepo;
        RepositoryAbstracts.IInventoryInsTypesRepository typesRepo;
        Framework.GridControl<Entities.InventoryInsDetail> grid;
        List<Entities.InventoryInsDetail> details=new List<Entities.InventoryInsDetail>();


        public Editor(RepositoryAbstracts.IInventoriesRepository invRepo, RepositoryAbstracts.IInventoryInsTypesRepository typesRepo)
        {
            InitializeComponent();
            this.invRepo = invRepo;
            this.typesRepo = typesRepo;

            InventoriesComboBox.DataSource = this.invRepo.All();
            InventoriesComboBox.DisplayMember = "Title";
            InventoriesComboBox.ValueMember = "Id";

            InsTypeComboBox.DataSource = this.typesRepo.All();
            InsTypeComboBox.DisplayMember = "Title";
            InsTypeComboBox.ValueMember = "Id";

            AddAction("تایید", btn =>
            {
                foreach (var item in details)
                {
                    MessageBox.Show(item.ProductId.ToString());
                }
            });

        }
        protected override void OnLoad(EventArgs e)
        {
            if(InvHeader==null)
                InvHeader= new Entities.InventoryInsHeader { Date = DateTime.Now };
            Expression<Func<Entities.InventoryInsHeader, DateTime>> selector = header => header.Date;
            var propertyName = new Framework.ExpressionHandler().GetPropertyName(selector);          
            DateDropdown.Value = selector.Compile()(InvHeader).ToString("yyyy/MM/dd");
            DateDropdown.RightToLeft = RightToLeft.No;
            DateDropdown.InputMask = "0000/00/00";
            DateDropdown.Tag = selector.Compile()(InvHeader);
            DateDropdown.OnValueChanged += (obj, args) =>
            {
                DateDropdown.Tag = DateDropdown.Value.ConvertToDate();
                InvHeader.GetType().GetProperty(propertyName).SetValue(InvHeader, DateDropdown.Tag);
            };
            DateDropdown.GetDropdownControl += () =>
            {
                var picker = new Framework.DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) =>
                {
                    DateDropdown.CloseDropdown();
                };
                if (DateDropdown.Tag != null)
                {
                    picker.SelectedDate = (DateTime)DateDropdown.Tag;
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    DateDropdown.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    DateDropdown.Tag = picker.SelectedDate;
                    InvHeader.GetType().GetProperty(propertyName).SetValue(InvHeader, DateDropdown.Tag);
                };
                return picker;
            };
            grid = new Framework.GridControl<Entities.InventoryInsDetail>(GridContainerPanel);
            grid.AddTextBoxColumn(detail => detail.ProductId, "شناسه محصول");
            grid.AddTextBoxColumn(detail => detail.Amount, "مقدار");
            grid.AddTextBoxColumn(detail => detail.TotalPrice, "قیمت");
            grid.AllowAddRows=true;
            grid.AllowDeleteRows=true;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            grid.setDataSource(details);
            base.OnLoad(e);
        }
    }
}
