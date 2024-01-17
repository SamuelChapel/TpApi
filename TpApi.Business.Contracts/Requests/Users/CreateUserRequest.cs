using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record CreateUserRequest(
    string FirstName,
    string LastName,
    string Email
    ) : IRequest;