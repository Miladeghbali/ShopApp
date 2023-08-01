using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public partial class MainFormBase : Form
    {
        private MenuHandler menuHandler;

        private ViewEngine viewEngine;
        public MainFormBase()
        {

            InitializeComponent();
            menuHandler = new MenuHandler(MainMenuStrip.Items);
            var toolstripLable = new ToolStripLabel();
            DateTimeTimer.Tick += (obj,e)=> 
            {
                toolstripLable.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss");
            };
            DateTimeTimer.Interval = 1000;
            StatusBarStrip.Items.Add(toolstripLable);
            DateTimeTimer.Start();
        }
        public ViewEngine ViewEngine
        {
            get
            {
                if (viewEngine == null)
                    viewEngine = new ViewEngine(tabControl1,TypesRegistry);
                return viewEngine;
            }
        }
        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected MenuHandler AddMenu(string title, Image img, EventHandler eventHandler)
        {
            return menuHandler.AddMenu(title, img, eventHandler);
        }
        protected MenuHandler AddMenu(string title)
        {
            return menuHandler.AddMenu(title, null, null);
        }
        protected MenuHandler AddMenu(string title, Image img)
        {
            return menuHandler.AddMenu(title, img, null);
        }

        private void CloseCurrentTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewEngine.CloseViewTab(tabControl1.SelectedTab);
        }
        protected StructureMap.Registry TypesRegistry { get; set; }

        
    }
}
