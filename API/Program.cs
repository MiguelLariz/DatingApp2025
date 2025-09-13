// Crera servicio web
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Agregar controladores
builder.Services.AddControllers();

// Crea el documento de la API, se puede eliminar para aligerar la API
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
