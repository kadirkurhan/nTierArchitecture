using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myApiProject.Entities.Concrete;
using myApiProject.Entities.Dtos.AppUserDtos;
using myApiProject.Entities.Dtos.ProductDtos;

namespace myApiProject.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();

            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();
        }
    }
}
