using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductsRepository : DataLayer.IRepository<Entities.Product>
    {
        List<Entities.Product>GetByID(int value);
        List<Entities.Product>GetByProductCategoryId(int value);
        List<Entities.Product>GetByProductUnitId(int value);
        List<Entities.Product>GetByCode(string value);
        List<Entities.Product>GetByTitle(string value);
        List<Entities.Product>GetByDescription(string value);
        List<Entities.Product>GetByDeleted(bool value);
        List<Entities.Product>GetByDeleteDate(DateTime? value);
        List<Entities.Product>GetByDeletedByUserId(long? value);
    }
}
