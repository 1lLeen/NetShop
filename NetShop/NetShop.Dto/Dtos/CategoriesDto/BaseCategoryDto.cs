using NetShop.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace NetShop.Dto.Dtos.CategoriesDto;

public class BaseCategoryDto:IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public Guid Id { get; set; }
    public string NameCategory { get; set; }

}