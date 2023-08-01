using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","InventoryInsTypes")]
    public class InventoryInsType
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
