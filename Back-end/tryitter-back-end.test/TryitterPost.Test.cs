using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using tryitter_back_end.Models;
using System.Net;
using System.Net.Http.Headers;
using tryitter_back_end.Services;

namespace tryitter_back_end.test;

public class TryitterPostTest : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly WebApplicationFactory<Program> _factory;

  public TryitterPostTest(WebApplicationFactory<Program> factory)
  {
    _factory = factory;
  }

  [Theory(DisplayName = "A rota /post com verbo get deve responder com status code ok")]
  [InlineData("xxxxx@gmail.com", "xxxxxx")]

  public async Task RotaGetRespondeOk(string email, string password)
  {
    var user = new User {Email = email, Password = password};
    var client = _factory.CreateClient();
    var token = new TokenGenerator().Generate(user);

    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var userResponse = await client.GetAsync("/post");
    userResponse.StatusCode.Should().Be(HttpStatusCode.OK);
  }
  
  [Theory(DisplayName = "A rota /post/{id} com verbo get deve responder com status code ok")]
  [InlineData("xxxxx@gmail.com", "xxxxxx")]

  public async Task RotaGetIdRespondeOk(string email, string password)
  {
    var user = new User {Email = email, Password = password};
    var client = _factory.CreateClient();
    var token = new TokenGenerator().Generate(user);

    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var userResponse = await client.GetAsync("/post/1");
    userResponse.StatusCode.Should().Be(HttpStatusCode.OK);
  }
}