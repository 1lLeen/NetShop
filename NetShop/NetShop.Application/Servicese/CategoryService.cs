using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Models.Products;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using NetShop.Application.Servicese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Servicese
{
    public class CategoryService : AbstractService<ICategoryRepository, CategoryModel, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>,ICategoryService
    {
        public CategoryService(ILogger logger, IMapper mapper, ICategoryRepository repository) : base(logger, mapper, repository)
        {
        }
        public async Task<GetCategoryDto> GetById(Guid Id)
        {
            var category = await _repository.GetByIdAsync(Id);
            return mapper.Map<GetCategoryDto>(category);
        }
        public async Task<IEnumerable<GetCategoryDto>> GetAll()=>  mapper.Map<List<GetCategoryDto>>(await _repository.GetAllAsync());
        public async Task<GetCategoryDto> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = mapper.Map<CategoryModel>(createCategoryDto);
            var result = mapper.Map<GetCategoryDto>(await _repository.CreateAsync(category));
            return result;
        }
        public async Task<GetCategoryDto> UpdateCategory(Guid id, UpdateCategoryDto updateCategoryDto)
        {
            var category = await _repository.GetByIdAsync(id);
            if(category != null)
            {
                category.NameCategory = updateCategoryDto.NameCategory;
                category.UpdatedTime = DateTime.Now;
            }
            var result = mapper.Map<GetCategoryDto>(await _repository.UpdateAsync(category));
            return result;

        }
        public async Task<GetCategoryDto> DeleteCategory(Guid id)
        {
            var category = await _repository.GetByIdAsync(id);
            var result = mapper.Map<GetCategoryDto>(await _repository.DeleteAsync(category));
            return result;
        }
    }
}
