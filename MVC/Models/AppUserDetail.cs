namespace Net_Core_MVC_BookStore.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AppUserId { get; set; }

        //Relational Prop

        public AppUser AppUser { get; set; }
    }
}
