using Dapr.Client;

var client = DaprClient.CreateInvokeHttpClient("myapp");
var response = await client.GetAsync("hello");
var content = await response.Content.ReadAsStringAsync();

Console.WriteLine(content);

using var daprClient = new DaprClientBuilder()
    .Build();
try
{
    var result = await daprClient.InvokeMethodAsync<string>(HttpMethod.Get, "myapp", "hello", CancellationToken.None);
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
