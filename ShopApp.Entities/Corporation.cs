using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","Corporations")]
    public class Corporation
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
