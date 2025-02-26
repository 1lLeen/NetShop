using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.ProductsDto;

public class CreateProductDto:BaseProductDto,ICreate
{
    public DateTime CreatedTime { get; set; }
}

