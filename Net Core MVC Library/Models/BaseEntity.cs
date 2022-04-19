using Net_Core_MVC_Library.Enums;

namespace Net_Core_MVC_Library.Models
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;

        }

        public int Id { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
