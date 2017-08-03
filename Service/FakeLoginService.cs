namespace Mocking
{
    public class FakeLoginService : ILoginService
    {
        public int ValidateUser(string userName, string password)
        {
            return 5;
        }
    }
}