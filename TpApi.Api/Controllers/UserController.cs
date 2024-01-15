using Microsoft.AspNetCore.Mvc;
using TpApi.Api.Dto.Users;
using TpApi.Api.Mappers;
using TpApi.Business.Contracts;
using TpApi.Business.Contracts.Requests.Users;
using TpApi.Entities;

namespace TpApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService, UserMapper userMapper) : ControllerBase
{
    private readonly IUserService _userService = userService;
    private readonly UserMapper _userMapper = userMapper;

    [HttpGet("{id}")]
    public async Task<ActionResult<UserResponse>> GetById(string id)
    {
        User? user = await _userService.GetById(id);

        if (user is null)
            return NotFound();

        var userResponse = _userMapper.ToUserResponse(user);

        return Ok(userResponse);
    }

    [HttpGet]
    public async Task<ActionResult<List<UserResponse>>> GetAll()
    {
        var users = await _userService.GetAll();

        var userResponses = users.Select(_userMapper.ToUserResponse).ToList();

        return Ok(userResponses);
    }

    [HttpPost]
    public async Task<ActionResult<UserResponse>> Create(
        UserCreateRequest request)
    {
        var user = await _userService.Add(request);

        if (user is null)
            return Conflict();

        var userResponse = _userMapper.ToUserResponse(user);

        return Ok(userResponse);
    }

    [HttpPut]
    public async Task<ActionResult<UserResponse>> Update(
        UserUpdateRequest request)
    {
        var user = await _userService.Update(request);

        if (user is null)
            return BadRequest();

        var userResponse = _userMapper.ToUserResponse(user);

        return Ok(userResponse);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(
        string id)
    {
        if (await _userService.Delete(id))
            return NoContent();

        return NotFound();
    }
}
