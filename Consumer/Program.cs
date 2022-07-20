using Consumer;

var client = new HittpsClient();

while (true)
{
    try
    {
        var dto = await client.GetMessages();
        Console.WriteLine($"The message was {dto.Message}");
    }
    catch (HttpRequestException)
    {
        Console.WriteLine("Certificate not trusted");
    }

    await Task.Delay(TimeSpan.FromSeconds(10));
}
