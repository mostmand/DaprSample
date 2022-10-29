using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace DaprSample.Endpoints;

[HttpGet(""), AllowAnonymous]
public class HelloWorldEndpoint : EndpointWithoutRequest<string>
{
    public override Task HandleAsync(CancellationToken ct)
    {
        return SendOkAsync("Hello world!", ct);
    }
}