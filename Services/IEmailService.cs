using modulum_api.Model;

namespace modulum_api.Services
{
    public interface IEmailService
    {
        Task<string> SendEmail(EmailRequest request);
    }
}
