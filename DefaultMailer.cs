namespace Mocking
{
    public class DefaultMailer : IMailer
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool SendEmail(IMailClient mailClient)
        {
          
            return mailClient.SendEmail(this.From, this.To, this.Subject, this.Body);
        }
    
    }
}