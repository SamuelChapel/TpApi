using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record UserUpdateRequest(
        string Id,
        string? FirstName,
        string? LastName,
        string? Email
    ) : IRequest;
