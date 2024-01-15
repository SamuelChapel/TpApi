using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;

namespace TpApi.Business.Contracts;

public interface IUserService
{
    public Task<User?> GetById(string id);
    public Task<List<User>> GetAll();
    public Task<User?> Add(UserCreateRequest request);
    public Task<User?> Update(UserUpdateRequest request);
    public Task<bool> Delete(string id);
}
