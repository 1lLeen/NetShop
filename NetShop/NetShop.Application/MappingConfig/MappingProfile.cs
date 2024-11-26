using AutoMapper;
using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Models.Products;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.ProductsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.MappingConfig
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductModel, GetProductDto>().ReverseMap();
            CreateMap<ProductModel, CreateProductDto>().ReverseMap();
            CreateMap<ProductModel, UpdateProductDto>().ReverseMap();
            CreateMap<ProductModel, GetProductDto>();
            CreateMap<ProductModel, CreateProductDto>();
            CreateMap<ProductModel, UpdateProductDto>();

            CreateMap<CategoryModel, GetCategoryDto>().ReverseMap();
            CreateMap<CategoryModel, CreateCategoryDto>().ReverseMap();
            CreateMap<CategoryModel, UpdateCategoryDto>().ReverseMap();
            CreateMap<CategoryModel, GetCategoryDto>();
            CreateMap<CategoryModel, CreateCategoryDto>();
            CreateMap<CategoryModel, UpdateCategoryDto>();
        }
    }
}
