using Evently.Infrastructure.Common.Middleware;

using Microsoft.AspNetCore.Builder;

namespace Evently.Infrastructure;

public static class RequestPipeline
{
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseMiddleware<EventualConsistencyMiddleware>();
        return app;
    }
}