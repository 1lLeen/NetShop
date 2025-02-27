using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Infrastucture.Models.Products;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Application.Servicese.Interfaces; 

namespace NetShop.Application.Servicese;

public class ProductService: AbstractService<IProductRepository, ProductModel, GetProductDto, CreateProductDto, UpdateProductDto>,IProductService
{
    public ProductService(ILogger logger, IMapper mapper, IProductRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<IEnumerable<GetProductDto>> GetAllByCategoryAsync() => mapper.Map<IEnumerable<GetProductDto>>(await _repository.GetProductsByCategoryAsync());
}
