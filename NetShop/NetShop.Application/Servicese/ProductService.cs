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
    public async Task<GetProductDto> GetById(Guid Id)
    {
        var product = await _repository.GetByIdAsync(Id);
        return mapper.Map<GetProductDto>(product);
    }
    public async Task<IEnumerable<GetProductDto>> GetAll() => mapper.Map<List<GetProductDto>>(await _repository.GetAllAsync());
    public async Task<GetProductDto> CreateProduct(CreateProductDto createProductDto)
    {
        var product = mapper.Map<ProductModel>(createProductDto);
        var result = mapper.Map<GetProductDto>(await _repository.CreateAsync(product));
        return result;
    }
    public async Task<GetProductDto> UpdateProduct(Guid id, UpdateProductDto updateProductDto)
    {
        var product = await _repository.GetByIdAsync(id);
        if (product != null)
        {
            product.NameProduct = updateProductDto.NameProduct;
            product.DescriptionProduct = updateProductDto.DescriptionProduct;
            product.DescriptionProduct2 = updateProductDto.DescriptionProduct2;
            product.UrlImg = updateProductDto.UrlImg;
            product.Category = mapper.Map<CategoryModel>(updateProductDto.CategoryDto);
            product.UpdatedTime = DateTime.Now;
        }
        var result = mapper.Map<GetProductDto>(await _repository.UpdateAsync(product));
        return result;

    }
    public async Task<GetProductDto> DeleteProduct(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        var result = mapper.Map<GetProductDto>(await _repository.DeleteAsync(product));
        return result;
    }

        
}
