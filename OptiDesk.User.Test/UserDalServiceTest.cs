using OptiDesk.User.Dal;

namespace OptiDesk.User.Test
{
    public class UserDalServiceTest
    {
        private UserDalService dalSvc;

        [SetUp]
        public void Setup()
        {
            dalSvc = new UserDalService();
        }

        [Test]
        public void GetUserByIdTest()
        {
            var testUser = dalSvc.GetUser(3);
            Assert.NotNull(testUser);
            Assert.Pass();
        }

        [Test]
        public void GetAllUsersTest()
        {
            var testUsers = dalSvc.GetAllUser();
            Assert.NotNull(testUsers);
            Assert.NotZero(testUsers.Count);
            Assert.Pass();
        }

    }
}