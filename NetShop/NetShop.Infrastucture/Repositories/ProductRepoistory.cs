using NetShop.Infrastucture.Models.Products;
using NetShop.Infrastucture.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Repositories
{
    public class ProductRepoistory:AbstractRepository<ProductModel>,IProductRepository
    {
        public ProductRepoistory(NetShopDbContext context) : base(context)
        {
        }
    }
}
