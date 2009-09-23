using System.Collections.Generic;

namespace ClassroomHQ.Models
{
    public class Student : User
    {
        public Student()
        {
            Courses = new List<Course>();
        }

        public virtual School School { get; set; }

        public virtual IList<Course> Courses { get; set; }
    }
}