using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","ProductPrices")]
    public class ProductPrice
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
