using NetShop.Dto.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese.Interfaces
{
    public interface IAbstractService<TGet,TCreate, TUpdate>
        where TGet : IGet
        where TCreate: ICreate
        where TUpdate: IUpdate
    {
        Task<IEnumerable<TGet>> GetAll();
        Task<TGet> GetById(Guid id);
        Task<TGet> Create(TCreate entity);
        Task<TGet> Update(TUpdate entity);
        Task<TGet> Delete(Guid id);
    }
}
