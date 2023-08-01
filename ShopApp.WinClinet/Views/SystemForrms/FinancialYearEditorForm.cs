using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.WinClinet.Views.SystemForrms
{
    public partial class FinancialYearEditorForm : Form
    {
        public Models.FinancialYearModel FinancialYear { get; set; }
        public FinancialYearEditorForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FinancialYearEditorForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.DataBindings.Add("Text", FinancialYear, "Title");
            DescriptionTextBox.DataBindings.Add("Text", FinancialYear, "Description");
            StartDateMaskedTextBox.DataBindings.Add("Text", FinancialYear, "StartDate");
            FinishMaskedTextBox.DataBindings.Add("Text", FinancialYear, "FinishDate");
           
        }
    }
}
