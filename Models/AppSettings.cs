namespace CMSRestAPI.Models
{
    public class AppSettings
    {
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public bool EnableSSL { get; set; }
        public string EmailID { get; set; }
        public string EmailPassword { get; set; }
        public string TemplatesPath { get; set; }
        public string LogLocation { get; set; }

    }
}
