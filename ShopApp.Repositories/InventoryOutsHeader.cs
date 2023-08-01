using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryOutsHeadersRepository : DataLayer.GenericRepository<Entities.InventoryOutsHeader>, RepositoryAbstracts.IInventoryOutsHeadersRepository
    {
        public InventoryOutsHeadersRepository():base("name=DbConnectionString"){}
       public List<Entities.InventoryOutsHeader>GetByID(long value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByInventoryId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [InventoryId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByTypeId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [TypeId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByDate(DateTime value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [Date] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByAccepted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [Accepted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByAcceptedDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [AcceptedDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByAcceptedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [AcceptedByUserId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.InventoryOutsHeader>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[InventoryOutsHeaders] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
