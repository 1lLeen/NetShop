using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;

namespace NetShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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
        public async Task<IEnumerable<GetCategoryDto>> GetAllCategories()
        {
            return (await categoryService.GetAll());
        }
        [HttpGet]
        public async Task<GetCategoryDto> GetCategoryById(Guid id)
        {
            return (await categoryService.GetById(id));
        }
        [HttpPost]
        public async Task<GetCategoryDto> CreateCategory(string name)
        {
            CreateCategoryDto create = new CreateCategoryDto();
            create.NameCategory = name;
            var result = await categoryService.CreateCategory(create);
            return (result);
        }
        [HttpPut]
        public async Task<GetCategoryDto> UpdateCategory(Guid id, string name)
        {
            var update = new UpdateCategoryDto();
            update.NameCategory = name;
            var result = (await categoryService.UpdateCategory(update));
            return (result);
        }
        [HttpDelete]
        public async Task<GetCategoryDto> DeleteCategory(Guid id)
        {
            var result = await categoryService.DeleteCategory(id);
            return (result);
        }
    }
}
