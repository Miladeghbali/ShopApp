using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductParametersValuesRepository : DataLayer.GenericRepository<Entities.ProductParametersValue>, RepositoryAbstracts.IProductParametersValuesRepository
    {
        public ProductParametersValuesRepository():base("name=DbConnectionString"){}
       public List<Entities.ProductParametersValue>GetByProductId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductParametersValues] WHERE [ProductId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductParametersValue>GetByProductParameterId(int value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductParametersValues] WHERE [ProductParameterId] = @Value", new SqlParameter("Value", value));
       }
       public List<Entities.ProductParametersValue>GetByValue(string value)
       {
         return RunQuery("SELECT * FROM[dbo].[ProductParametersValues] WHERE [Value] LIKE @Value", new SqlParameter("Value", value));
       }
    }
}
