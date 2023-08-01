using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryOutsTypesRepository : DataLayer.GenericRepository<Entities.InventoryOutsType>, RepositoryAbstracts.IInventoryOutsTypesRepository
    {
        public InventoryOutsTypesRepository():base("name=DbConnectionString"){}
       public List<Entities.InventoryOutsType>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsType>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsType>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsType>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsType>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsType>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsTypes] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
