namespace Net_Core_MVC_BookStore.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public virtual List<Product> Products { get; set; } = default!;

    }
}
