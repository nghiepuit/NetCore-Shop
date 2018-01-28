using AutoMapper.QueryableExtensions;
using ShopOnline.Data.IRepositories;
using ShopOnline.Service.Interfaces;
using ShopOnline.Service.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopOnline.Service.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }
    }
}