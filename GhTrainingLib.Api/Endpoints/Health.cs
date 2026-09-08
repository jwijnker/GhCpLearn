using System.Diagnostics;

namespace GhTrainingLib.Api.Endpoints;

public static class Health
{
    public static void MapHealth(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/health", GetHealth)
            .WithName("GetHealth");
    }

    private static async Task<IResult> GetHealth()
    {
        using var process = Process.GetCurrentProcess();
        var startedAt = Stopwatch.GetTimestamp();
        var initialCpuTime = process.TotalProcessorTime;

        await Task.Delay(50);

        process.Refresh();
        var elapsedSeconds = Stopwatch.GetElapsedTime(startedAt).TotalSeconds;
        var cpuTimeSeconds = (process.TotalProcessorTime - initialCpuTime).TotalSeconds;
        var cpuLoad = cpuTimeSeconds / (elapsedSeconds * Environment.ProcessorCount) * 100;

        return Results.Ok(new
        {
            cpuLoad = Math.Round(Math.Clamp(cpuLoad, 0, 100), 2),
            memoryUsage = process.WorkingSet64,
            cpuLoadUnit = "percent",
            memoryUsageUnit = "bytes"
        });
    }
}