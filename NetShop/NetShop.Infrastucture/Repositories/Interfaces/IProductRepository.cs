using NetShop.Infrastucture.Models.Products;

namespace NetShop.Infrastucture.Repositories.Interfaces;

public interface IProductRepository:IAbstractRepository<ProductModel>
{
    Task<IEnumerable<ProductModel>> GetProductsByCategoryAsync();
}
