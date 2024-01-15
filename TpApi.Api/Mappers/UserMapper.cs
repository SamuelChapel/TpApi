using Riok.Mapperly.Abstractions;
using TpApi.Api.Dto.Users;
using TpApi.Entities;

namespace TpApi.Api.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class UserMapper
{
    public partial UserResponse ToUserResponse(User user);
}
