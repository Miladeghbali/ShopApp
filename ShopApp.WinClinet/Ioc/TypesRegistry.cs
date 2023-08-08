using ShopApp.Repositories;
using ShopApp.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.WinClinet.Ioc
{
    class TypesRegistry:StructureMap.Registry
    {
        public TypesRegistry()
        {
            For<IProductParametersValuesRepository>().Use<ProductParametersValuesRepository>();
            For<IProductsRepository>().Use<ProductsRepository>();
            For<IProductParametersRepository>().Use<ProductParametersRepository>();
            For<IProductCategoriesRepository>().Use<ProductCategoriesRepository>();
            For<IProductUnitsRepository>().Use<ProductUnitsRepository>();
            For<IInventoriesRepository>().Use<InventoriesRepository>();
            For<ICorporationsRepository>().Use<CorporationsRepository>();
            For<IUsersRepository>().Use<UsersRepository>();
            For<IFinancialYearsRepository>().Use<FinancialYearsRepository>();
            For<IDbTools>().Use<SqlDbTools>();
        }

    }
}
