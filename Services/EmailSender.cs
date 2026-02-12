using Microsoft.AspNetCore.Identity.UI.Services;

namespace SmartCart_MVC_Project.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // No email sending for now (development mode)
            return Task.CompletedTask;
        }
    }
}
