using TpApi.Business.Contracts.Common;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IUserService : IService<User, CreateUserRequest, UpdateUserRequest>
{
    public Task<List<User>> Search(SearchUserRequest request);
    public Task<User> AddGame(AdduserGameRequest request);
}
