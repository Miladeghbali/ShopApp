using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductCategoriesRepository : DataLayer.GenericRepository<Entities.ProductCategory>, RepositoryAbstracts.IProductCategoriesRepository
    {
        public ProductCategoriesRepository():base("name=DbConnectionString"){}
       public List<Entities.ProductCategory>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByInventoryId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [InventoryId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByParentCategoryId(int? value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [ParentCategoryId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByTitle(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByDescription(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByDeleted(bool value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByDeleteDate(DateTime? value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [DeleteDate] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductCategory>GetByDeletedByUserId(long? value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductCategories] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
       }
    }
}
