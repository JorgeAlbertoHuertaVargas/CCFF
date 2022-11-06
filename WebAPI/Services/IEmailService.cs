using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
