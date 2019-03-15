using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Animal
    {
        public enum AnimalColors { Black, Brown, White };

        private string type;
        public string ReturnType()
        {
            return this.type;
        }
        public void SetType(string type)
        {
            this.type = type;
        }

        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name { get; set; }

        public AnimalColors Color { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(string Name)
        {
            Console.WriteLine("Animal Name Constructor");
            this.Name = Name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Animal ID={ID} Name={Name} Type={type} Color={Color}");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal Eat");
        }

        ~Animal()
        {
            Console.WriteLine("Animal Destructor");
            Console.ReadLine();
        }
    }
}
