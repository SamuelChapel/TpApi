using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Games;

public record CreateGameRequest(
    string Name
    ) : IRequest;