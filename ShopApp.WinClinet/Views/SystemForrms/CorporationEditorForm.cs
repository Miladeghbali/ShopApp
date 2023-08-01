using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.RepositoryAbstracts;

namespace ShopApp.WinClinet.Views.SystemForrms
{
    public partial class CorporationEditorForm : Form
    {
        public Entities.Corporation Corporation { get; set; }
        public CorporationEditorForm()
        {
        
            InitializeComponent();
        }

        private void CorporationEditorForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.DataBindings.Add("Text", Corporation, "Title");
            DescriptionTextBox.DataBindings.Add("Text", Corporation, "Description");
            AddressTextBox.DataBindings.Add("Text", Corporation, "Address");
            TelephoneTextBox.DataBindings.Add("Text", Corporation, "Telephone");
            FaxTextBox.DataBindings.Add("Text", Corporation, "Fax");
            
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
