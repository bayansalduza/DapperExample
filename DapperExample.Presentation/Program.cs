using DapperExample.Application.Services;
using DapperExample.Infrastructure;
using DapperExample.Infrastructure.Repositories.Product;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DatabaseConnectionFactory>();

builder.Services.AddScoped<IDbConnection>(sp =>
{
    var factory = sp.GetRequiredService<DatabaseConnectionFactory>();
    return factory.CreateConnection();
});

// Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Service
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

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
