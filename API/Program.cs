// Crera servicio web
using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Agregar controladores
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"));
});

// Poder consultar si tiene permisos
builder.Services.AddCors();


// Crea el documento de la API, se puede eliminar para aligerar la API
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Aceptar los permisos (seguridad) para poder consultarlo
app.UseCors(x => x.AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins(
        "http://localhost:4200",
        "https://localhost:4200"
    ));

app.MapControllers();

app.Run();
