using DI;
using Services.Core.Exceptions;
using Web.API;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Logging.ClearProviders();
builder.AddSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

DependencyHelper.RegisterServices(builder.Services, builder.Configuration);

builder.AddSlimMessageBus(new[]
    {
        typeof(SlimMessageBusRegistrar).Assembly, typeof(ServiceException).Assembly
    },
    new[]
    {
        typeof(SlimMessageBusRegistrar).Assembly, typeof(ServiceException).Assembly
    });

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerGen("TCM");

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();