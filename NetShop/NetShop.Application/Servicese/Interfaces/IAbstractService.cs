﻿using NetShop.Dto.Dtos.Interfaces;
namespace NetShop.Application.Servicese.Interfaces;

public interface IAbstractService<TGet,TCreate, TUpdate>
    where TGet : IGet
    where TCreate: ICreate
    where TUpdate: IUpdate
{
    Task<IEnumerable<TGet>> GetAllAsync();
    Task<TGet> GetByIdAsync(Guid id);
    Task<TGet> CreateAsync(TCreate entity);
    Task<TGet> UpdateAsync(TUpdate entity);
    Task<TGet> DeleteAsync(Guid id);
}
