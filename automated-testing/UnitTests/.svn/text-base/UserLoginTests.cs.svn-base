using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using Rhino.Mocks;
using UserDemo;


namespace UnitTests
{   
    [TestFixture]
    public class UserLoginTests
    {
        private IUserRepository _repository;

        [TestFixtureSetUp]
        public void FixtureSetupUp()
        {
            
        }

        [SetUp]
        public void SetUp()
        {
            _repository = MockRepository.GenerateStub<IUserRepository>();
        }


        private UserLoginService CreateSUT()
        {
            return new UserLoginService(_repository);
        }
        [Test]
        public void ValidUserTest()
        {
            _repository.Stub(r => r.GetByUserName("user")).IgnoreArguments().Return(ObjectMother.ValidUser());
            var result = CreateSUT().Login(ObjectMother.UserNames.Valid, "Password");
            Assert.AreEqual(result.LoggedIn,true);
        }

        [Test]
        public void LockedOutUserTest()
        {
            var result = CreateSUT().Login(ObjectMother.UserNames.LockedOut, "Password");
            Assert.AreEqual(result.LoggedIn, false);
        }

        [Test]
        public void should_return_true_when_passing_username_and_and_password()
        {
            var result = CreateSUT().Login(ObjectMother.UserNames.Invalid, "Password");
            Assert.AreEqual(result.LoggedIn, false);
        }

        [Test]
        public void should_return_false_when_the_password_is_wrong()
        {
            var result = CreateSUT().Login(ObjectMother.UserNames.Valid, "wrong");
            Assert.AreEqual(result.LoggedIn, false);
        }
        
    }

    public class MockUserRepository : IUserRepository
    {
        public User UserToReturn { get; set; }
        public User GetByUserName(string username)
        {
            return UserToReturn;
        }
    }
}