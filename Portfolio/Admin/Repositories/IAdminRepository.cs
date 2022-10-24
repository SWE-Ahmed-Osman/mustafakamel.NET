using Portfolio.Utilities;

namespace Portfolio.Admin.Repositories;

public interface IAdminRepository
{
    Task<Response> CreateRoleAsync(string role);
    Task<Response> AddToRoleAsync(string userEmail, string role);
}