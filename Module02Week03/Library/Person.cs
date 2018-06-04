using System;

namespace Library
{

    public class Person
    {
        private string FirstName;
        private string LastName;
        private string EMail;
        private DateTime BirthDate;

        public Person(string firstName, string lastName, string eMail, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.BirthDate = birthDate;
        }

    }

}
