using Net_Core_MVC_BookStore.Enums;
using System.ComponentModel.DataAnnotations;

namespace Net_Core_MVC_BookStore.Models
{
    public abstract class BaseEntity
    {

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        // ID olarak adlandırılmış bir alan otomatik olarak sistem tarafından tanınır. fakat bunu biz manuel olarak [Key] data annotation u ile de yapabiliriz.Bu case de Id oldugu ıcın ekstradan bir [Key] yazmaya gerek yok.
        /*[Key]*/

        [Key]
        public int Id { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
