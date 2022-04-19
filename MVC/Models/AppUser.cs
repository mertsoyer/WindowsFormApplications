using Net_Core_MVC_BookStore.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_MVC_BookStore.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped] // RePassword alanının databasede bir kolon olarak açılmamasını yazdık.
        public string RePassword { get; set; }
        public Role Role { get; set; }
        // Relational Prop

        public virtual AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
