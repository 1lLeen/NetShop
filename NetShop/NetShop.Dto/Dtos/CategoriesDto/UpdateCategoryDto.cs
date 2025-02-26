using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.CategoriesDto;

public class UpdateCategoryDto:BaseCategoryDto, IUpdate
{
    public DateTime UpdatedTime { get; set; }
}

