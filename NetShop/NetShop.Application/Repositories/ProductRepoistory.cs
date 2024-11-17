using NetShop.Application.Models.Products;
using NetShop.Application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Repositories
{
    public class ProductRepoistory:AbstractRepository<ProductModel>,IProductRepository
    {
        public ProductRepoistory(NetShopDbContext context) : base(context)
        {
        }
    }
}
