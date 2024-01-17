using Riok.Mapperly.Abstractions;
using TpApi.Business.Contracts.Responses.Games;
using TpApi.Entities;

namespace TpApi.Api.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.None)]
public partial class GameMapper
{
    public partial GameResponse ToGameResponse(Game game);
}
