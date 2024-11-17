using Microsoft.EntityFrameworkCore;
using NetShop.Application.ModelConfiguration;
using NetShop.Application.Models.Categories;
using NetShop.Application.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application
{
    public class NetShopDbContext:DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public NetShopDbContext(DbContextOptions<NetShopDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>();
            modelBuilder.Entity<CategoryModel>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BaseConfiguration<ProductModel>());
        }
    }
}
