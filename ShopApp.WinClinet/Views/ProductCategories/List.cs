using ShopApp.Framework;
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
    public partial class List : Framework.ViewBase
    {
        RepositoryAbstracts.IProductCategoriesRepository catRepo;
        TreeControl<Entities.ProductCategory> treeControl;
        public List(RepositoryAbstracts.IProductCategoriesRepository catRepo)
        {
            InitializeComponent();
            this.catRepo = catRepo;
            AddAction("جدید ریشه", btn =>
            {
               var view= viewEngine.ViewInForm<Editor>(editor =>
                {                    
                }, true);
                if (view.DialogResult==DialogResult.OK)
                {
                    catRepo.Add(view.Entity);
                    treeControl.InitRoots();

                }
            });
            AddAction("جدید ", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(editor =>
                {                   
                    editor.ParentCategory = treeControl.SelectedObject;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    catRepo.Add(view.Entity);
                    treeControl.InitRoots();
                }

            });
            AddAction("ویرایش", btn =>
            {
                var view = viewEngine.ViewInForm<Editor>(editor =>
                {
                    editor.Entity = treeControl.SelectedObject;
                }, true);
                if (view.DialogResult == DialogResult.OK)
                {
                    catRepo.Update(view.Entity);
                    treeControl.InitRoots();
                }

            });
            AddAction("حذف", btn =>
            {
                if (MessageBox.Show("آیا حذف را تایید می کنید؟", "حذف دسته بندی محصولات", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    treeControl.SelectedObject.Deleted = true;
                    treeControl.SelectedObject.DeleteDate = DateTime.Now;
                    catRepo.Update(treeControl.SelectedObject);
                    treeControl.InitRoots();
                }                
            });
            AddAction(" پارامترها", btn =>
            {
                if (treeControl.SelectedObject == null)
                    return;
                viewEngine.ViewInForm<Parameters>(view =>
                {
                    view.ProductCategoryId = treeControl.SelectedObject.ID;
                },true);
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            treeControl = new Framework.TreeControl<Entities.ProductCategory>(this);
            treeControl.OnGetNodes += TreeControl_OnGetNodes; 
            treeControl.InitRoots();    
            base.OnLoad(e);
        }

        private IEnumerable<TreeControlNode<Entities.ProductCategory>> TreeControl_OnGetNodes(TreeNode parent, Entities.ProductCategory obj)
        {
            List<TreeControlNode<Entities.ProductCategory>> nodes = new List<TreeControlNode<Entities.ProductCategory>>();
            if (parent==null)
            {
                var rootCategories = catRepo.GetByParentCategoryId(null);
                return rootCategories.Where(cat=>!cat.Deleted).Select(cat => new TreeControlNode<Entities.ProductCategory>()
                {
                    Text = cat.Title,
                    Object = cat
                });
            }
            else
            {
                var parentCategory = obj;
                var rootCategories = catRepo.GetByParentCategoryId(parentCategory.ID);
                return rootCategories.Where(cat => !cat.Deleted).Select(cat => new TreeControlNode<Entities.ProductCategory>()
                {
                    Text = cat.Title,
                    Object = cat
                });

            }
           
        }

        public override string ViewTitle => "مدیریت دسته بندی محصولات";
    }
 }
