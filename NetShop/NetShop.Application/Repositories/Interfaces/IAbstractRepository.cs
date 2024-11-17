﻿using NetShop.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Repositories.Interfaces
{
    public interface IAbstractRepository<TModel> where TModel : BaseModel
    {
        Task<TModel> CreateAsync(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task<TModel> DeleteAsync(TModel model);
        Task<TModel> GetByIdAsync(Guid id);
        Task<IEnumerable<TModel>> GetAllAsync();

    }
}
