using System.Text.Json.Serialization;

namespace Portfolio.Utilities;

public class Error
{
    [JsonIgnore] public int StatusCode { get; }
    public string ErrorCode { get; }
    public string Description { get; }
    
    public Error(string errorCode, string description)
    {
        ErrorCode = errorCode;
        Description = description;
    }
    public Error(int statusCode, string errorCode, string description)
    {
        StatusCode = statusCode;
        ErrorCode = errorCode;
        Description = description;
    }
}

public static class ErrorsList
{
    public static Error UserEmailNotFound(string email) => new(StatusCodes.Status404NotFound, nameof(UserEmailNotFound),
        $"There is no user with this email {email}.");

    public static Error SignInNotAllowed() =>
        new(StatusCodes.Status400BadRequest, nameof(SignInNotAllowed), "Sign In not allowed.");

    public static Error SignInFailed() => new(StatusCodes.Status400BadRequest, nameof(SignInFailed),
        "Sign In failed, wrong email or password.");
}