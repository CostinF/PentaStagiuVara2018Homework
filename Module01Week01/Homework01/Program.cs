using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);
            int userNumber = 0;

            Console.WriteLine("Guess the number. Introduceti un numar intre 0 si 100: ");

            while (userNumber != randomNumber)
            {

                string str = Console.ReadLine();
                userNumber = int.Parse(str);

                if (userNumber > randomNumber)
                {
                    Console.WriteLine($"Numarul {userNumber} este prea mare. Introduceti alt numar: ");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine($"Numarul {userNumber} este prea mic. Introduceti alt numar: ");
                }
                else
                {
                    Console.WriteLine("Ai ghicit numarul. Felicitari!");
                    Console.ReadKey();
                }
            }
        }
    }
}

