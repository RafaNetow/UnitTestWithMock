using System;
using System.Security.Cryptography.X509Certificates;

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
            #region Stub 
            mockEmailClient.Setup(client => client.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            IMailer mailer = new DefaultMailer() { From = "Acklen@mail.com", To = "rafanetow@mail.com", Subject = "Using Moq", Body = "Moq is awesome" };
            var result = mailer.SendEmail(mockEmailClient.Object);
            #endregion
            Assert.IsTrue(result);
            #region Mock
            mockEmailClient.Verify(client => client.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            #endregion

            #region Spy     
            //Spy
            // mockEmailClient.Verify(client => client.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(2));
            #endregion

        }

            #region Fake
            [Test]
            public void GetValidUser()
            {
                var handler = new FakeLoginService();
                var userId = handler.ValidateUser("rafa", "1234");
                Assert.AreEqual(userId, 5);
            }
            #endregion


    }
}
