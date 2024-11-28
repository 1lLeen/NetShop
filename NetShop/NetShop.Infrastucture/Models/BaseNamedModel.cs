using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Models
{
    public class BaseNamedModel:BaseModel
    {
        public string Name { get; set; }
    }
}
