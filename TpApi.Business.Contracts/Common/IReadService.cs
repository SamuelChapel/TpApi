using TpApi.Entities.Common;

namespace TpApi.Business.Contracts.Common;

public interface IReadService<TEntity> where TEntity : Entity
{
    Task<TEntity> GetById(string id);
    Task<List<TEntity>> GetAll();
}
