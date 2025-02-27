using Microsoft.AspNetCore.Mvc; 
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;

namespace NetShop.ApiServer.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductController : ControllerBase
{
    protected readonly IProductService productService;
    private ILogger logger;

    public ProductController(IProductService productService, ILogger logger)
    {
        this.productService = productService;
        this.logger = logger;
    }

    [HttpGet] 
    public async Task<IEnumerable<GetProductDto>> GetAllProductsAsync()
    {
        return await productService.GetAllAsync();
    }

    [HttpGet] 
    public async Task<IEnumerable<GetProductDto>> GetProductsByCategoryAsync(Guid idCategory)
    {
        return await productService.GetAllByCategoryAsync();
    }
    [HttpGet] 
    public async Task<GetProductDto> GetProductByIdAsync(Guid id)
    {
        return await productService.GetByIdAsync(id);
    }

    [HttpPost] 
    public async Task<GetProductDto> CreateProductAsync(CreateProductDto create)
    { 
        return await productService.CreateAsync(create);
    }

    [HttpPut] 
    public async Task<GetProductDto> UpdateProductAsync(Guid id, UpdateProductDto update)
    { 
        return await productService.UpdateProductAsync(id, update);
    }

    [HttpDelete] 
    public async Task<GetProductDto> DeleteProductAsync(Guid id)
    {
        return await productService.DeleteAsync(id);
    }
}

