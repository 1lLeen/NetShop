using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Infrastucture.Models.Categories;
using System.Web;

namespace NetShop.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
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
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IEnumerable<GetProductDto>> GetAllProducts()
        {
            return(await productService.GetAll());
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> GetProductById(Guid id)
        {
            return(await productService.GetById(id));
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto>CreateProduct(string name, string desc, string desc2, string urlImg, Guid idCategory)
        {
            var result = await productService.CreateProduct(new CreateProductDto
            {
                NameProduct = name,
                DescriptionProduct = desc,
                DescriptionProduct2 = desc2,
                UrlImg = urlImg,
                IdCategory = idCategory
            });
            return(result);
        }
        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> UpdateProduct(Guid id, string name, string desc, string desc2, string urlImg, Guid idCategory)
        {
            var result = await productService.UpdateProduct(id,new UpdateProductDto
            {
                NameProduct = name,
                DescriptionProduct = desc,
                DescriptionProduct2 = desc2,
                UrlImg = urlImg,
                IdCategory = idCategory
            });
            return(result);
        }
        [HttpDelete]
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

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IEnumerable<GetCategoryDto>> GetAllCategories()
        {
            return(await categoryService.GetAll());
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> GetCategoryById(Guid id)
        {
            return (await categoryService.GetById(id));
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> CreateCategory(string name)
        {
            CreateCategoryDto create = new CreateCategoryDto();
            create.NameCategory = name;
            var result = await categoryService.CreateCategory(create);
            return (result);
        }
        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> UpdateCategory(Guid id, string name)
        {
            var update = new UpdateCategoryDto();
            update.NameCategory = name;
            var result = (await categoryService.UpdateCategory(update));
            return(result);
        }
        [HttpDelete]
        [Route("/[controller]/[action]")]
        public async Task<GetCategoryDto> DeleteCategory(Guid id) 
        {
            var result = await categoryService.DeleteCategory(id);
            return(result);
        }
        #endregion
    }
}
