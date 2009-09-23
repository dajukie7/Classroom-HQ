namespace ClassroomHQ.Models
{
    public class User : Entity
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}