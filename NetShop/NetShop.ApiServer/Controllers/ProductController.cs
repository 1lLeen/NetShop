using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;

namespace NetShop.ApiServer.Controllers;

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
        return await productService.GetAllAsync();
    }

    [HttpGet]
    [Route("/[controller]/[action]")]
    public async Task<IEnumerable<GetProductDto>> GetProductsByCategory(int idCategory)
    {
        return await productService.
    }
    [HttpGet]
    [Route("/[controller]/[action]")]
    public async Task<GetProductDto> GetProductById(Guid id)
    {
        return await productService.GetByIdAsync(id);
    }

    [HttpPost]
    [Route("/[controller]/[action]")]
    public async Task<GetProductDto> CreateProduct(CreateProductDto create)
    {
        var result = await productService.CreateAsync(new CreateProductDto
        {
            NameProduct = create.NameProduct,
            DescriptionProduct = create.DescriptionProduct,
            DescriptionProduct2 = create.DescriptionProduct2,
            UrlImg = create.UrlImg,
            CategoryDto = create.CategoryDto,
        });
        return(result);
    }

    [HttpPut]
    [Route("/[controller]/[action]")]
    public async Task<GetProductDto> UpdateProduct(Guid id, UpdateProductDto update)
    {
        var result = await productService.UpdateAsync(id, new UpdateProductDto
        {
            NameProduct = update.NameProduct,
            DescriptionProduct = update.DescriptionProduct,
            DescriptionProduct2 = update.DescriptionProduct2,
            UrlImg = update.UrlImg,
            CategoryDto = update.CategoryDto
        });
        return(result);
    }

    [HttpDelete]
    [Route("/[controller]/[action]")]
    public async Task<GetProductDto> DeleteProduct(Guid id)
    {
        var result = await productService.DeleteAsync(id);
        return result;
    }
}

