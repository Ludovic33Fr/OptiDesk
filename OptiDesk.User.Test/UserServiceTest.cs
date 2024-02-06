

using OptiDesk.User.Bll;

namespace OptiDesk.User.Test
{
    public class UserServiceTest
    {
        private UserService userSvc;

        [SetUp]
        public void Setup()
        {
            userSvc = new UserService();
        }

        [Test]
        public void GetUserByIdTest()
        {
            var testUser = userSvc.GetClient(3);
            Assert.NotNull(testUser);
            Assert.NotNull(testUser.NumSS);
            Assert.Pass();
        }

        [Test]
        public void GetAllUsersTest()
        {
            var testUsers = userSvc.GetAllClients();
            Assert.NotNull(testUsers);
            Assert.NotZero(testUsers.Count);
            Assert.Pass();
        }

        [Test]
        public void GetUsersTestByName()
        {
            var userNameSearch = "Clem";
            var testUsers = userSvc.GetClientsByName(userNameSearch);
            Assert.NotNull(testUsers);
            Assert.NotZero(testUsers.Count);

            foreach (var testUser in testUsers)
            {
                Assert.IsTrue(testUser.name.Contains(userNameSearch));
            }

            Assert.Pass();
        }

    }
}