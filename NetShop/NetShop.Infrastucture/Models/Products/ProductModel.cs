using NetShop.Infrastucture.Models.Categories;

namespace NetShop.Infrastucture.Models.Products;

public class ProductModel:BaseModel
{
    public string NameProduct { get; set; }
    public string? DescriptionProduct { get; set; }
    public string? DescriptionProduct2 { get; set; }
    public string? UrlImg { get; set; }
    public Guid? CategoryId { get; set; }

}
