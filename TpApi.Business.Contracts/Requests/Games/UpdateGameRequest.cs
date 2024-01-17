using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Games;

public record UpdateGameRequest(
    string Id,
    string Name
    ) : IRequest;