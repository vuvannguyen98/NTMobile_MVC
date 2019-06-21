using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebNTMobileApp.Application.ViewModels.Product;
using WebNTMobileApp.Data.Entities;

namespace WebNTMobileApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();


        }
    }
}
