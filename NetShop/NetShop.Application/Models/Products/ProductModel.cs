using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Models.Products
{
    public class ProductModel:BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public Guid CategoryId { get; set; }

    }
}
