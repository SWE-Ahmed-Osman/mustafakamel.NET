using System.Net.Mail;
using Portfolio.Utilities;

namespace Portfolio.Email.Repositories;

public interface IEmailRepository
{
    Task<Response> SendAsync(MailMessage mailMessage);
}