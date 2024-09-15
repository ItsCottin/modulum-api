using modulum_api.Model;

namespace modulum_api.Services
{
    public interface IRoleService
    {
        Task<List<RoleModel>> GetRolesAsync();

        Task<List<string>> GetUserRolesAsync(string emailId);

        Task<List<string>> AddRolesAsync(string[] roles);

        Task<bool> AddUserRoleAsync(string userEmail, string[] roles);

    }
}
