namespace UserDemo
{
    public class UserLoginService
    {
        private IUserRepository _userRepository;

        public UserLoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public LoginResult Login(string username,string password)
        {
            var user = _userRepository.GetByUserName(username);
            if (user.IsInActive) return new LoginResult() {LoggedIn = false, Message = "User is Inactive"};
            if (user.IsLockedOut) return new LoginResult() {LoggedIn = false, Message = "User is Locked Out"};
            if (user.IsPasswordExpired) return new LoginResult() {LoggedIn = false, Message ="Password has expired"};
            if (user.Password != password) return new LoginResult() {LoggedIn = false, Message = "Wrong Password"};
            return new LoginResult() {LoggedIn = true, Message = string.Empty};
        }
    }

    public class LoginResult
    {
        public bool LoggedIn { get; set; }
        public string Message { get; set; }
    }
}