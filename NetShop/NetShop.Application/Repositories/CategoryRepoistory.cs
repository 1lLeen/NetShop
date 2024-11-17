using NetShop.Application.Models.Categories;
using NetShop.Application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Repositories
{
    public class CategoryRepoistory:AbstractRepository<CategoryModel>, ICategoryRepository
    {
        public CategoryRepoistory(NetShopDbContext context) : base(context) { }
    }
}
