using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame.Models
{
    class Player
    {
        public Player()
        {
            this.Score = 0;
        }
        public int Score { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName ()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
