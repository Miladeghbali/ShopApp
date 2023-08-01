using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface ICorporationsRepository : DataLayer.IRepository<Entities.Corporation>
    {
        List<Entities.Corporation>GetByID(int value);
        List<Entities.Corporation>GetByTitle(string value);
        List<Entities.Corporation>GetByDescription(string value);
        List<Entities.Corporation>GetByAddress(string value);
        List<Entities.Corporation>GetByTelephone(string value);
        List<Entities.Corporation>GetByFax(string value);
        List<Entities.Corporation>GetByDeleted(bool value);
        List<Entities.Corporation>GetByDeleteDate(DateTime? value);
        List<Entities.Corporation>GetByDeletedByUserId(long? value);
    }
}
