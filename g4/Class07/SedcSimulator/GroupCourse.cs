using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcSimulator
{
    class GroupCourse
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public string Subject { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Lecturer Lecturer { get; set; }
        public Assistant Assistant { get; set; }


    }
}
