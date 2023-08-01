using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryInsDetailsRepository : DataLayer.GenericRepository<Entities.InventoryInsDetail>, RepositoryAbstracts.IInventoryInsDetailsRepository
    {
        public InventoryInsDetailsRepository():base("name=DbConnectionString"){}
       public List<Entities.InventoryInsDetail>GetByInventoryInsHeaderId(long value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsDetails] WHERE [InventoryInsHeaderId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsDetail>GetByProductId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsDetails] WHERE [ProductId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsDetail>GetByAmount(decimal value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsDetails] WHERE [Amount] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsDetail>GetByTotalPrice(decimal value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsDetails] WHERE [TotalPrice] = @Value", new SqlParameter("Value", value));
       }
    }
}
