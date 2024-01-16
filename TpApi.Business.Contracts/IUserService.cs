using TpApi.Business.Contracts.Common;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IUserService : IService<User, UserCreateRequest, UserUpdateRequest>
{
    public Task<List<User>> Search(UserSearchRequest request);
}
