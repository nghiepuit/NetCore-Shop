using ShopOnline.Data.Entities;
using ShopOnline.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace ShopOnline.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}