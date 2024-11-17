using Microsoft.Extensions.DependencyInjection;
using NetShop.Application.Repositories;
using NetShop.Application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application
{
    public static class RepositoryRegistration
    {
        public static void RegisterRepositories(this IServiceCollection services) 
        {
            services.AddScoped<ICategoryRepository, CategoryRepoistory>();
            services.AddScoped<IProductRepository, ProductRepoistory>();

        }

    }
}
