using TpApi.Entities.Common;

namespace TpApi.Repository.Contracts.Common;

public interface IReadRepository<TEntity> where TEntity : Entity
{
    Task<TEntity?> GetById(Guid id);

    Task<List<TEntity>> GetAll();
}
