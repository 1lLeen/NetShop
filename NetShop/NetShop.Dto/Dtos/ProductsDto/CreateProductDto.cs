using NetShop.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace NetShop.Dto.Dtos.ProductsDto;

public class CreateProductDto:BaseProductDto,ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}

