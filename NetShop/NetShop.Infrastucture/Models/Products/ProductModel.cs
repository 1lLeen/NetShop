using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Models.Products
{
    public class ProductModel:BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UrlImg { get; set; }
        public Guid CategoryId { get; set; }

    }
}
