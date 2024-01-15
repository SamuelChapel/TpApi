using Microsoft.EntityFrameworkCore;
using TpApi.Entities;
using TpApi.Repository.Contracts;
using TpApi.Repository.Database.Contexts;

namespace TpApi.Repository.Database.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<User?> GetById(Guid id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<List<User>> GetAll()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<User> Add(User user)
    {
        await _dbContext.Users.AddAsync(user);

        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> Update(User user)
    {
        _dbContext.Users.Update(user);

        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task Delete(User user)
    {
        _dbContext.Remove(user);

        await _dbContext.SaveChangesAsync();
    }

    public Task<bool> IsEmailDuplicate(string email)
    {
        return _dbContext.Users.AnyAsync(u => u.Email == email);
    }
}
