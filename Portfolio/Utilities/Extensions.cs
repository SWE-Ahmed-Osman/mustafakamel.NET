using System.Text.Json;
using Microsoft.AspNetCore.Identity;

namespace Portfolio.Utilities;

public static class Extensions
{
    public static string ToJsonStringContent<T>(this T data) => JsonSerializer.Serialize(data);
    public static Response ToApplicationResponse(this IdentityResult identityResult)
    {
        var errors = identityResult.Errors.Select(identityError => new Error(identityError.Code, identityError.Description ));
        return new Response(identityResult.Succeeded, errors);
    }
}