namespace Net_Core_MVC_Library.Models
{
    public class BookType:BaseEntity
    {
        public string BookName { get; set; } = default!;
        public List<Book> Books { get; set; } = default!;
    }
}
