using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Application.Servicese.Interfaces;

namespace NetShop.Application.Servicese;

public class CategoryService : 
    AbstractService<ICategoryRepository, CategoryModel, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>,ICategoryService
{
    public CategoryService(ILogger logger, IMapper mapper, ICategoryRepository repository) : base(logger, mapper, repository)
    {
    }
    public async Task<GetCategoryDto> UpdateCategoryAsync(Guid idCategory, UpdateCategoryDto category)
    {
        var model = await _repository.GetByIdAsync(idCategory);

        model.NameCategory = category.NameCategory;
        
        var result = mapper.Map<GetCategoryDto>(await _repository.UpdateAsync(model));
        return result;
    }
}
