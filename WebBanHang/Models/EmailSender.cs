using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebBanHang.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Implement your email sending logic here
            return Task.CompletedTask;
        }
    }
}
