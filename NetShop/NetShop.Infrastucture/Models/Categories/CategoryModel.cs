using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Models.Categories
{
    public class CategoryModel:BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
