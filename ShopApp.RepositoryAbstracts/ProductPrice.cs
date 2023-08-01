using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductPricesRepository : DataLayer.IRepository<Entities.ProductPrice>
    {
        List<Entities.ProductPrice>GetByID(int value);
        List<Entities.ProductPrice>GetByProductId(int value);
        List<Entities.ProductPrice>GetByDate(DateTime value);
        List<Entities.ProductPrice>GetByPrice(decimal value);
    }
}
