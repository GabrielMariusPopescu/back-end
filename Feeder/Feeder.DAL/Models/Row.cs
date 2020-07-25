namespace Feeder.DAL.Models
{
    public class Row
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Row(int id, string firstName, string middleName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;

        }
    }
}
