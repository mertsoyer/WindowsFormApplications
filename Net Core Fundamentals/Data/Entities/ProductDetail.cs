namespace Net_Core_Fundamentals.Data.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
