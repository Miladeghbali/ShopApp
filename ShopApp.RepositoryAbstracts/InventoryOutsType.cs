using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoryOutsTypesRepository : DataLayer.IRepository<Entities.InventoryOutsType>
    {
        List<Entities.InventoryOutsType>GetByID(int value);
        List<Entities.InventoryOutsType>GetByTitle(string value);
        List<Entities.InventoryOutsType>GetByDescription(string value);
        List<Entities.InventoryOutsType>GetByDeleted(bool value);
        List<Entities.InventoryOutsType>GetByDeleteDate(DateTime? value);
        List<Entities.InventoryOutsType>GetByDeletedByUserId(long? value);
    }
}
