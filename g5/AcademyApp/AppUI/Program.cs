using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data and Services
            LogicService logicService = new LogicService();
            UIService uiService = new UIService();

            List<Subject> subjectsDB = new List<Subject>()
            {
                new Subject("Math"),
                new Subject("Science"),
                new Subject("English"),
                new Subject("Sports"),
                new Subject("Art")
            };
            List<Student> studentsDB = new List<Student>()
            {
                new Student("Bob", "Bobsky", "bob88", "bobisbest", new Dictionary<Subject, int>(){
                    {subjectsDB[0], 4 },
                    {subjectsDB[1], 5 },
                    {subjectsDB[2], 2 }
                }, subjectsDB[3]),
                new Student("Jill", "Wayne", "jillAwesome", "123456", new Dictionary<Subject, int>(){
                    {subjectsDB[2], 2 },
                    {subjectsDB[3], 1 },
                    {subjectsDB[4], 5 }
                }, subjectsDB[1]),
                new Student("Greg", "Gregsky", "gregisha", "lozinka", new Dictionary<Subject, int>(){
                    {subjectsDB[1], 4 },
                    {subjectsDB[2], 5 },
                    {subjectsDB[4], 2 }
                }, subjectsDB[0]),
            };

            subjectsDB[0].EnroledStudents = new List<Student>() { studentsDB[0], studentsDB[2] };
            subjectsDB[1].EnroledStudents = new List<Student>() { studentsDB[0], studentsDB[2] };
            subjectsDB[2].EnroledStudents = new List<Student>() { studentsDB[0], studentsDB[1], studentsDB[2] };
            subjectsDB[3].EnroledStudents = new List<Student>() { studentsDB[0], studentsDB[1] };
            subjectsDB[4].EnroledStudents = new List<Student>() { studentsDB[1], studentsDB[2] };

            Student currentStudent = null;
            List<User> usersDB = new List<User>()
            {
                studentsDB[0],
                studentsDB[1],
                studentsDB[2],
                new User("Dejan", "Jovanov", "ninja", "nedirajlavadokspava", Role.Admin),
                new User("Anne", "Willson", "anne22", "itsokay", Role.Trainer),
                new User("Tom", "Jerry", "tomidzeri", "coolmouse", Role.Trainer)
            };
            #endregion

            int roleChoice = uiService.LoginChoice();
            User loggedIn = uiService.LoginForm(usersDB);
            if (loggedIn.Role == Role.Student) currentStudent = studentsDB.Where(x => x.Username == loggedIn.Username).FirstOrDefault();

            int userChoice = 0;
            switch (roleChoice)
            {
                case 1:
                    while (true)
                    {
                        Console.Clear();
                        userChoice = uiService.AdminChoice();
                        if (userChoice == 1)
                        {
                            Console.WriteLine("Please enter the needed information about a user:");
                            User newUser = uiService.AddUserForm();
                            usersDB.Add(newUser);
                            if (newUser.Role == Role.Student) studentsDB.Add((Student)newUser);
                            Console.WriteLine("User was added!");
                            Console.ReadLine();
                            break;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("Please enter the username of the person you want to remove:");
                            string username = Console.ReadLine();
                            User found = usersDB.Where(x => x.Username == username).FirstOrDefault();
                            bool removed = usersDB.Remove(found);
                            if(found != null && found.Role == Role.Student)
                            {
                                studentsDB.Remove(studentsDB.Where(x => x.Username == username).FirstOrDefault());
                            }
                            if (removed) Console.WriteLine("User has been removed!");
                            else Console.WriteLine("There was no such user!");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a correct number.");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    while (true)
                    {
                        Console.Clear();
                        userChoice = uiService.TrainerChoice();
                        if (userChoice == 1)
                        {
                            uiService.ShowStudents(usersDB.Where(x => x.Role == Role.Student).ToList());
                            break;
                        } else if (userChoice == 2)
                        {
                            uiService.ShowSubjects(subjectsDB);
                            break;
                        } else
                        {
                            Console.WriteLine("Please enter a correct number.");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    userChoice = uiService.StudentChoice();
                    while (true)
                    {
                        if(userChoice == 1)
                        {
                            Console.WriteLine("Enroll in a subject:");
                            int studentChoice = uiService.ChooseSubject(subjectsDB);
                            currentStudent.Enroll(subjectsDB[studentChoice - 1]);
                            subjectsDB[studentChoice - 1].EnroledStudents.Add(currentStudent);
                            Console.WriteLine($"You enroled in {subjectsDB[studentChoice - 1].Title}!");
                            break;
                        }
                        else if (userChoice == 2)
                        {
                            currentStudent.ShowGrades();
                            break;
                        } else
                        {
                            Console.WriteLine("Please enter a correct number.");
                            Console.ReadLine();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Something went wrong! Please restart the application!");
                    Console.ReadLine();
                    return;
            }
            Console.ReadLine();

        }
    }
}
