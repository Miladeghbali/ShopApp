using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoryInsDetailsRepository : DataLayer.IRepository<Entities.InventoryInsDetail>
    {
        List<Entities.InventoryInsDetail>GetByInventoryInsHeaderId(long value);
        List<Entities.InventoryInsDetail>GetByProductId(int value);
        List<Entities.InventoryInsDetail>GetByAmount(decimal value);
        List<Entities.InventoryInsDetail>GetByTotalPrice(decimal value);
    }
}
