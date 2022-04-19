namespace Net_Core_MVC_Library.Models
{
    public class Operations:BaseEntity
    {
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Student Student { get; set; } = default!;
        public Book Book { get; set; } = default!;
    }
}
