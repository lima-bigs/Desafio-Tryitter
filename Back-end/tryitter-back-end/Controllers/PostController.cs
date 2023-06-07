using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tryitter_back_end.Models;
using tryitter_back_end.Repositories;

namespace tryitter_back_end.Controllers;

[ApiController]
[Route("post")]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Authorize]
public class PostController : ControllerBase
{
    private readonly PostRepository _repository;
        public PostController(PostRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Busca o post pelo seu id. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> Get(int id)
        {
            var post = await _repository.Get(id);
            if (post == null)
            {
                return NotFound($"Post com id:{id} não existe.");
            }
            return Ok(post);
        }

        /// <summary>
        /// Busca todos os posts de um usuário pelo seu id. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpGet("user/{id}")]
        public async Task<ActionResult<List<Post>>> GetByUser(int id)
        {
            var posts = await _repository.GetByUser(id);
            if (posts.Count == 0)
            {
                return NotFound($"O usuário id:{id} não possui nenhum post.");
            }
            return Ok(posts);
        }

        /// <summary>
        /// Busca todos os posts. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAll()
        {
            return Ok(await _repository.GetAll());
        }

        /// <summary>
        /// Cria um novo post. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Add(Post post)
        {
            var addedpost = await _repository.Add(post);

            return StatusCode(201, addedpost);
        }

        /// <summary>
        /// Atualiza um post pelo id e passando novos dados no body. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Post post)
        {
            var postInDb = await _repository.Get(id);

            if (postInDb == null) return NotFound($"Post com id:{id} não existe.");

            postInDb.PostId = id;
            postInDb.Content= post.Content;
            postInDb.Image = post.Image;

            await _repository.Update(postInDb);

            return Ok("Post atualizado com sucesso");
        }

        /// <summary>
        /// Apaga um post pelo id. Deve enviar o token no headers Authorization : Bearer (token).
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var postInDb = await _repository.Get(id);

            if (postInDb == null) return NotFound($"Post com id:{id} não existe.");

            await _repository.Delete(postInDb);

            return Ok("Post apagado com sucesso");
        }
}
