namespace Net_Core_MVC_Library.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; } = default!;
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }
        public Author Author { get; set; } = default!;
        public BookType BookType { get; set; } = default!;
        public List<Operations> Operations { get; set; } = default!;
    }
}
