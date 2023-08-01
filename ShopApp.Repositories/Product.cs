using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductsRepository : DataLayer.GenericRepository<Entities.Product>, RepositoryAbstracts.IProductsRepository
    {
        public ProductsRepository():base("name=DbConnectionString"){}
       public List<Entities.Product>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByProductCategoryId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [ProductCategoryId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByProductUnitId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [ProductUnitId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByCode(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [Code] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.Product>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[Products] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
