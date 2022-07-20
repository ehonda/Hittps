using RestSharp;

namespace Consumer;

public class HittpsClient
{
    private readonly RestClient _client = new("http://hittps");

    public Task<MessageDto> GetMessages() => _client.GetAsync<MessageDto>(new("messages"))!;
}
