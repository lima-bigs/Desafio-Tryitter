using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tryitter_back_end.Models;
using tryitter_back_end.Repositories;

namespace tryitter_back_end.Controllers;

[ApiController]
[Route("user")]
[Authorize]
public class UserController : ControllerBase
{
    private readonly UserRepository _repository;
        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _repository.Get(id);
            if (user == null)
            {
                return NotFound($"Usuário com id:{id} não existe.");
            }
            return Ok(user);
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult> Add(User user)
        {
            var addedUser = await _repository.Add(user);

            return StatusCode(201, addedUser);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, User user)
        {
            var userInDb = await _repository.Get(id);

            if (userInDb == null) return NotFound("Usuário não encontrado");

            userInDb.UserId = id;
            userInDb.Name = user.Name;
            userInDb.Email = user.Email;
            userInDb.Modulo = user.Modulo;
            userInDb.Status = user.Status;

            await _repository.Update(userInDb);

            return Ok("Usuário atualizado com sucesso");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userInDb = await _repository.Get(id);

            if (userInDb == null) return NotFound("Usuário não encontrado");

            await _repository.Delete(userInDb);

            return Ok("Usuário apagado com sucesso");
        }
}
