namespace Net_Core_MVC_Library.Models
{
    public class StudentDetail : BaseEntity
    {

        public int SchoolNumber { get; set; }
        public DateTime BirthDay { get; set; } = default!;
        public int PhoneNumber { get; set; }

        //foreign key
        public int StudentId { get; set; }

        //relational prop

        public virtual Student Student { get; set; }
    }
}
