using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Exceptions;
using TpApi.Business.Contracts.Requests.Games;
using TpApi.Entities;
using TpApi.Repository.Contracts;

namespace TpApi.Business.Services;

public class GameService(IGameRepository gameRepository) : IGameService
{
    private readonly IGameRepository _gameRepository = gameRepository;

    public async Task<Game> GetById(string id)
    {
        if (Guid.TryParse(id, out Guid guid) && await _gameRepository.GetById(guid) is Game g)
        {
            return g;
        }

        throw new NotFoundException("Jeu non trouvé");
    }

    public async Task<List<Game>> GetAll()
    {
        return await _gameRepository.GetAll();
    }

    public async Task<Game> Create(CreateGameRequest request)
    {
        var game = new Game(request.Name);

        return await _gameRepository.Create(game);
    }

    public async Task<Game> Update(UpdateGameRequest request)
    {
        var game = await GetById(request.Id);

        game.Name = request.Name;

        return await _gameRepository.Update(game);
    }

    public async Task Delete(string id)
    {
        var game = await GetById(id);

        await _gameRepository.Delete(game);
    }

    public async Task<List<Game>> GetGamesByUserId(string userId)
    {
        if (Guid.TryParse(userId, out Guid guid))
        {
            return await _gameRepository.GetGamesByUserId(guid);
        }

        throw new BadRequestException("Guid non valide");
    }
}
