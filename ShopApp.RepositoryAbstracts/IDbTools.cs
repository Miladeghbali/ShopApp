using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.RepositoryAbstracts
{
    public interface IDbTools
    {
        Task<bool> CheckDbConnection();
        Task<bool> CheckDatabaseExists();
        Task<bool> CreateDatabase(string dbScript);
        void RefreshConnectionString();
   
    }
}
