
using System.Text;

namespace AutomatedTests
{
    class UserTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void UserSetFirstName()
        {
            User user = new User();
            string testFirstName = "Test First Name";
            user.FirstName = testFirstName;
            Assert.That(user.FirstName, Is.EqualTo(testFirstName));
        }

        [Test]
        public void UserSetSurname()
        {
            User user = new User();
            string testSurname = "Test Surname";
            user.Surname = testSurname;
            Assert.That(user.Surname, Is.EqualTo(testSurname));
        }

        [Test]
        public void UserSetEmail()
        {
            User user = new User();
            string testEmail = "Test Email";
            user.Email = testEmail;
            Assert.That(user.Email, Is.EqualTo(testEmail));
        }

        [Test]
        public void UserSetPassword()
        {
            User user = new User();
            string testPassword = "Test Password";
            user.Password = testPassword;
            Assert.That(user.Password, Is.EqualTo(testPassword));
        }

        [Test]
        public void UserSetSalt()
        {
            User user = new User();
            byte[] testSalt = Encoding.ASCII.GetBytes("qwertyu!@#$%^&1234567");
            user.Salt = testSalt;
            Assert.That(user.Salt, Is.EqualTo(testSalt));
        }

        [Test]
        public void UserSetPhoneNumber()
        {
            User user = new User();
            string testPhoneNumber = "999999999";
            user.PhoneNumber = testPhoneNumber;
            Assert.That(user.PhoneNumber, Is.EqualTo(testPhoneNumber));
        }
    }
}
