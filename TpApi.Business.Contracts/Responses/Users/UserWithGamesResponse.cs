using TpApi.Entities;

namespace TpApi.Business.Contracts.Responses.Users;

public record UserWithGamesResponse(
    string Id,
    string FirstName,
    string LastName,
    List<Game> Games
    );
