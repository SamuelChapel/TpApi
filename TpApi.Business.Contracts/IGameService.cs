using TpApi.Business.Contracts.Common;
using TpApi.Business.Contracts.Requests.Games;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IGameService : IService<Game, CreateGameRequest, UpdateGameRequest>
{
    /// <summary>
    /// Get the <see cref="List{Game}"/> of <see cref="Game"/> for an <see cref="User"/>
    /// </summary>
    /// <param name="userId"> <see cref="string"/> who correspond to the user id</param>
    /// <returns>The <see cref="List{Game}"/> of <see cref="Game"/> for the <see cref="User"/></returns>
    public Task<List<Game>> GetGamesByUserId(string userId);
}
