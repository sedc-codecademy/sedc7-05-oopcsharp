using LoginRegisterApp.Classes;
using System;

namespace LoginRegisterApp
{
    class Program
    {
        /*
            Create a program that will represent User Login and Register functionalities
            - The User should have two options : 
                1) Log in 
                2) Register
            - If a user is successfully logged in, it should show his messages
                e.g. Your messages: "Some message here"
            - Note: Provide basic Login and Register validation

        */
        public static bool UsersLoginRegister(User[] users)
        {
            Console.WriteLine("Choose: \n1) Log in \n2)Register");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);

            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                return false;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    Authentication.Login(users, username, password);
                    return true;
                case 2:
                    Console.Write("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Username: ");
                    string newUsername = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string newPassword = Console.ReadLine();
                    Authentication.Register(users, newUsername, newPassword, id);
                    return true;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    return false;
            }
        }

        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User(){Id = 24, Username = "Bob23", Password = "mysuperpass", Messages = new string[]{"Hey bob! Nice shirt.", "Call me pls!" } },
                new User(){Id = 12, Username = "Jill_awesome", Password = "123456", Messages = new string[]{"How are ya? Call me", "When will you go to work?", "Your card is ready!" }},
                new User(){Id = 5, Username = "GregGregsky", Password = "lozinka", Messages = new string[]{"Come to my party tomorrow!", "Drunk message. Please don't take it seriously." }}
            };
            while (!UsersLoginRegister(users)) ;
            Console.ReadLine();
        }
    }
}