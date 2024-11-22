﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Infrastucture.Models.Categories;
using System.Web.Http;

namespace NetShop.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        protected readonly IProductService productService;
        protected readonly ICategoryService categoryService;
        private ILogger logger; 
        public AdminController(IProductService productService, ICategoryService categoryService, ILogger logger)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.logger = logger; 
        }

        #region MethodsOfProducts
        [Route("/[controller]/[action]")]
        public async Task<IEnumerable<GetProductDto>> GetAllProducts()
        {
            return(await productService.GetAll());
        }
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> GetProductById(Guid id)
        {
            return(await productService.GetById(id));
        }
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto>CreateProduct(CreateProductDto create)
        {
            var result = await productService.CreateProduct(create);
            return(result);
        }
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> UpdateProduct(Guid id,UpdateProductDto update)
        {
            var result = await productService.UpdateProduct(id,update);
            return(result);
        }
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> DeleteProduct(Guid id)
        {
            var result = await productService.DeleteProduct(id);
            return(result);
        }
        #endregion
        /// <summary>
        /// Swagger methods
        /// </summary>
        #region MethodsOfCategories
        [Route("/[controller]/[action]")]
        public async Task<IEnumerable<GetCategoryDto>> GetAllCategories()
        {
            return(await categoryService.GetAll());
        }
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> GetCategoryById(Guid id)
        {
            return (await categoryService.GetById(id));
        }
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> CreateCategory(CreateCategoryDto create)
        {
            var result = await categoryService.CreateCategory(create);
            return (result);
        }

        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> UpdateCategory(UpdateCategoryDto update)
        {
            var result = (await categoryService.UpdateCategory(update));
            return(result);
        }
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> DeleteCategory(Guid id) 
        {
            var result = await categoryService.DeleteCategory(id);
            return(result);
        }
        #endregion
    }
}
