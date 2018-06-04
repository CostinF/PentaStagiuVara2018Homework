using Library;

namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userOption = Application.DisplayMenu();

                switch (userOption)
                {
                    case "1":
                        Application.createUser();
                        break;
                    case "2":
                        Application.createPost();
                        break;
                    case "3":
                        Application.returnPostList();
                        break;
                    case "4":
                        Application.returnUserList();
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}


