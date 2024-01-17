using TpApi.Entities;
using TpApi.Repository.Contracts.Common;

namespace TpApi.Repository.Contracts;

public interface IGameRepository : IReadRepository<Game>, IWriteRepository<Game>
{
    public Task<List<Game>> GetGamesByUserId(Guid userId);
}
