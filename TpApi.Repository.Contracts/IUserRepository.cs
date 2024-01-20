using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts.Common;

namespace TpApi.Repository.Contracts;

public interface IUserRepository : IReadRepository<User>, IWriteRepository<User>
{
    /// <summary>
    /// Search users with some criteria
    /// </summary>
    /// <param name="request"> <seealso cref="SearchUserRequest"/></param>
    /// <returns>the <<see cref="List{User}"/> who correspond to the research</returns>
    public Task<List<User>> Search(SearchUserRequest request);

    /// <summary>
    /// Method to test if an email is already used by an user
    /// </summary>
    /// <param name="email">The email to test</param>
    /// <returns>return a <see cref="bool"/> that is <see cref="true"/> when a user already have the same email</returns>
    public Task<bool> IsEmailDuplicate(string email);
}
