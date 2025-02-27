using NetShop.Dto.Dtos.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace NetShop.Dto.Dtos.ProductsDto;

public class GetProductDto:BaseProductDto,IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTIme { get;set; }
}
