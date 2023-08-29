using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Exceptions;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class SomeTest
    {
        [Test]
        public void Test()
        {
            Assert.Throws<UserNotFoundException>(() => new UserService().FindByEmail("ThisEmailShouldNotBeInDataBase@mail.ru"));
        }
    }
}
