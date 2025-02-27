using NetShop.Dto.Dtos.ProductsDto;

namespace NetShop.Application.Servicese.Interfaces;

public interface IProductService : IAbstractService<GetProductDto, CreateProductDto, UpdateProductDto>
{ 
    Task<IEnumerable<GetProductDto>> GetAllByCategoryAsync();
}