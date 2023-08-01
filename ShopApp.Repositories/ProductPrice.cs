using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductPricesRepository : DataLayer.GenericRepository<Entities.ProductPrice>, RepositoryAbstracts.IProductPricesRepository
    {
        public ProductPricesRepository():base("name=DbConnectionString"){}
       public List<Entities.ProductPrice>GetByID(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductPrices] WHERE [ID] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductPrice>GetByProductId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductPrices] WHERE [ProductId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductPrice>GetByDate(DateTime value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductPrices] WHERE [Date] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductPrice>GetByPrice(decimal value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductPrices] WHERE [Price] = @Value", new SqlParameter("Value", value));
       }
    }
}
