using Inheritance.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Programmer : Human
    {
        public string Language { get; set; }
        public int YearsOfExperience { get; set; }
        public Title Title { get; set; }

        public Programmer(Title title, string language, int exp, string name, int age) : base(name, age)
        {
            Title = title;
            Language = language;
            YearsOfExperience = exp;
        }

        public override string PrintInfo()
        {
            return $"{base.PrintInfo()} and I'm {Language} programmer" +
                $" with {YearsOfExperience} year of experience. ";
        }

        public override string ToString()
        {
            return $"{base.PrintInfo()} " +
                $"and I'm {Title} {Language} programmer" +
                $" with {YearsOfExperience} year of experience. ";
        }

    }
}
