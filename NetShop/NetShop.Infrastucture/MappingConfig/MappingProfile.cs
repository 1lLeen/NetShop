using AutoMapper;
using NetShop.Application.Models.Categories;
using NetShop.Application.Models.Products;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.ProductsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.MappingConfig
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductModel, GetProductDto>().ReverseMap();
            CreateMap<ProductModel, UpdateProductDto>();
            CreateMap<ProductModel, CreateProductDto>();

            CreateMap<CategoryModel, GetCategoryDto>().ReverseMap();
            CreateMap<CategoryModel, UpdateCategoryDto>();
            CreateMap<CategoryModel, CreateCategoryDto>();
        }
    }
}
