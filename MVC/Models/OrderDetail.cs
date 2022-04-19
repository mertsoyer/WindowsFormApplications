using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_MVC_BookStore.Models
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        [Column(TypeName = "numeric(18,1")] //18 basamak ve virgülden sonra 1 basamak olacak sekılde ayarladık
        public decimal? TotalPrice { get; set; }

        //Relational prop

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
