using BootcampProje.Application.Models;
using System.Threading.Tasks;

namespace BootcampProje.Application.Interfaces
{
    public interface IEmailService
    {
        //MailRequest nesnesini alan ve e-postayı gönderen metodumuz
        Task SendEmailAsync(MailRequest mailRequest); 
    }
}
