﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Application.Models;
using NetShop.Application.Repositories.Interfaces;
using NetShop.Dto.Dtos.Interfaces;
using NetShop.Infrastucture.Servicese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese
{
    public class AbstractService<TRepository,TModel,TGet,TCreate,TUpdate>
        where TRepository : IAbstractRepository<TModel>
        where TModel : BaseModel
        where TGet : IGet
        where TCreate : ICreate
        where TUpdate : IUpdate
    {
        protected readonly TRepository _repository;
        protected readonly ILogger logger;
        protected readonly IMapper mapper;
        public AbstractService(ILogger logger, IMapper mapper, TRepository repository)
        {
            _repository = repository;
            this.logger = logger;
            this.mapper = mapper;
        }
        public async Task<TGet> GetById(Guid Id)
        {
            var model = await _repository.GetByIdAsync(Id);
            return mapper.Map<TGet>(model);
        }
        public async Task<List<TGet>> GetAll()
        {
            var list = await _repository.GetAllAsync();
            return mapper.Map<List<TGet>>(list);
        }
        public async Task<TGet> Create(TCreate create)
        {
            var model = mapper.Map<TModel>(create);
            BeforeCreate(model,create);
            await _repository.CreateAsync(model);
            model = await _repository.GetByIdAsync(model.Id);
            var result = mapper.Map<TGet>(model);
            AfterCreate(result);
            return result;
        }
        public async Task<TGet> Update(TUpdate update) 
        {
            var model = mapper.Map<TModel>(update);
            BeforeUpdate(model,update);
            await _repository.UpdateAsync(model);
            model = await _repository.GetByIdAsync(model.Id);
            var result = mapper.Map<TGet>(model);
            AfterUpdate(result);
            return result;
        }
        public async Task<TGet> Delete(Guid id)
        {
            var model = await _repository.GetByIdAsync(id);
            if(model == null)
            {
                logger.LogError($"Product was not found with this ID:{id}");
                return mapper.Map<TGet>(model);
            }
            await _repository.DeleteAsync(model);
            var result = mapper.Map<TGet>(model);
            AfterDelete(result);
            return result;
        }
        protected virtual Task BeforeCreate(TModel model, TCreate dto) => Task.CompletedTask;
        protected virtual Task BeforeUpdate(TModel model, TUpdate dto) => Task.CompletedTask;

        protected virtual Task AfterCreate(TGet dto) => Task.CompletedTask;
        protected virtual Task AfterUpdate(TGet dto) => Task.CompletedTask;
        protected virtual Task AfterDelete(TGet dto) => Task.CompletedTask;
    }
}
