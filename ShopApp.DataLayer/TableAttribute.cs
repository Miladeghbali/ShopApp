using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TableAttribute:Attribute
    {
        public TableAttribute(string schema, string table)
        {
            this.Schema = schema;
            this.Table = table;
        }
        public string Schema { get; set; }
        public string Table { get; set; }
    }
}
