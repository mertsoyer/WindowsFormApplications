namespace Net_Core_MVC_Library.Models
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;

        public List<Book> Books { get; set; } = default!;
    }
}
