using DTOs.Users;
using NUnit.Framework;
using Repositories.Managers;


namespace Repositories.Integration.Tests
{
    [TestFixture]
    public class UserManagerSpecs : BaseSpecs
    {
        protected UserDto User;

        [OneTimeSetUp]
        public void SetUp()
        {
            User = new UserManager().GetUserById(1);
        }

        [Test]
        public void Should_load_user_id()
        {
            Assert.AreEqual(1, User.UserId);
        }

        [Test]
        public void Should_load_first_name()
        {
            Assert.AreEqual("Mihai", User.FirstName);
        }

        [Test]
        public void Should_load_last_name()
        {
            Assert.AreEqual("Smolenschi", User.LastName);
        }

        [Test]
        public void Should_load_user_attributes()
        {
            var attributes = User.UserAttributes;
            Assert.Multiple(() => {
                Assert.AreEqual("Romania", attributes[0].Value);
                Assert.AreEqual("Male", attributes[1].Value);
            });

        }
    }
}
