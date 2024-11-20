using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese.Interfaces
{
    public interface ICategoryServices:IAbstractService<GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        Task<GetCategoryDto> GetById(Guid Id);
        Task<List<GetCategoryDto>> GetAll();
        Task<GetCategoryDto> Create(CreateCategoryDto CreateCategoryDto);
        Task<GetCategoryDto> Update(UpdateCategoryDto UpdateCategoryDto);
        Task<GetCategoryDto> DeleteById(Guid Id);
    }
}
