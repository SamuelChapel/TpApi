using Riok.Mapperly.Abstractions;
using TpApi.Business.Contracts.Responses.Users;
using TpApi.Entities;

namespace TpApi.Api.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None)]
public partial class UserMapper
{
    public partial UserResponse Map(User user);
}
