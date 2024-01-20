using TpApi.Business.Contracts.Common;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IUserService : IService<User, CreateUserRequest, UpdateUserRequest>
{
    /// <summary>
    /// Search users with some criteria
    /// </summary>
    /// <param name="request"> <seealso cref="SearchUserRequest"/></param>
    /// <returns>the <<see cref="List{User}"/> who correspond to the research</returns>
    public Task<List<User>> Search(SearchUserRequest request);

    /// <summary>
    /// Add a <see cref="Game"/> for a <see cref="User"/>
    /// </summary>
    /// <param name="request"> <see cref="AdduserGameRequest"/> who contain the user id and the game id for the game to add</param>
    /// <returns>the <see cref="User"/> with the <see cref="Game"/> added</returns>
    public Task<User> AddGame(AdduserGameRequest request);
}
