using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Servicese.Interfaces
{
    public interface ICategoryService:IAbstractService<GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        Task<GetCategoryDto> GetById(Guid Id);
        Task<IEnumerable<GetCategoryDto>> GetAll();
        Task<GetCategoryDto> CreateCategory(CreateCategoryDto createCategoryDto);
        Task<GetCategoryDto> UpdateCategory(Guid id, UpdateCategoryDto updateCategoryDto);
        Task<GetCategoryDto> DeleteCategory(Guid Id);
    }
}
