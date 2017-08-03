    namespace Mocking
{
    public interface IMailer
    {
        string From { get; set; }
        string To { get; set; }
        string Subject { get; set; }
        string Body { get; set; }

        bool SendEmail(IMailClient mailClient);
    }
}