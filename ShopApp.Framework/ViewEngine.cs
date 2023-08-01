using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;

namespace ShopApp.Framework
{
    public class ViewEngine
    {
        private TabControl tabControl;
        private Registry typesRegistry;
        private Dictionary<string, TabPage> openTabs = new Dictionary<string, TabPage>();
        private Dictionary<string, Form> openForms = new Dictionary<string, Form>();

        public ViewEngine(TabControl tabControl,StructureMap.Registry registry)
        {
            this.tabControl = tabControl;
            this.typesRegistry = registry;
        }
        public T ViewInTab<T>(Action<T> initializer=null) where T : ViewBase
        {
            var container = new StructureMap.Container(typesRegistry);
            var viewInstance =/*بدون پکیجStructureMap-- (ViewBase)Activator.CreateInstance<T>()*/container.GetInstance<T>();
            viewInstance.viewEngine = this;
            if (initializer != null)
                initializer(viewInstance);
            /*initializer?.Invoke(viewInstance); بعد ساده سازی */
            if (openTabs.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentTab = openTabs[viewInstance.ViewIdentifier];
                tabControl.SelectedTab = currentTab;
                return currentTab.Controls.OfType<T>().First();
            }
            TabPage tabPage = new TabPage();
            tabPage.Text = viewInstance.ViewTitle;
            tabPage.Controls.Add(viewInstance);
            viewInstance.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
            openTabs.Add(viewInstance.ViewIdentifier, tabPage);
            return (T)viewInstance;
        }
        public void CloseViewTab(TabPage selectedTab)
        {
            var currentView = selectedTab.Controls.OfType<ViewBase>().FirstOrDefault();
            if (currentView != null)
            {
                var viewIdentifier = currentView.ViewIdentifier;
                if (openTabs.ContainsKey(viewIdentifier))
                {
                    openTabs.Remove(viewIdentifier);
                }
            }
           
          
            tabControl.TabPages.Remove(selectedTab);
        }
 
        internal void CloseView(ViewBase viewBase, DialogResult? dialogResult = null)
        {
            if (openForms.ContainsKey(viewBase.ViewIdentifier))
            {
                if (dialogResult.HasValue)
                {
                    openForms[viewBase.ViewIdentifier].DialogResult = dialogResult.Value;
                    viewBase.DialogResult=dialogResult.Value;                    
                    if (!openForms[viewBase.ViewIdentifier].Modal)
                        openForms[viewBase.ViewIdentifier].Close();
                }
                else
                    openForms[viewBase.ViewIdentifier].Close();
                openForms.Remove(viewBase.ViewIdentifier);
            }
            else if (openTabs.ContainsKey(viewBase.ViewIdentifier))
            {
                tabControl.TabPages.Remove(openTabs[viewBase.ViewIdentifier]);
                openTabs.Remove(viewBase.ViewIdentifier);
            }
        }
        public T ViewInForm<T>(Action<T> initializer = null, bool displayAsDialog=false) where T : ViewBase
        {
            var container = new StructureMap.Container(typesRegistry);
            var viewInstance = /*(ViewBase)Activator.CreateInstance<T>()*/container.GetInstance<T>();
            viewInstance.viewEngine = this;
            if (initializer != null)
                initializer(viewInstance);
            if (openForms.ContainsKey(viewInstance.ViewIdentifier))
            {
                var currentForm = openForms[viewInstance.ViewIdentifier];
                currentForm.Activate();
                return (T)currentForm.Controls.OfType<ViewBase>().First();
            }
            var form = new Form();
            form.Width = 800;
            form.Height = 600;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.RightToLeft = RightToLeft.Yes;
            form.Font = new System.Drawing.Font("Tahoma", 8);
            form.Text = viewInstance.ViewTitle;
            form.Controls.Add(viewInstance);
            form.FormClosed += (obj, e) =>
            {
                openForms.Remove(viewInstance.ViewIdentifier);
            };
            viewInstance.Dock = DockStyle.Fill;
            openForms.Add(viewInstance.ViewIdentifier, form);
            if (displayAsDialog)
                form.ShowDialog();
            else
                form.Show();
            return (T)viewInstance;
        }
    }
}
