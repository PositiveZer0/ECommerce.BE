using ECommerce.Api.GraphQL.Mutations;
using ECommerce.Api.GraphQL.Queries;
using ECommerce.Application.Extensions;
using ECommerce.Application.Repositories;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Infrastructure
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Application
services.RegisterApplication();

services.AddScoped<IProductRepository, ProductRepository>();

// Api
builder.Services
    .AddOpenApi()
    .AddGraphQLServer()
    .AddQueryType<QueryType>()
    .AddMutationType<MutationType>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
    logger.LogInformation("Current Connection String for QA: {ConnectionString}", connStr);
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate(); // Create database and apply migrations if necessary
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGraphQL();

app.MapGet("/ping", () =>
{
    return $"Ping {DateTime.UtcNow}";
})
.WithName("Ping");

app.Run();
