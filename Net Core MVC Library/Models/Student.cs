using Net_Core_MVC_Library.Enums;

namespace Net_Core_MVC_Library.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; } = default!;
        public int PhoneNumber { get; set; }

        //relational prop

        public List<Operations> Operations { get; set; }
        public virtual StudentDetail StudentDetail { get; set; }


    }
}
