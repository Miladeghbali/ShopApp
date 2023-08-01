using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","FinancialYears")]
    public class FinancialYear
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int ID { get; set; }
        public int CorporationsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsClosed { get; set; }
        public DateTime? CloseDate { get; set; }
        public long? ClosedByUserId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long? DeletedByUserId { get; set; }
    }
}
