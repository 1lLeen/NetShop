using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
namespace NetShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
        protected readonly IProductService productService;
        private ILogger logger;
        public ProductController(IProductService productService, ILogger logger)
        {
            this.productService = productService;
            this.logger = logger;
        }
 
        [HttpGet]
        public async Task<IEnumerable<GetProductDto>> GetAllProducts()
        {
            return (await productService.GetAll());
        }
        [HttpGet]
        public async Task<GetProductDto> GetProductById(Guid id)
        {
            return (await productService.GetById(id));
        }
        [HttpPost]
        public async Task<GetProductDto> CreateProduct(string name, string desc, string desc2, string urlImg, Guid idCategory)
        {
            var result = await productService.CreateProduct(new CreateProductDto
            {
                NameProduct = name,
                DescriptionProduct = desc,
                DescriptionProduct2 = desc2,
                UrlImg = urlImg,
                IdCategory = idCategory
            });
            return (result);
        }
        [HttpPut]
        public async Task<GetProductDto> UpdateProduct(Guid id, string name, string desc, string desc2, string urlImg, Guid idCategory)
        {
            var result = await productService.UpdateProduct(id, new UpdateProductDto
            {
                NameProduct = name,
                DescriptionProduct = desc,
                DescriptionProduct2 = desc2,
                UrlImg = urlImg,
                IdCategory = idCategory
            });
            return (result);
        }
        [HttpDelete]
        public async Task<GetProductDto> DeleteProduct(Guid id)
        {
            var result = await productService.DeleteProduct(id);
            return (result);
        }
    }
}
