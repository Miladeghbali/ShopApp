using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoryOutsDetailsRepository : DataLayer.IRepository<Entities.InventoryOutsDetail>
    {
        List<Entities.InventoryOutsDetail>GetByInventoryOutsHeaderId(long value);
        List<Entities.InventoryOutsDetail>GetByProductId(int value);
        List<Entities.InventoryOutsDetail>GetByAmount(decimal value);
        List<Entities.InventoryOutsDetail>GetByTotalPrice(decimal value);
    }
}
