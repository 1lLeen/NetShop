using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Dto.Dtos.ProductsDto
{
    public class BaseProductDto:IBase
    {
        public Guid Id { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string DescriptionProduct2 { get; set; }
        public string UrlImg { get; set; }
        public Guid IdCategory { get; set; }

    }
}
