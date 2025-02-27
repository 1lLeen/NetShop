using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.CategoriesDto;

public class CreateCategoryDto:BaseCategoryDto,ICreate
{
    public DateTime CreatedTime { get; set; }
}