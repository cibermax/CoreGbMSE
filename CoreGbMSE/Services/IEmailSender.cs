using System.Threading.Tasks;

namespace CoreGbMSE.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
