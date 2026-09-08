namespace GhTrainingLib.Api.Endpoints;

public static class EndpointMappingExtensions
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapAlive();
        app.MapHealth();
        app.MapWeatherforecast();

        return app;
    }
}