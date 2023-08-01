using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductUnitsRepository : DataLayer.IRepository<Entities.ProductUnit>
    {
        List<Entities.ProductUnit>GetByID(int value);
        List<Entities.ProductUnit>GetByTitle(string value);
        List<Entities.ProductUnit>GetByDescription(string value);
        List<Entities.ProductUnit>GetByDeleted(bool value);
        List<Entities.ProductUnit>GetByDeleteDate(DateTime? value);
        List<Entities.ProductUnit>GetByDeletedByUserId(long? value);
    }
}
