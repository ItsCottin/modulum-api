using modulum_api.Model;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace modulum_api.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration config;
        public EmailService(IConfiguration config)
        {
            this.config = config;
        }

        public async Task<string> SendEmail(EmailRequest request)
        {
            try
            {
                var client = new SendGridClient(config.GetValue<string>("MailApiKey"));
                var from = new EmailAddress("modulumprojeto@gmail.com", "Modulum");
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, new EmailAddress(request.To, "Usuario"), request.Subject, plainTextContent, request.Message);
                var response = await client.SendEmailAsync(msg);
                return "Mail Sent!";
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
