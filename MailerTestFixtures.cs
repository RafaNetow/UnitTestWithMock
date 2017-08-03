using System;
using Moq;
using Moq.Matchers;
using NUnit.Framework;

namespace Mocking
{
    [TestFixture]
    public class MailerTestFixtures
    {

        [Test]
        public void SendMailTestFixture()
        {
           var mockEmailClient = new Mock<IMailClient>();
            mockEmailClient.SetupProperty(client => client.Server, "Acklen.Server.com");
            mockEmailClient.SetupProperty(client => client.Port, "3000");
            mockEmailClient.Setup(client => client.SendMail(" ", "  ", " ", " ")).Returns(true);
            IMailer mailer = new DefaultMailer();
        }
    }

    public interface IMailer
    {
    }

    public class DefaultMailer : IMailer
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public bool SendMail(string @from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
