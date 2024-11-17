using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Dto.Dtos.CategoriesDto
{
    public class UpdateCategoryDto:BaseCategoryDto, IUpdate
    {
        public DateTime UpdatedTime { get; set; }
    }
}
