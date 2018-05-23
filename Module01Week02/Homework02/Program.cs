using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Hello, World!";
            Console.WriteLine(text);

            Console.WriteLine("Press any key to start.");
            Console.ReadKey();

            //upper
            Console.WriteLine($"1. Uppercase: {text.ToUpper()}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //lower
            Console.WriteLine($"2. Lowercase: {text.ToLower()}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //length
            Console.WriteLine($"3. Length: {text.Length}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //split
            Console.WriteLine("4. Split on space:");
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //replace 
            Console.WriteLine($"5. Replace character l with x: {text.Replace("l", "x")}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //remove last character
            Console.WriteLine($"6. Remove last character: {text.Remove(text.Length - 1)}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //reverse
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            Console.Write("6. Reverse string:");
            Console.WriteLine(array);

            Console.WriteLine("Press any key to exit. :)");
            Console.ReadKey();

        }
    }
}
