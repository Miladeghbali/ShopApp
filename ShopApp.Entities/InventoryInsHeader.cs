using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","InventoryInsHeaders")]
    public class InventoryInsHeader
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public long ID { get; set; }
        public int InventoryId { get; set; }
        public int TypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Accepted { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public long? AcceptedByUserId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
