namespace Mocking
{
    public interface IMailClient
    {
        string Server { get; set; }
        string Port { get; set; }
        bool SendEmail(string from, string to, string subject, string body);
    }
}