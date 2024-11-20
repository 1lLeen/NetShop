using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Application.Models.Products;
using NetShop.Application.Repositories.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Infrastucture.Servicese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese
{
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
        public async Task<List<GetProductDto>> GetAll() => mapper.Map<List<GetProductDto>>(await _repository.GetAllAsync());
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
                product.Name = updateProductDto.NameProduct;
                product.Description = updateProductDto.DescriptionProduct;
                product.Description2 = updateProductDto.DescriptionProduct2;
                product.CategoryId = updateProductDto.IdCategory;
                product.UpdateTime = DateTime.Now;
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
}
