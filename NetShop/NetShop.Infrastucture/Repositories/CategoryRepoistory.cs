using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Repositories
{
    public class CategoryRepoistory:AbstractRepository<CategoryModel>, ICategoryRepository
    {
        public CategoryRepoistory(NetShopDbContext context) : base(context) { }
    }
}
