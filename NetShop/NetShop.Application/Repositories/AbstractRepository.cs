﻿using Microsoft.EntityFrameworkCore;
using NetShop.Application.Models;
using NetShop.Application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Application.Repositories
{
    public abstract class AbstractRepository<TModel> : IAbstractRepository<TModel> where TModel : BaseModel
    {
        protected NetShopDbContext _context;
        protected DbSet<TModel> _dbSet;
        public AbstractRepository(NetShopDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<TModel>();
        }
        public async Task<TModel> CreateAsync(TModel model)
        {
            model.Id = Guid.NewGuid();
            model.CreatedTime = DateTime.Now;
            model.UpdateTime = DateTime.Now;
            await _dbSet.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<TModel> DeleteAsync(TModel model)
        {
            model.IsDeleted = true;
            model.UpdateTime = DateTime.UtcNow.ToUniversalTime();
            _dbSet.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<TModel> GetByIdAsync(Guid id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TModel> UpdateAsync(TModel model)
        {
            model.UpdateTime = DateTime.UtcNow;
            var entry = _context.Entry(model);
            entry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
