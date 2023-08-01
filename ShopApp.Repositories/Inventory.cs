using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoriesRepository : DataLayer.GenericRepository<Entities.Inventory>, RepositoryAbstracts.IInventoriesRepository
    {
        public InventoriesRepository():base("name=DbConnectionString"){}
       public List<Entities.Inventory>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByCorporationsId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [CorporationsId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Inventory>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Inventories] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
