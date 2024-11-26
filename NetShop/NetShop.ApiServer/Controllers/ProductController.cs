using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;

namespace NetShop.ApiServer.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class ProductController : Controller
    {
        protected readonly IProductService productService;
        private ILogger logger;
        public ProductController(IProductService productService, ILogger logger)
        {
            this.productService = productService;
            this.logger = logger;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IEnumerable<GetProductDto>> GetAllProducts()
        {
            return (await productService.GetAll());
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> GetProductById(Guid id)
        {
            return (await productService.GetById(id));
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
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
        [Route("/[controller]/[action]")]
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
        [Route("/[controller]/[action]")]
        public async Task<GetProductDto> DeleteProduct(Guid id)
        {
            var result = await productService.DeleteProduct(id);
            return (result);
        }
    }
}
