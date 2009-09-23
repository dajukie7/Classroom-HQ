using System.Collections.Generic;

namespace ClassroomHQ.Models
{
    public class Teacher : User
    {
        public Teacher()
        {
            Courses = new List<Course>();
        }

        public virtual School School { get; set; }

        public virtual IList<Course> Courses { get; set; }
    }
}