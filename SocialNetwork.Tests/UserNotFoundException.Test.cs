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
            UserService userService = new UserService();
            Assert.Throws<UserNotFoundException>(() => userService.FindByEmail("ThisEmailShouldNotBeInDataBase@mail.ru"));
        }
    }
}
