using NetShop.Dto.Dtos.Interfaces;

namespace NetShop.Dto.Dtos.ProductsDto;

public class UpdateProductDto:BaseProductDto, IUpdate
{
    public DateTime UpdatedTime { get; set; }
}

