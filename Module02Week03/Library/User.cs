using System;

namespace Library
{

    public class User : Person
    {
        private string UserId;
        private string Password;

        public User(string firstName, string lastName, string eMail, DateTime birthDate) : base(firstName, lastName, eMail, birthDate)
        {
            this.UserId = CreateUserId(firstName, lastName);
            this.Password = RequestPassword();
        }

        private string RequestPassword()
        {
            Console.Write("Provide your user password: ");
            string userPassword = Console.ReadLine();
            return userPassword;
        }

        private string CreateUserId(string firstName, string lastname)
        {
            string userId = firstName + " " + lastname;
            return userId;
        }

        public override string ToString()
        {
            return $"{this.UserId}";
        }
    }
}

