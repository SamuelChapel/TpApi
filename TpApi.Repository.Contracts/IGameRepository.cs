using TpApi.Entities;
using TpApi.Repository.Contracts.Common;

namespace TpApi.Repository.Contracts;

public interface IGameRepository : IReadRepository<Game>, IWriteRepository<Game>
{
    /// <summary>
    /// Get the <see cref="List{Game}"/> of <see cref="Game"/> for an <see cref="User"/>
    /// </summary>
    /// <param name="userId"><see cref="Guid"/> who correspond to the user id</param>
    /// <returns>The <see cref="List{Game}"/> of <see cref="Game"/> for the <see cref="User"/></returns>
    public Task<List<Game>> GetGamesByUserId(Guid userId);
}
