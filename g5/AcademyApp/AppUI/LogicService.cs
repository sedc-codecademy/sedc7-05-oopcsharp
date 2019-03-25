using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    public class LogicService
    {
        public User LogIn(string userName, string password, List<User> users)
        {
            try
            {
                var found = users.Where(x => x.Username == userName).First();
                return found;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No user like that in our DataBase!");
                return null;
            }
        }
    }
}
