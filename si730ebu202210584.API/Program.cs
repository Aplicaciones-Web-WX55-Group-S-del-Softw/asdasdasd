using Microsoft.EntityFrameworkCore;
using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;
using si730ebu202210584.API.Inventory.Application.Internal.CommandServices;
using si730ebu202210584.API.Inventory.Domain.Repositories;
using si730ebu202210584.API.Inventory.Domain.Services;
using si730ebu202210584.API.Inventory.Infrastructure.Persistence.EFC.Repositories;
using si730ebu202210584.API.Shared.Infrastructure.Interfaces.ASP.Configuration;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRoutingNamingConvention()));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        if (connectionString != null)
            if (builder.Environment.IsDevelopment())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            else if (builder.Environment.IsProduction())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Error)
                    .EnableDetailedErrors();
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddRouting(options => options.LowercaseUrls = true);


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IThingRepository, ThingRepository>();
builder.Services.AddScoped<IThingCommandService, ThingCommandService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();