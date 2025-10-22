// Librerias que se van a ocupar
using System;

// Puede tener using globales dentro del proyecto

// Nombre del proyecto.Nombre carpeta
namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    // Se marca enable para que se tenga que inicializar
    // o para que sea requerido (public required string)


    // Todo esto se puede resumir con el get y set del public string
    // public string Id { get; set; }
    // = 
    // private string _id;
    // public string GetId() { return _id; }
    // public void SetId(string id) { _id = id; }

    // Un string immutable no puede cambiar su valor, porque es un arreglo
    // finito y no se pueden agregar más cadenas

    // Varibles con signo de interrogación (?), significa que puede
    // ser nulo u opcional (public string?)

    public required string DisplayName { get; set; }
    public required string Email { get; set; }

    public required byte[] PasswordHash { get; set; }

    public required byte[] PasswordSalt { get; set; }
}
