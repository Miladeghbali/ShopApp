using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","Inventories")]
    public class Inventory
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public int CorporationsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
