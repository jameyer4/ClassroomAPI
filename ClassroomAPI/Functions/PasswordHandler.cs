using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Functions
{
    public class PasswordHandler
    {
        //BCrypt - http://derekslager.com/blog/posts/2007/10/bcrypt-dotnet-strong-password-hashing-for-dotnet-and-mono.ashx
        public PasswordHandler()
        {

        }
        public string SetPassword(string userPassword)
        {
            string pwdToHash = userPassword + "13-TT"; // ^Y8~JJ is my hard-coded salt
            string hashToStoreInDatabase = BCrypt.HashPassword(pwdToHash, BCrypt.GenerateSalt());
            return hashToStoreInDatabase;
        }

        public bool DoesPasswordMatch(string hashedPwdFromDatabase, string userEnteredPassword)
        {
            return BCrypt.CheckPassword(userEnteredPassword + "13-TT", hashedPwdFromDatabase);
        }
    }
}