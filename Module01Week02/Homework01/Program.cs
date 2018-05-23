using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {

        public static string GetBirthDate(int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {

            string format = "dd/MM/yyyy";
            DateTime birthDate = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            return birthDate.ToString(format);

        }

        public static int GetAge(int yearOfBirth)
        {

            var today = DateTime.Today;
            var age = today.Year - yearOfBirth;
            return age;

        }

        public enum Gender
        {

            Male,
            Female

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Input year:");
            int yearOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input month:");
            int monthOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input day:");
            int dayOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Your birthdate: {GetBirthDate(yearOfBirth, monthOfBirth, dayOfBirth)} and your age: { GetAge(yearOfBirth)}");

            Console.WriteLine("Input gender: (M/F)");
            char gender = Convert.ToChar(Console.ReadLine());

            int? inputGender;

            if (gender == 'M')
            {

                Gender selectedGender = Gender.Male;
                inputGender = (int)selectedGender;

            }

            else if (gender == 'F')
            {

                Gender selectedGender = Gender.Female;
                inputGender = (int)selectedGender;
            }

            else

                inputGender = null;

            switch (inputGender)
            {

                case 0:
                    if (GetAge(yearOfBirth) >= 65)

                        Console.WriteLine("Retired.");

                    else

                        Console.WriteLine($"{65 - GetAge(yearOfBirth)} years left until retirement.");

                    break;

                case 1:
                    if (GetAge(yearOfBirth) >= 63)

                        Console.WriteLine("Retired.");

                    else

                        Console.WriteLine($"{63 - GetAge(yearOfBirth)} years left until retirement.");

                    break;

                case null:
                    Console.WriteLine("Wrong input format: M/F.");
                    break;

            }

            Console.ReadKey();

        }
    }
}
