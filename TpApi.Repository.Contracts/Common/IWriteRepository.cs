using TpApi.Entities.Common;

namespace TpApi.Repository.Contracts.Common;

public interface IWriteRepository<TEntity> where TEntity : Entity
{
    Task<TEntity> Create(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task Delete(TEntity entity);
}
