using System.Net.Mail;
using Portfolio.Utilities;

namespace Portfolio.Email.Repositories;

public class EmailRepository : IEmailRepository
{
    private readonly SmtpClient _smtpClient;

    public EmailRepository(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public async Task<Response> SendAsync(MailMessage mailMessage)
    {
        try
        {
            await _smtpClient.SendMailAsync(mailMessage);
            return ResponseFactory.Ok();
        }
        catch (Exception ex)
        {
            return ResponseFactory.Fail(new Error("SendConfirmationEmailFailed", ex.Message));
        }
    }
}