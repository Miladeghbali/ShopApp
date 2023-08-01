using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryInsHeadersRepository : DataLayer.GenericRepository<Entities.InventoryInsHeader>, RepositoryAbstracts.IInventoryInsHeadersRepository
    {
        public InventoryInsHeadersRepository():base("name=DbConnectionString"){}
       public List<Entities.InventoryInsHeader>GetByID(long value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByInventoryId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [InventoryId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByTypeId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [TypeId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByDate(DateTime value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [Date] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByAccepted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [Accepted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByAcceptedDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [AcceptedDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByAcceptedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [AcceptedByUserId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryInsHeader>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryInsHeaders] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
