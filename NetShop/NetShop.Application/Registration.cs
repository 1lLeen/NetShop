using Microsoft.Extensions.DependencyInjection;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Infrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Application.Servicese;

namespace NetShop.Application.MappingConfig
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
