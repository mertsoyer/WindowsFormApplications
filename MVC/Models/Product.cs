using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_MVC_BookStore.Models
{
    //Data  Annotations
    /* [Table("Ürünler")]*/  // database adımızı duzenlıyoruz. Tablomuz Product olarak degil Ürünler adıyla database acılacak
    public class Product : BaseEntity
    {
        //[Column("Ürün İsmi", TypeName = "nvarchar(50)")]
        public string ProductName { get; set; }
        //[Column("Birim Fiyat")]
        // ? boş geçilebilir anlamında
        [Column(TypeName = "numeric(18,1")]
        public decimal? UnitPrice { get; set; }
        //[Column("Stok Miktarı")]
        public short UnitInStock { get; set; }
        //[Column("Kategori ID")]
        public int CAtegoryId { get; set; }

        //Relational prop

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
