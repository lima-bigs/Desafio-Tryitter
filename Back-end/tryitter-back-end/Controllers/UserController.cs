using Microsoft.AspNetCore.Mvc;
using tryitter_back_end.Models;

namespace tryitter_back_end.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly TryitterRepository _repository;
        public UserController(TryitterRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _repository.Get<User>(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_repository.GetAll<User>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            await _repository.Add<User>(user);

            return StatusCode(201, user);
        }
        [HttpPut]
        public IActionResult Update(int id, User user)
        {
            var userInDb = _repository.Get<User>(id);

            if (userInDb == null) return NotFound("Usuário não encontrado");

            userInDb.Name = user.Name;
            userInDb.Email = user.Email;
            userInDb.Modulo = user.Modulo;
            userInDb.Status = user.Status;
            userInDb.UpdatedAt = DateTime.Now;

            _repository.Update<User>(userInDb);

            return Ok("Usuário atualizado com sucesso");
        }

        // [HttpDelete]
}
