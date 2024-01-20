using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts;

namespace TpApi.Business.Services.Tests;

[TestClass()]
public class UserServiceUnitTests
{
    [TestMethod()]
    public async Task UpdateTest()
    {
        // Arrange
        var user = new User("Tom", "Egerie", "TomEgerie@hotmail.fr");
        var expectedUser = new User("Brice", "Glace", user.Email) { Id = user.Id };

        var userRepositoryMock = new Mock<IUserRepository>();
        userRepositoryMock.Setup(u => u.Update(It.IsAny<User>())).ReturnsAsync((User u) => u);
        userRepositoryMock.Setup(u => u.GetById(user.Id)).ReturnsAsync(user);

        var updateUserRequest = new UpdateUserRequest(user.Id.ToString(), "Brice", "Glace");

        var gameService = new Mock<IGameService>();

        var userService = new UserService(userRepositoryMock.Object, gameService.Object);

        // Act
        var result = await userService.Update(updateUserRequest);

        // Assert
        Assert.IsTrue(result is User);
        Assert.AreEqual(expectedUser.Id, result.Id);
        Assert.AreEqual(expectedUser.FirstName, result.FirstName);
        Assert.AreEqual(expectedUser.LastName, result.LastName);
        Assert.AreEqual(expectedUser.Email, result.Email);
    }
}