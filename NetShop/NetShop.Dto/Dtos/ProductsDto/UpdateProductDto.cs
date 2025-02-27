using NetShop.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace NetShop.Dto.Dtos.ProductsDto;

public class UpdateProductDto:BaseProductDto, IUpdate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}

