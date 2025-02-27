using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.CategoriesDto;

public class BaseCategoryDto:IBase
{
    public Guid Id { get; set; }
    public string NameCategory { get; set; }

}