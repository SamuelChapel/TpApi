using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts.Common;

namespace TpApi.Repository.Contracts;

public interface IUserRepository : IReadRepository<User>, IWriteRepository<User>
{
    public Task<List<User>> Search(SearchUserRequest request);
    public Task<bool> IsEmailDuplicate(string email);
}
