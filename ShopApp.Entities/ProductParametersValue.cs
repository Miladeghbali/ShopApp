using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","ProductParametersValues")]
    public class ProductParametersValue
    {
        [DataLayer.PrimaryKey]
        public int ProductId { get; set; }
        [DataLayer.PrimaryKey]
        public int ProductParameterId { get; set; }
        public string Value { get; set; }
    }
}
