using Microsoft.EntityFrameworkCore;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts;
using TpApi.Repository.Database.Contexts;

namespace TpApi.Repository.Database.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    private const int DEFAULTPAGE = 1;
    private const int DEFAULTCOUNT = 50;

    private readonly AppDbContext _dbContext = dbContext;

    public async Task<User?> GetById(Guid id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<List<User>> GetAll()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<List<User>> Search(UserSearchRequest request)
    {
        var users = _dbContext.Users.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.Search))
            users = users.Where(u => u.FirstName.Contains(request.Search));

        var page = request.Page ?? DEFAULTPAGE;
        var count = request.Count ?? DEFAULTCOUNT;
        var startIndex = (page - 1) * count;

        users = users.Skip(startIndex)
                     .Take(count);

        return await users.ToListAsync();
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

    public async Task<bool> IsEmailDuplicate(string email)
    {
        return await _dbContext.Users.AnyAsync(u => u.Email == email);
    }
}