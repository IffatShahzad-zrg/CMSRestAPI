using CMSRestAPI.Interfaces;
using CMSRestAPI.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

public class EmailSender : IEmailSender
{
    private readonly AppSettings _appSettings;

    public EmailSender(IOptions<AppSettings> appSetting)
    {
        _appSettings = appSetting.Value;
    }

    public async Task SendEmailAsync(string to, string cc, string subject, string body, string? attachmentPathOrUrl = null)
    {
        using var message = new MailMessage();
        message.From = new MailAddress(_appSettings.EmailID);
        message.To.Add(new MailAddress(to));

        if (!string.IsNullOrWhiteSpace(cc))
            message.CC.Add(new MailAddress(cc));

        message.Subject = subject;
        message.Body = body;
        message.IsBodyHtml = true;

        if (!string.IsNullOrEmpty(attachmentPathOrUrl))
        {
            Attachment attachment;

            if (attachmentPathOrUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                using var client = new HttpClient();
                var stream = await client.GetStreamAsync(attachmentPathOrUrl);
                attachment = new Attachment(stream, Path.GetFileName(attachmentPathOrUrl));
                message.Attachments.Add(attachment);
            }
            else if (File.Exists(attachmentPathOrUrl))
            {
                attachment = new Attachment(attachmentPathOrUrl);
                message.Attachments.Add(attachment);
            }
            // else: invalid path/URL, skip attachment silently or throw error
        }

        using var smtp = new SmtpClient(_appSettings.SmtpHost, _appSettings.SmtpPort)
        {
            Credentials = new NetworkCredential(_appSettings.EmailID, _appSettings.EmailPassword),
            EnableSsl = _appSettings.EnableSSL
        };

        await smtp.SendMailAsync(message);
    }
}
