using NetShop.Infrastucture.Models;

namespace NetShop.Infrastucture.Repositories.Interfaces;

public interface IAbstractRepository<TModel> where TModel : BaseModel
{
    Task<TModel> CreateAsync(TModel model);
    Task<TModel> UpdateAsync(TModel model);
    Task<TModel> DeleteAsync(TModel model);
    Task<TModel> GetByIdAsync(Guid id);
    Task<IEnumerable<TModel>> GetAllAsync();
}
