using System;
using System.Collections.Generic;

namespace SedcSimulator
{
    public class Lecturer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public int YearsExperience { get; set; }
        public List<string> Expertises { get; set; }
        public List<DayOfWeek> Availability { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName} is available for {Availability.Count} days";
        }

        public Lecturer(string firstName, string lastName, List<DayOfWeek> availability)
        {
            FirstName = firstName;
            LastName = lastName;
            Availability = availability;
        }
    }
}