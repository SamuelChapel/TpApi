using Microsoft.EntityFrameworkCore;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts;
using TpApi.Repository.Database.Contexts;

namespace TpApi.Repository.Database.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<User?> GetById(Guid id)
    {
        return await _dbContext.Users
            .Where(u => u.Id == id)
            .Include(u => u.Games)
            .FirstOrDefaultAsync();
    }

    public async Task<List<User>> GetAll()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<List<User>> Search(SearchUserRequest request)
    {
        var users = _dbContext.Users.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.Search))
            users = users.Where(u => u.FirstName.Contains(request.Search));

        var startIndex = (request.Page - 1) * request.Count;

        users = users.Skip(startIndex)
                     .Take(request.Count);

        return await users.ToListAsync();
    }

    public async Task<User> Create(User user)
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

    public async Task<bool> IsEmailDuplicate(string email)
    {
        return await _dbContext.Users.AnyAsync(u => u.Email == email);
    }
}