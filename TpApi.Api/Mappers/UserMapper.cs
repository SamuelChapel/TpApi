using Riok.Mapperly.Abstractions;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Business.Contracts.Responses.Users;
using TpApi.Entities;

namespace TpApi.Api.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None)]
public partial class UserMapper
{
    public partial UserResponse ToUserResponse(User user);
    public partial UserWithGamesResponse ToUserWithGamesResponse(User user);
    public partial User ToUser(UpdateUserRequest request);
}
