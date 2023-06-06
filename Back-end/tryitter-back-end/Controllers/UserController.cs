using Microsoft.AspNetCore.Authorization;
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
        
        /// <summary>
        /// Busca o usuário pelo seu id. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _repository.Get(id);
            if (user == null)
            {
                return NotFound($"Usuário com id:{id} não existe.");
            }
            return Ok(user);
        }

        /// <summary>
        /// Busca todos os usuários. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            return Ok(await _repository.GetAll());
        }

        /// <summary>
        /// Cria um novo usuário. Não requer o envio de token.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Add(User user)
        {
            var addedUser = await _repository.Add(user);

            return StatusCode(201, addedUser);
        }
        
        /// <summary>
        /// Atualiza um usuário pelo id e passando novos dados no body. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpPut("{id}")]
        [Authorize]
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

        /// <summary>
        /// Apaga um usuário pelo id. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var userInDb = await _repository.Get(id);

            if (userInDb == null) return NotFound("Usuário não encontrado");

            await _repository.Delete(userInDb);

            return Ok("Usuário apagado com sucesso");
        }
}
