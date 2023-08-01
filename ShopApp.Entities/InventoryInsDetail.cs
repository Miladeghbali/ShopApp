using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","InventoryInsDetails")]
    public class InventoryInsDetail
    {
        [DataLayer.PrimaryKey]
        public long InventoryInsHeaderId { get; set; }
        [DataLayer.PrimaryKey]
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
