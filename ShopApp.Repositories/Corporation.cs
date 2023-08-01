using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class CorporationsRepository : DataLayer.GenericRepository<Entities.Corporation>, RepositoryAbstracts.ICorporationsRepository
    {
        public CorporationsRepository():base("name=DbConnectionString"){}
       public List<Entities.Corporation>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByAddress(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Address] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByTelephone(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Telephone] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByFax(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Fax] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Corporation>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Corporations] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
