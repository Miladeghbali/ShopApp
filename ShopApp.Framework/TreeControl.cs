using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public class TreeControl<T>
    {
        TreeView treeView;
        public event Func<TreeNode, T,IEnumerable<TreeControlNode<T>>> OnGetNodes;

        public TreeControl(Control container) 
        {
            treeView = new TreeView();
            container.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;
            treeView.RightToLeftLayout = true;

            treeView.BeforeExpand += TreeView_BeforeExpand; 
        }
        public T SelectedObject
        {
           get
            {
                return treeView.SelectedNode==null? default(T):(T)treeView.SelectedNode.Tag;
            }
        }
        public TreeNode SelectedNode
        {
            get
            {
                return treeView.SelectedNode;
            }
        }
        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Tag is string && e.Node.Nodes[0].Tag.ToString()== "not-loaded")
            {
                e.Node.Nodes.Clear();
                foreach(var  node in CreateNodes(OnGetNodes(e.Node,(T)e.Node.Tag)))
                {
                    e.Node.Nodes.Add(node);
                }

            }
        }

        public void InitRoots()
        {
            treeView.Nodes.Clear();
            foreach (var node in CreateNodes(OnGetNodes(null, default(T))))
            {
                treeView.Nodes.Add(node);

            }
            
        }
        private List<TreeNode> CreateNodes(IEnumerable<TreeControlNode<T>> nodeItems)
        {
            var nodes = new List<TreeNode>();
            foreach (var node in nodeItems)
            {
                var treenode = new TreeNode
                {
                    Text = node.Text,
                    Tag = node.Object
                };
                treenode.Nodes.Add(new TreeNode
                {
                    Tag = "not-loaded",
                });
                nodes.Add(treenode);
            }
            return nodes;
        }     

    }
    public class TreeControlNode<T>
    {
        public string Text { get; set; }
        public T Object { get; set; }
    }
}
