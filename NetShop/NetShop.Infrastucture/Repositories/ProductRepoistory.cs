using Microsoft.EntityFrameworkCore;
using NetShop.Infrastucture.Models.Products;
using NetShop.Infrastucture.Repositories.Interfaces;

namespace NetShop.Infrastucture.Repositories;

public class ProductRepoistory:AbstractRepository<ProductModel>,IProductRepository
{
    public ProductRepoistory(NetShopDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<ProductModel>> GetProductsByCategoryAsync() => await _context.Products.Include(p => p.CategoryId).ToListAsync();
}
