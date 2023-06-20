using Asp.Versioning;
using Asp.Versioning.Builder;
using Swashbuckle.AspNetCore.Annotations;

namespace SaaV.MinimalApiVersioning.Extensions;

public static class WebApplicationExtensions
{
    public static void MapEndpoints(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGet("/", Endpoints.Getv1)
            .WithName("Getv1")
            .WithMetadata(new SwaggerOperationAttribute("summary v1", "description v2"))
            .Produces(StatusCodes.Status200OK)
            .WithApiVersionSet(apiVersionSet)
            .MapToApiVersion(new ApiVersion(1.0));

        app.MapGet("/", Endpoints.Getv2)
            .WithName("Getv2")
            .WithMetadata(new SwaggerOperationAttribute("summary000", "description000"))
            .Produces(StatusCodes.Status200OK)
            .WithApiVersionSet(apiVersionSet)
            .MapToApiVersion(new ApiVersion(2.0));

        app.MapGet("/multi", Endpoints.Get)
            .WithName("GetMulti")
            .WithMetadata(new SwaggerOperationAttribute("summary000", "description000"))
            .Produces(StatusCodes.Status200OK)
            .WithApiVersionSet(apiVersionSet);
    }
}
