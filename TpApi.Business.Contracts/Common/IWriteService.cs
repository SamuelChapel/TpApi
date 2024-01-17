using TpApi.Entities.Common;

namespace TpApi.Business.Contracts.Common;

public interface IWriteService<TEntity, TCreateRequest, TUpdateRequest>
    where TEntity : Entity
    where TCreateRequest : IRequest
    where TUpdateRequest : IRequest
{
    Task<TEntity> Create(TCreateRequest request);
    Task<TEntity> Update(TUpdateRequest request);
    Task Delete(string id);
}
