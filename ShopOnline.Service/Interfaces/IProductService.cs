using ShopOnline.Service.ViewModels.Product;
using System;
using System.Collections.Generic;

namespace ShopOnline.Service.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}