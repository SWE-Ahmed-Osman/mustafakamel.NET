using Microsoft.AspNetCore.Identity;

namespace Portfolio.JWTGenerator.Repositories;

public interface IJwtGeneratorRepository
{
    Task<string> GenerateJwtSecurityToken(IdentityUser user);
}