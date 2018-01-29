using ShopOnline.Service.ViewModels.Product;
using ShopOnline.Utilities.Dtos;
using System;
using System.Collections.Generic;

namespace ShopOnline.Service.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

    }
}