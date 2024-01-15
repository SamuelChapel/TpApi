using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts;

namespace TpApi.Business.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    public Task<User?> GetById(string id)
    {
        if (Guid.TryParse(id, out Guid guid))
            return _userRepository.GetById(Guid.Parse(id));

        return Task.FromResult(null as User);
    }

    public Task<List<User>> GetAll()
    {
        return _userRepository.GetAll();
    }

    public async Task<User?> Add(UserCreateRequest request)
    {
        if (await _userRepository.IsEmailDuplicate(request.Email))
        {
            return null;
        }

        var user = new User(request.FirstName, request.LastName, request.Email);

        return await _userRepository.Add(user);
    }

    public async Task<User?> Update(UserUpdateRequest request)
    {
        var user = await GetById(request.Id);

        if (user is null)
            return null;

        user.FirstName = request.FirstName ?? user.FirstName;
        user.LastName = request.LastName ?? user.LastName;
        user.Email = request.Email ?? user.Email;

        return await _userRepository.Update(user);
    }

    public async Task<bool> Delete(string id)
    {
        var user = await GetById(id);

        if (user is null)
            return false;

        await _userRepository.Delete(user);

        return true;
    }
}
