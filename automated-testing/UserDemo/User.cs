using System;
using System.Collections.Generic;
using System.Linq;

namespace UserDemo
{
    public class User
    {
        public DateTime PasswordExpirationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsInActive { get; set; }
        public bool IsPasswordExpired { get; set; }
        public bool IsLockedOut { get; set; }
        
    }
}