using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.ProductsDto;

public class BaseProductDto:IBase
{
    public Guid Id { get; set; }
    public string NameProduct { get; set; }
    public string DescriptionProduct { get; set; }
    public string DescriptionProduct2 { get; set; }
    public string UrlImg { get; set; }
    public BaseCategoryDto CategoryDto { get; set; }

}