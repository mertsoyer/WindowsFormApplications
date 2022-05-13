namespace Net_Core_Fundamentals.Data.Entities
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //Navigation Prop
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
