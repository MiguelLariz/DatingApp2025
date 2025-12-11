using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterRequest
{
    [Required]
    // Es mejor usar string.Empty en lugar de =""
    public string DisplayName { get; set; } = string.Empty;

    [Required]

    // Es un validador, pero existen mas para diferentes tipos de cosas
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
}
