using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.CategoriesDto;

public class GetCategoryDto:BaseCategoryDto, IGet
{
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
}