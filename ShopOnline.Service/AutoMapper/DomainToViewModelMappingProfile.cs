using AutoMapper;
using ShopOnline.Data.Entities;
using ShopOnline.Service.ViewModels.Product;
using ShopOnline.Service.ViewModels.System;

namespace ShopOnline.Service.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}