using TpApi.Business.Contracts.Common;
using TpApi.Business.Contracts.Requests.Games;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IGameService : IService<Game, CreateGameRequest, UpdateGameRequest>
{
    public Task<List<Game>> GetGamesByUserId(string userId);
}
