using Microsoft.EntityFrameworkCore;
using TpApi.Entities;
using TpApi.Repository.Contracts;
using TpApi.Repository.Database.Contexts;

namespace TpApi.Repository.Database.Repositories;

public class GameRepository(AppDbContext dbContext) : IGameRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<Game?> GetById(Guid id)
    {
        return await _dbContext.Games.FindAsync(id);
    }

    public async Task<List<Game>> GetAll()
    {
        return await _dbContext.Games.ToListAsync();
    }

    public async Task<Game> Create(Game game)
    {
        await _dbContext.Games.AddAsync(game);

        await _dbContext.SaveChangesAsync();

        return game;
    }

    public async Task<Game> Update(Game game)
    {
        _dbContext.Games.Update(game);

        await _dbContext.SaveChangesAsync();

        return game;
    }

    public async Task Delete(Game game)
    {
        _dbContext.Remove(game);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Game>> GetGamesByUserId(Guid userId)
    {
        return await _dbContext.Games.Where(g => g.UserId == userId).ToListAsync();
    }
}
