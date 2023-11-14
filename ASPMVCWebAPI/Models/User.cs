namespace ASPMVCWebAPI.Models
{
    public class User
    {
        public User(int id, string email, string firstname, string lastname)
        {
            Id = id;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
        }

        public int Id { get; set; }

        public string Email { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
