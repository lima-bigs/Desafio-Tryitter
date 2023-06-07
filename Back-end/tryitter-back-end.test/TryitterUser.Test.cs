using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using tryitter_back_end.Models;
using System.Net;
using System.Net.Http.Headers;
using tryitter_back_end.Services;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;

namespace tryitter_back_end.test;

public class TryitterUserTest : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly WebApplicationFactory<Program> _factory;

  public TryitterUserTest(WebApplicationFactory<Program> factory)
  {
    _factory = factory;
  }

  [Theory(DisplayName = "A rota /user com verbo get deve responder com status code ok")]
  [InlineData("xxxxx@gmail.com", "xxxxxx")]

  public async Task RotaLoginRespondeErro(string email, string password)
  {
    var user = new User {Email = email, Password = password};
    var client = _factory.CreateClient();
    var token = new TokenGenerator().Generate(user);

    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var userResponse = await client.GetAsync("/user");
    userResponse.StatusCode.Should().Be(HttpStatusCode.OK);
  }
  
  [Theory(DisplayName = "A rota /user/{id} com verbo get deve responder com status code ok")]
  [InlineData("xxxxx@gmail.com", "xxxxxx")]

  public async Task RotaGetIdRespondeOk(string email, string password)
  {
    var user = new User {Email = email, Password = password};
    var client = _factory.CreateClient();
    var token = new TokenGenerator().Generate(user);

    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var userResponse = await client.GetAsync("/user/1");
    userResponse.StatusCode.Should().Be(HttpStatusCode.OK);
  }
  
  [Theory(DisplayName = "Deve adicionar e apagar um usuário corretamente")]
  [InlineData("teste@gmail.com", "teste")]

  public async Task RotaAddDeleteIdRespondemOk(string email, string password)
  {
    var user = new User {Email = email, Password = password};

    var userJson = JsonConvert.SerializeObject(user);
    var body = new StringContent(userJson, Encoding.UTF8, "application/json");
    var client = _factory.CreateClient();
    var response = await client.PostAsync("/user", body);
    var responseString = await response.Content.ReadAsStringAsync();
    var userResponse = JsonConvert.DeserializeObject<User>(responseString);

    response.StatusCode.Should().Be(HttpStatusCode.Created);
    var token = new TokenGenerator().Generate(user);

    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var deleteResponse = await client.DeleteAsync($"/user/{userResponse.UserId}");
    deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);
  }
}