using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductParametersValuesRepository : DataLayer.IRepository<Entities.ProductParametersValue>
    {
        List<Entities.ProductParametersValue>GetByProductId(int value);
        List<Entities.ProductParametersValue>GetByProductParameterId(int value);
        List<Entities.ProductParametersValue>GetByValue(string value);
    }
}
