using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","Products")]
    public class Product
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductUnitId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
