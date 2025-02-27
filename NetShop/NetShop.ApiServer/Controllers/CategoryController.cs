using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;

namespace NetShop.ApiServer.Controllers;

[ApiController]
[Route("/[controller]/[action]")]
public class CategoryController : ControllerBase
{
    protected readonly ICategoryService categoryService;
    private ILogger logger;
 
    public CategoryController(ICategoryService categoryService, ILogger logger)
    {
        this.categoryService = categoryService;
        this.logger = logger;
    }

    [HttpGet] 
    public async Task<IEnumerable<GetCategoryDto>> GetAllCategoriesAsync()
    {
        return await categoryService.GetAllAsync();
    }

    [HttpGet] 
    public async Task<GetCategoryDto> GetCategoryByIdAsync(Guid id)
    {
        return await categoryService.GetByIdAsync(id);
    }

    [HttpPost] 
    public async Task<GetCategoryDto> CreateCategoryAsync(CreateCategoryDto create)
    {  
        return await categoryService.CreateAsync(create);
    }

    [HttpPut] 
    public async Task<GetCategoryDto> UpdateCategoryAsync(Guid id, UpdateCategoryDto update)
    {  
        return await categoryService.UpdateCategoryAsync(id, update);
    }

    [HttpDelete] 
    public async Task<GetCategoryDto> DeleteCategoryAsync(Guid id)
    { 
        return await categoryService.DeleteAsync(id);
    }
}

