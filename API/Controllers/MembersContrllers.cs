using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


// Esto genera https://localhost:5001/api/members le quita el controller
// porque esta entre corchetes
[Route("api/[controller]")]
[ApiController]
public class MembersController(AppDbContext context) : ControllerBase
{

    // Este es el primero en ejecutarse
    [HttpGet]
    // Si se ocupa un IEnumerable es lo mismo que List
    // List = IEnumerable
    public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
    {
        var members = await context.Users.ToListAsync();
        return members;
    }

    [HttpGet("{id}")] // https://localhost:5001/api/members/bob-id
    public async Task<ActionResult<AppUser>> GetMember(string id)
    {
        // Toma el id de la URL y muestra la tupla
        var member = await context.Users.FindAsync(id);

        // Si no encuentra el id manda no encontrado    
        if (member == null) return NotFound();

        return member;
    }
}

// Si lo consultamos desde Postman con el metodo de GEt
// nos muestra los valores que ya ingresamos
