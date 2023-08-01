using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoriesRepository : DataLayer.IRepository<Entities.Inventory>
    {
        List<Entities.Inventory>GetByID(int value);
        List<Entities.Inventory>GetByCorporationsId(int value);
        List<Entities.Inventory>GetByTitle(string value);
        List<Entities.Inventory>GetByDescription(string value);
        List<Entities.Inventory>GetByDeleted(bool value);
        List<Entities.Inventory>GetByDeleteDate(DateTime? value);
        List<Entities.Inventory>GetByDeletedByUserId(long? value);
    }
}
