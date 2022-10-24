using Portfolio.User.DTOs;
using Portfolio.Utilities;

namespace Portfolio.User.Repositories;

public interface IUserRepository
{
    Task<Response> CreateAsync(UserDto userDto);
    Task<Response<string>> SignInAsync(UserDto userDto);
    Task<Response> SendConfirmationEmailAsync(string userEmail);
    Task<Response> ConfirmEmailAsync(string userEmail, string token);
    Task<Response> DeleteAsync(UserDto userDto);
}