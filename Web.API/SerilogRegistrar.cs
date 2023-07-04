using Serilog;

namespace Web.API;

public static class SerilogRegistrar
{
    public static void AddSerilog(this WebApplicationBuilder builder)
    {
        LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration);

        Log.Logger = loggerConfiguration.CreateLogger();

        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(Log.Logger);

        builder.Services.AddSingleton(Log.Logger);
    }
}