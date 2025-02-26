using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;

namespace NetShop.ApiServer.Controllers;

[ApiController]
[Route("/[controller]/[action]")]
public class CategoryController : Controller
{

    protected readonly ICategoryService categoryService;
    private ILogger logger;
    public CategoryController(ICategoryService categoryService, ILogger logger)
    {
        this.categoryService = categoryService;
        this.logger = logger;
    }
    [HttpGet]
    [Route("/[controller]/[action]")]
    public async Task<IEnumerable<GetCategoryDto>> GetAllCategories()
    {
        return (await categoryService.GetAll());
    }
    [HttpGet]
    [Route("/[controller]/[action]")]
    public async Task<GetCategoryDto> GetCategoryById(Guid id)
    {
        return (await categoryService.GetById(id));
    }
    [HttpPost]
    [Route("/[controller]/[action]/{name}")]
    public async Task<GetCategoryDto> CreateCategory(string name)
    {
        CreateCategoryDto create = new CreateCategoryDto();
        create.NameCategory = name;
        var result = await categoryService.CreateCategory(create);
        return (result);
    }
    [HttpPut]
    [Route("/[controller]/[action]/{id}/{name}")]
    public async Task<GetCategoryDto> UpdateCategory(Guid id, UpdateCategoryDto update)
    {
        var updateNew = new UpdateCategoryDto();
        update.NameCategory = update.NameCategory;
        var result = (await categoryService.UpdateCategory(id, updateNew));
        return (result);
    }
    [HttpDelete]
    [Route("/[controller]/[action]/{id}")]
    public async Task<GetCategoryDto> DeleteCategory(Guid id)
    {
        var result = await categoryService.DeleteCategory(id);
        return (result);
    }
}

