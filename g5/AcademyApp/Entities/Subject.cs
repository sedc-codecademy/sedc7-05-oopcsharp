using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subject
    {
        public string Title { get; set; }
        public List<Student> EnroledStudents { get; set; }
        public Subject(string title)
        {
            Title = title;
        }
    }
}
