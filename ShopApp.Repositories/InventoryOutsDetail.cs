using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryOutsDetailsRepository : DataLayer.GenericRepository<Entities.InventoryOutsDetail>, RepositoryAbstracts.IInventoryOutsDetailsRepository
    {
        public InventoryOutsDetailsRepository():base("name=DbConnectionString"){}
       public List<Entities.InventoryOutsDetail>GetByInventoryOutsHeaderId(long value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsDetails] WHERE [InventoryOutsHeaderId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsDetail>GetByProductId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsDetails] WHERE [ProductId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsDetail>GetByAmount(decimal value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsDetails] WHERE [Amount] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsDetail>GetByTotalPrice(decimal value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsDetails] WHERE [TotalPrice] = @Value", new SqlParameter("Value", value));
       }
    }
}
