using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Dto.Dtos.ProductsDto
{
    public class CreateProductDto:BaseProductDto,ICreate
    {
        public DateTime CreatedTime { get; set; }
    }
}
