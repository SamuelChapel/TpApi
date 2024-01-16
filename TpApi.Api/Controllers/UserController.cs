using Microsoft.AspNetCore.Mvc;
using TpApi.Api.Mappers;
using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Business.Contracts.Responses.Users;
using TpApi.Entities;

namespace TpApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService, UserMapper userMapper) : ControllerBase
{
    private readonly IUserService _userService = userService;
    private readonly UserMapper _userMapper = userMapper;

    [HttpGet("{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<UserResponse>> GetById(string id)
    {
        User user = await _userService.GetById(id);

        UserResponse userResponse = _userMapper.Map(user);

        return Ok(userResponse);
    }

    [HttpGet]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<UserResponse>>> GetAll()
    {
        var users = await _userService.GetAll();

        var userResponses = users.Select(_userMapper.Map).ToList();

        return Ok(userResponses);
    }

    [HttpPost("Search")]
    [ProducesResponseType(200)]
    public async Task<ActionResult<List<UserResponse>>> Search(UserSearchRequest request)
    {
        var users = await _userService.Search(request);

        var userResponses = users.Select(_userMapper.Map).ToList();

        return Ok(userResponses);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    public async Task<ActionResult<UserResponse>> Create(UserCreateRequest request)
    {
        var user = await _userService.Create(request);

        var userResponse = _userMapper.Map(user);

        return CreatedAtAction(nameof(GetById), new { id = userResponse.Id }, userResponse);
    }

    [HttpPut]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public async Task<ActionResult<UserResponse>> Update(UserUpdateRequest request)
    {
        var user = await _userService.Update(request);

        var userResponse = _userMapper.Map(user);

        return Ok(userResponse);
    }

    [HttpDelete]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(string id)
    {
        await _userService.Delete(id);

        return NoContent();
    }
}
