using Microsoft.AspNetCore.Mvc;
using TpApi.Api.Mappers;
using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Requests.Games;
using TpApi.Business.Contracts.Responses.Games;
using TpApi.Entities;

namespace TpApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController(IGameService gameService, GameMapper gameMapper) : ControllerBase
{
    private readonly IGameService _gameService = gameService;
    private readonly GameMapper _gameMapper = gameMapper;

    [HttpGet("{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<GameResponse>> GetById(string id)
    {
        Game game = await _gameService.GetById(id);

        var gameResponse = _gameMapper.ToGameResponse(game);

        return Ok(gameResponse);
    }

    [HttpGet]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<GameResponse>>> GetAll()
    {
        var games = await _gameService.GetAll();

        var gameResponses = games.Select(_gameMapper.ToGameResponse).ToList();

        return Ok(gameResponses);
    }

    [HttpGet("User")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<GameResponse>>> GetGamesByUserId(string userId)
    {
        var games = await _gameService.GetGamesByUserId(userId);

        var gameResponses = games.Select(_gameMapper.ToGameResponse).ToList();

        return Ok(gameResponses);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    public async Task<ActionResult<GameResponse>> Create(CreateGameRequest request)
    {
        var game = await _gameService.Create(request);

        var gameResponse = _gameMapper.ToGameResponse(game);

        return CreatedAtAction(nameof(GetById), new { id = gameResponse.Id }, gameResponse);
    }
}
