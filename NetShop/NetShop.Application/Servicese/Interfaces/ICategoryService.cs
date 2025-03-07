﻿using NetShop.Dto.Dtos.CategoriesDto;
namespace NetShop.Application.Servicese.Interfaces;

public interface ICategoryService:IAbstractService<GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
{ 
    Task<GetCategoryDto> UpdateCategoryAsync(Guid idCategory, UpdateCategoryDto update);
}