using System;
using System.Collections.Generic;

namespace SedcSimulator
{
    public class Lecturer: Person
    {
        public int YearsExperience { get; set; }
        public List<string> Expertises { get; set; }
        public List<DayOfWeek> Availability { get; set; }

        public override string GetFullName()
        {
            var parent = base.GetFullName();
            return $"{parent} is available for {Availability.Count} days";
        }

        public Lecturer(string firstName, string lastName, List<DayOfWeek> availability)
            :base(firstName, lastName)
        {
            Availability = availability;
        }
    }
}