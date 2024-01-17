using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record SearchUserRequest(
    string? Search,
    int Page = 1,
    int Count = 50) : IRequest;
