using BootcampProje.Application.Interfaces;
using BootcampProje.Application.Models;
using BootcampProje.Shared.SettingsModels;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;

namespace BootcampProje.Application.Services
{
    public class RealEmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        public RealEmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            //Bu alanda mailimizin gövdesini ve alıcı, gönderici, konu gibi alanları belirtiyoruz.
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_emailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
           
            builder.HtmlBody = mailRequest.Body; //gelen e postanın HTML kısmı
            email.Body = builder.ToMessageBody(); //add the attachment

            //Bu alanda da göndereceğimiz e-posta’nın sunucu tarafından doğrulanması için gereken Authentication bilgilerini
            //oluşturuyor ve gönderim işlemini yapıyoruz.
            using var smtp = new SmtpClient();  //SMTP/Gönderici bilgilerinin yer aldığı erişim/doğrulama bilgileri
            smtp.Connect(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_emailSettings.Mail, _emailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}


