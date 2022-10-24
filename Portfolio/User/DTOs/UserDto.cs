using System.ComponentModel.DataAnnotations;

namespace Portfolio.User.DTOs;

public class UserDto
{
    [Required, EmailAddress] public string Email { get; init; } = null!;
    [Required] public string Password { get; init; } = null!;
}