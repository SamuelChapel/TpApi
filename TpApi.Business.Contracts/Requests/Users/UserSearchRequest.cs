using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record UserSearchRequest(
    string? Search,
    int? Page,
    int? Count) : IRequest;
