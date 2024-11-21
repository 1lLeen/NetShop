using Microsoft.Extensions.DependencyInjection;
using NetShop.Application.Repositories.Interfaces;
using NetShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetShop.Infrastucture.Servicese.Interfaces;
using NetShop.Infrastucture.Servicese;

namespace NetShop.Infrastucture.MappingConfig
{
    public static class Registration
    {
        public static void RegistrationRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepoistory>();
            services.AddScoped<IProductRepository, ProductRepoistory>();

        }
        public static void RegistrationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
