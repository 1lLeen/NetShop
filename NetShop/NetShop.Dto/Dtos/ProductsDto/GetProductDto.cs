using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.ProductsDto;

public class GetProductDto:BaseProductDto,IGet
{
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTIme { get;set; }
}
