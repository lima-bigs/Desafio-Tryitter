using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tryitter_back_end.Models;
using tryitter_back_end.Repositories;
using tryitter_back_end.Services;

namespace tryitter_back_end.test;

[ApiController]
[Route("login")]
[AllowAnonymous]
public class LoginController : ControllerBase
{
    private readonly UserRepository _repository;
    public LoginController(UserRepository repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// Faz login passando email e senha, retornando o usuário e o token para acessar as demais rotas.
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<LoginResponse>> Login(User user)
    {
        var loginResponse = new LoginResponse();
        try
        {
            loginResponse.User = await _repository.UserVerify(user);
            if (loginResponse.User == null)
            {
                return NotFound($"Usuário com email:{user.Email} não existe. Faça seu cadastro.");
            }
            loginResponse.User.Password = null;

            loginResponse.Token = new TokenGenerator().Generate(loginResponse.User);

            return Ok(loginResponse);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
