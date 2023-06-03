using Microsoft.AspNetCore.Mvc;
using tryitter_back_end.Models;
using tryitter_back_end.Repositories;

namespace tryitter_back_end.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly UserRepository _repository;
        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _repository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            await _repository.Add(user);

            return StatusCode(201, user);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, User user)
        {
            var userInDb = await _repository.Get(id);

            if (userInDb == null) return NotFound("Usuário não encontrado");

            userInDb.Name = user.Name;
            userInDb.Email = user.Email;
            userInDb.Modulo = user.Modulo;
            userInDb.Status = user.Status;
            userInDb.UpdatedAt = DateTime.Now;

            await _repository.Update(userInDb);

            return Ok("Usuário atualizado com sucesso");
        }

        // [HttpDelete]
}
