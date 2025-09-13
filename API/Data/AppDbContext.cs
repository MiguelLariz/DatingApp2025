using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// Agrega el constructor en la misma linea de la clase
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
