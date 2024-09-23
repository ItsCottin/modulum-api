using modulum_api.Model;

namespace modulum_api.Services
{
    public interface IUserService
    {
        Task<List<Usuario>> GetAllUsers();

        Task<Usuario> GetUserByEmail(string emailId);

        Task<bool> UpdateUser(string emailId, Usuario user);

        Task<bool> DeleteUserByEmail(string emailId);
    }
}
