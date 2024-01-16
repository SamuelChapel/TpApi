using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Exceptions;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;
using TpApi.Repository.Contracts;

namespace TpApi.Business.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<User> GetById(string id)
    {
        if (Guid.TryParse(id, out Guid guid) && await _userRepository.GetById(guid) is User u)
        {
            return u;
        }

        throw new NotFoundException("Utilisateur non trouvé");
    }

    public async Task<List<User>> GetAll()
    {
        return await _userRepository.GetAll();
    }

    public async Task<List<User>> Search(UserSearchRequest request)
    {
        return await _userRepository.Search(request);
    }

    public async Task<User> Create(UserCreateRequest request)
    {
        if (await _userRepository.IsEmailDuplicate(request.Email))
        {
            throw new BadRequestException("Email déjà utilisé");
        }

        var user = new User(request.FirstName, request.LastName, request.Email);

        return await _userRepository.Add(user);
    }

    public async Task<User> Update(UserUpdateRequest request)
    {
        var user = await GetById(request.Id);

        user.FirstName = request.FirstName ?? user.FirstName;
        user.LastName = request.LastName ?? user.LastName;
        user.Email = request.Email ?? user.Email;

        return await _userRepository.Update(user);
    }

    public async Task Delete(string id)
    {
        var user = await GetById(id);

        await _userRepository.Delete(user);
    }
}
