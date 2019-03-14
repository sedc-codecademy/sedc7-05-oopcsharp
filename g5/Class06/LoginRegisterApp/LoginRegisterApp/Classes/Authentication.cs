using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisterApp.Classes
{
    class Authentication
    {
        private static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.ToLower() == username.ToLower() && user.Password == password) return user;
            }
            return null;
        }

        public static void Login(User[] users, string username, string password)
        {
            User user = FindUser(users, username, password);

            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Welcome {user.Username}!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Your messages:");

            foreach (string message in user.Messages)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("-------------------------");
        }

        public static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username, password);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User() { Id = id, Username = username, Password = password };

            Console.WriteLine("Successfully registered!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Users registered so far:");
            Console.WriteLine("-------------------------");

            foreach (User u in users)
            {
                Console.WriteLine($"Id: {u.Id}, Username: {u.Username}");
            }

            Console.WriteLine("-------------------------");
        }

    }
}
