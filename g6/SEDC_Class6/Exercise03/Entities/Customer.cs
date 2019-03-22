using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Entities
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private short Pin { get; set; }
        private int AccountBalance { get; set; }
        public Customer(string first, string last, long card, short pin, int balance)
        {
            FirstName = first;
            LastName = last;
            CardNumber = card;
            Pin = pin;
            AccountBalance = balance;
        }
        public bool CheckPin(short pin)
        {
            if (Pin == pin) return true;
            return false;
        }
        public int CheckAccount()
        {
            return AccountBalance;
        }
        public bool WithdrawFromAccount(int ammount)
        {
            if (ammount > AccountBalance) return false;
            AccountBalance -= ammount;
            return true;
        }
        public void DepositToAccount(int ammount)
        {
            AccountBalance += ammount;
        }
    }
}
