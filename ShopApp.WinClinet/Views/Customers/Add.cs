using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.RepositoryAbstracts;

namespace ShopApp.WinClinet.Views.Customers
{
    public partial class Add : Framework.ViewBase
    {
        private IUsersRepository usersRepo;
        public int Id { get; set; }
        public Add(RepositoryAbstracts.IUsersRepository usersRepo)
        {
            this.usersRepo = usersRepo;
            InitializeComponent();
           
        }
        public override string ViewIdentifier
        {
            get
            {
                return "CustomersAdd"+Id;
            }
        }
        public override string ViewTitle { get => "تعریف مشتری با شناسه" + Id; }
    }
}
