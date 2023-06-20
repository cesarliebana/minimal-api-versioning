namespace SaaV.MinimalApiVersioning;

internal static class Endpoints
{
    public static IResult Getv1()
    {   
        return Results.Ok("Ok: version v1");
    }

    public static IResult Getv2()
    {
        return Results.Ok("Ok: version v2");
    }

    public static IResult Get()
    {
        return Results.Ok("Ok: multiple versions");
    }
}
