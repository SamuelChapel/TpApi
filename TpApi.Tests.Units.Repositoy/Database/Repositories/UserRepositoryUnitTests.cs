using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Database.Contexts;

namespace TpApi.Repository.Database.Repositories.Tests;

[TestClass()]
public class UserRepositoryUnitTests
{
    private readonly AppDbContext _context;

    public UserRepositoryUnitTests()
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("Test");
        _context = new AppDbContext(dbContextOptionsBuilder.Options);
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }

    [TestMethod()]
    public async Task SearchTest()
    {
        // Arrange
        var exceptedUser = new User("Jacques", "Sonne", "JC@gmail.com");
        _context.Users.Add(exceptedUser);
        _context.Users.AddRange(
            [
                exceptedUser,
                new User("Jean", "Bon", "JB@gmail.com"),
                new User("Brice", "Glace", "JB@yahoo.fr"),
                new User("Tom", "Egerie", "TomEgerie@hotmail.fr"),
            ]);
        var userRepository = new UserRepository(_context);
        var request = new SearchUserRequest("Jac");

        // Act
        var result = await userRepository.Search(request);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(result[0], exceptedUser);
    }
}