namespace Net_Core_MVC_BookStore.Models
{
    public class Order : BaseEntity
    {

        public int AppUserId { get; set; }
        //Relational Prop

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
