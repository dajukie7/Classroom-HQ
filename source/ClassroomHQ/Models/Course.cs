using System.Collections.Generic;

namespace ClassroomHQ.Models
{
    public class Course : Entity
    {
        public Course()
        {
            Students = new List<Student>();
        }

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual School School { get; set; }
    }
}