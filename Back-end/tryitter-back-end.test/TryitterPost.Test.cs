using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
// using Newtonsoft.Json;



// public class TryitterPostTest : IClassFixture<TestingWebAppFactory<Program>>
// {
//   private readonly HttpClient _client;

//   public TryitterPostTest(TestingWebAppFactory<Program> factory)
//   {
//     _client = factory.CreateClient();
//   }

//   [Theory]
//   [InlineData("Brazil", "federal")]
//   [InlineData("Brazil", "acre")]

//   public async Task ShouldFindAUniversityByCountryAndName(string country, string name)
//   {
//     var response = await _client.GetAsync($"university/{country}/{name}");
//     var result = await response.Content.ReadFromJsonAsync<object>();
    
//     response.StatusCode.Should().Be(HttpStatusCode.OK);
//     result.Should().BeOfType<JsonElement>();
//   }

//   [Theory]
//   [InlineData("Brazil")]
//   [InlineData("Turkey")]
//   public async Task ShouldFindAUniversityByCountry(string country)
//   {
//     var response = await _client.GetAsync($"university/{country}");
//     var result = await response.Content.ReadFromJsonAsync<object>();
    
//     response.StatusCode.Should().Be(HttpStatusCode.OK);
//     result.Should().BeOfType<JsonElement>();
//   }
// }