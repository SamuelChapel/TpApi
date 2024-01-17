using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record AdduserGameRequest(
    string UserId,
    string GameId
    ) : IRequest;