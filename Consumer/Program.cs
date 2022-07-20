using Consumer;

var client = new HittpsClient();

while (true)
{
    var dto = await client.GetMessages();
    Console.WriteLine($"The message was {dto.Message}");
    await Task.Delay(TimeSpan.FromSeconds(10));
}
