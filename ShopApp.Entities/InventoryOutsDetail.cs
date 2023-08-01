using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","InventoryOutsDetails")]
    public class InventoryOutsDetail
    {
        [DataLayer.PrimaryKey]
        public long InventoryOutsHeaderId { get; set; }
        [DataLayer.PrimaryKey]
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
