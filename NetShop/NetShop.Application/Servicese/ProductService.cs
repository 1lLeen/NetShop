using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Infrastucture.Models.Products;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Infrastucture.Models.Categories;

namespace NetShop.Application.Servicese;

public class ProductService: AbstractService<IProductRepository, ProductModel, GetProductDto, CreateProductDto, UpdateProductDto>,IProductService
{
    public ProductService(ILogger logger, IMapper mapper, IProductRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<GetProductDto> UpdateProductAsync(Guid idProduct, UpdateProductDto update)
    {
        var model = await _repository.GetByIdAsync(idProduct);
        
        model.NameProduct = update.NameProduct;
        model.DescriptionProduct = update.DescriptionProduct;
        model.DescriptionProduct2 = update.DescriptionProduct2;
        model.Category = mapper.Map<CategoryModel>(update.CategoryDto);
        model.UrlImg = update.UrlImg;

        var result = await _repository.UpdateAsync(model);
        return mapper.Map<GetProductDto>(result);
    }

    public async Task<IEnumerable<GetProductDto>> GetAllByCategoryAsync() => mapper.Map<IEnumerable<GetProductDto>>(await _repository.GetProductsByCategoryAsync());
}
