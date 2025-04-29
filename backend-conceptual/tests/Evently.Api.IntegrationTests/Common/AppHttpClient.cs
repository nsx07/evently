using System.Net.Http.Headers;

using Evently.Api.IntegrationTests.Common.Tokens;
using Evently.Contracts.Tokens;

namespace Evently.Api.IntegrationTests.Common;

public class AppHttpClient(HttpClient _httpClient)
{
    public async Task<string> GenerateTokenAsync(
        GenerateTokenRequest? generateTokenRequest = null)
    {
        generateTokenRequest ??= TokenRequestFactory.CreateGenerateTokenRequest();

        var response = await _httpClient.PostAsJsonAsync("tokens/generate", generateTokenRequest);

        response.Should().BeSuccessful();

        var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();

        tokenResponse.Should().NotBeNull();

        return tokenResponse!.Token;
    }
}