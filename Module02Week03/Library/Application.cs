using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Library
{

    public class Application
    {
        static List<object> userList = new List<object>();
        static List<object> userPosts = new List<object>();

        public static string DisplayMenu()
        {
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Post a message");
            Console.WriteLine("3. Display posts");
            Console.WriteLine("4. Display users");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Choose one of the above options: ");
            string userOption = Console.ReadLine();
            return userOption;
        }

        public static void createUser()
        {
            Console.WriteLine();
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your E-Mail address: ");
            string eMail = Console.ReadLine();
            Console.Write("Enter your birthdate (dd/MM/yyyy): ");
            string format = "dd/MM/yyyy";
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            User user = new User(firstName, lastName, eMail, birthDate);
            userList.Add(user);
            Console.WriteLine();
            Console.WriteLine("Account created sucessfully!");
            Console.WriteLine();
        }

        public static void createPost()
        {
            Console.Write("Enter your post: ");
            string postBody = Console.ReadLine();

            Application.returnUserList();
            Console.Write("Enter the number of one of the authors listed above: ");
            int selectedUser = int.Parse(Console.ReadLine());

            DisplayPost post = new DisplayPost(postBody, userList.ElementAt(selectedUser - 1).ToString(), DateTime.Now);
            userPosts.Add(post);
            Console.WriteLine();
            Console.WriteLine("Post added sucessfully!");
            Console.WriteLine();
        }

        public static bool returnUserList()
        {
            int counter = 1;
            Console.WriteLine();
            foreach (object user in userList)
            {
                Console.WriteLine(counter + ". " + user.ToString());
                counter += 1;
            }
            Console.WriteLine();
            return true;
        }

        public static bool returnPostList()
        {
            int counter = 1;
            Console.WriteLine();
            foreach (object post in userPosts)
            {
                Console.WriteLine(counter + " - " + post.ToString());
                counter += 1;
            }
            Console.WriteLine();
            return true;
        }

    }




}

