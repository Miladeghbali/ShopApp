using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer
{
    public interface IRepository<TEntity>
    {
        int Add(TEntity entity);
        int Remove(TEntity entity);
        int Update(TEntity entity);
        TEntity Find(params object[] keys);
        List<TEntity> All();
        int Count();

    }
}
