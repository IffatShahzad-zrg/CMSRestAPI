namespace CMSRestAPI.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string cc, string subject, string body, string attachmentPathOrUrl = null);
    }

}
