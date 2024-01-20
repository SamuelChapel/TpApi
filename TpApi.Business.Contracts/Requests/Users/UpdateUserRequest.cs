using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record UpdateUserRequest(
        string Id,
        string? FirstName = null,
        string? LastName = null,
        string? Email = null
    ) : IRequest;
