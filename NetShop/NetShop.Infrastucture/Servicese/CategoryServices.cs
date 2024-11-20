﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using NetShop.Application.Models.Categories;
using NetShop.Application.Models.Products;
using NetShop.Application.Repositories.Interfaces;
using NetShop.Dto.Dtos.CategoriesDto;
using NetShop.Dto.Dtos.Interfaces;
using NetShop.Dto.Dtos.ProductsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese
{
    public class CategoryServices : AbstractService<ICategoryRepository, CategoryModel, GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryServices(ILogger logger, IMapper mapper, ICategoryRepository repository) : base(logger, mapper, repository)
        {
        }
        public async Task<GetCategoryDto> GetById(Guid Id)
        {
            var category = await _repository.GetByIdAsync(Id);
            return mapper.Map<GetCategoryDto>(category);
        }
        public async Task<List<GetCategoryDto>> GetAll()=>  mapper.Map<List<GetCategoryDto>>(await _repository.GetAllAsync());
        public async Task<GetCategoryDto> Create(CreateCategoryDto createCategoryDto)
        {
            var category = mapper.Map<CategoryModel>(createCategoryDto);
            var result = mapper.Map<GetCategoryDto>(await _repository.CreateAsync(category));
            return result;
        }
        public async Task<GetCategoryDto> Update(Guid id, UpdateCategoryDto updateCategoryDto)
        {
            var category = await _repository.GetByIdAsync(id);
            if(category != null)
            {
                category.Name = updateCategoryDto.NameCategory;
                category.UpdateTime = DateTime.Now;
            }
            var result = mapper.Map<GetCategoryDto>(await _repository.UpdateAsync(category));
            return result;

        }
        public async Task<GetCategoryDto> Delete(Guid id)
        {
            var category = await _repository.GetByIdAsync(id);
            var result = mapper.Map<GetCategoryDto>(await _repository.DeleteAsync(category));
            return result;
        }
    }
}
