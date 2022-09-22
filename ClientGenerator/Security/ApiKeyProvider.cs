using AspNetCore.Authentication.ApiKey;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ClientGenerator.Security;

public class ApiKeyProvider : IApiKeyProvider
{
    private readonly ILogger<IApiKeyProvider> _logger;

    public ApiKeyProvider(ILogger<IApiKeyProvider> logger)
    {
        _logger = logger;
    }

    public async Task<IApiKey> ProvideAsync(string key)
    {
        try
        {
            if (!string.IsNullOrEmpty(key) && key.Equals("ApiKey123"))
            {
                return new ApiKey(key, "Owner");
            }

            return null;
        }
        catch (System.Exception exception)
        {
            _logger.LogError(exception, exception.Message);
            throw;
        }
    }
}