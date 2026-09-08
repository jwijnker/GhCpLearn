namespace GhTrainingLib.Api.Endpoints;

public static class Alive
{
    public static void MapAlive(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/alive", () => Results.Ok(new { alive = true }))
            .WithName("GetAlive");
    }
}