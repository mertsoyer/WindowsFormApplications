namespace Net_Core_MVC_Library.DTO
{
    public class AuthorDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName+ " " + LastName;
            }
        }
    }
}
