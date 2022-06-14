using BootcampProje.Application.Interfaces;
using BootcampProje.Application.Models;
using System;
using System.Threading.Tasks;

namespace BootcampProje.Application.Services
{
    public class FakeEmailService : IEmailService
    {
        public Task SendEmailAsync(MailRequest mailRequest)
        {
            Console.WriteLine("Email is ready to send");
            Console.WriteLine($"ToAddress is {mailRequest.ToEmail} and subject is {mailRequest.Subject}");
            return Task.CompletedTask;
        }
    }
}
