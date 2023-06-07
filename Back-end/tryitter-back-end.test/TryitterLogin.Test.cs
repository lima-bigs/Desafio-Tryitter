using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using tryitter_back_end.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net;

namespace tryitter_back_end.test;

public class TryitterLoginTest : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly WebApplicationFactory<Program> _factory;

  public TryitterLoginTest(WebApplicationFactory<Program> factory)
  {
    _factory = factory;
  }

  [Theory(DisplayName = "A rota /login deve responder com status code ok")]
  [InlineData("xxxxx@gmail.com", "xxxxxx")]
  [InlineData("jose@gmail.com", "abacates")]

  public async Task RotaLoginRespondeErro(string email, string password)
  {
    var user = new User {Email = email, Password = password};
    var userJson = JsonConvert.SerializeObject(user);
    var body = new StringContent(userJson, Encoding.UTF8, "application/json");

    var client = _factory.CreateClient();
    var response = await client.PostAsync("/login", body);

    if (password == "abacates")
    {
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
    else
    {
      response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
  }
}