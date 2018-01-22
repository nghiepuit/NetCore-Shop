using AutoMapper;
using ShopOnline.Data.Entities;
using ShopOnline.Service.ViewModels.Product;

namespace ShopOnline.Service.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}