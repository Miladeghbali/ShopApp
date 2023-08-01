using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class UsersRepository : DataLayer.GenericRepository<Entities.User>, RepositoryAbstracts.IUsersRepository
    {
        public UsersRepository():base("name=DbConnectionString"){}
       public List<Entities.User>GetByID(long value)
       {
         return RunQuery("SELECT * FROM[dbo].[Users] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.User>GetByUsername(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Users] WHERE [Username] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.User>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[Users] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.User>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Users] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.User>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Users] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
