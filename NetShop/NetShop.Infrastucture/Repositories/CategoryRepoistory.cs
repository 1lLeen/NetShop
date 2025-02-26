using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Repositories.Interfaces;

namespace NetShop.Infrastucture.Repositories;

public class CategoryRepoistory:AbstractRepository<CategoryModel>, ICategoryRepository
{
    public CategoryRepoistory(NetShopDbContext context) : base(context) { }
}
