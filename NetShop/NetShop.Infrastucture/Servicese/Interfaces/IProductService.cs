using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.ProductsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese.Interfaces
{
    public interface IProductService : IAbstractService<GetProductDto, CreateProductDto, UpdateProductDto>
    {
        Task<GetProductDto> GetById(Guid Id);
        Task<List<GetProductDto>> GetAll();
        Task<GetProductDto> CreateProduct(CreateProductDto createProductDto);
        Task<GetProductDto> UpdateProduct(UpdateProductDto updateProductDto);
        Task<GetProductDto> DeleteProduct(Guid Id);
    }
}
