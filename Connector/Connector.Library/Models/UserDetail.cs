namespace Connector.Library.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }

        public UserDetail() { }

        public UserDetail(string firstName, string lastName, int userId, bool isAdmin)
        {
            FirstName = firstName;
            LastName = lastName;
            UserId = userId;
            IsAdmin = isAdmin;
        }

    }
}
