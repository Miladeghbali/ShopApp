using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","Users")]
    public class User
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public long ID { get; set; }
        public string Username { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
