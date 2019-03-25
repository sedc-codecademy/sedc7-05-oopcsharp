using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public User()
        {

        }
        public User(string first, string last, string username, string password, Role role)
        {
            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            Role = role;
        }
    }

    public enum Role
    {
        Admin,
        Trainer,
        Student
    }
}
