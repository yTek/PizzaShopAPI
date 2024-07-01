using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configuration de PizzaShopContext pour utiliser MySQL
builder.Services.AddDbContext<PizzaShopContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("PizzaShopContext") ?? throw new InvalidOperationException("Connection string 'PizzaShopContext' not found."),
        new MySqlServerVersion(new Version(8, 0, 21))));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
