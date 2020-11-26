using System;

namespace task4
{
    public struct Account
    {
        public string login;
        public string password;


        public bool Verify()
        {
            bool isCorrect = false;
            if (login == "root" && password == "GeekBrains")
            {
                isCorrect = true;
            }
            return isCorrect;
        }
    }
}
