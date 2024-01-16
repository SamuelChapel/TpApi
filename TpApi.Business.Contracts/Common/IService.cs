using TpApi.Entities.Common;

namespace TpApi.Business.Contracts.Common;

public interface IService<TEntity, TCreateRequest, TUpdateRequest>
    where TEntity : Entity
    where TCreateRequest : IRequest
    where TUpdateRequest : IRequest
{
    Task<TEntity> GetById(string id);
    Task<List<TEntity>> GetAll();
    Task<TEntity> Create(TCreateRequest request);
    Task<TEntity> Update(TUpdateRequest request);
    Task Delete(string id);
}
