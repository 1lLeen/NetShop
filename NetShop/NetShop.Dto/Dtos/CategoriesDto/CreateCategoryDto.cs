using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Dto.Dtos.CategoriesDto
{
    public class CreateCategoryDto:BaseCategoryDto,ICreate
    {
        public DateTime CreatedTime { get; set; }

    }
}
