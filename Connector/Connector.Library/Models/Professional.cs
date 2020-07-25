namespace Connector.Library.Models
{
    public class Professional
    {
        public int Id { get; set; }
        public string EmployerName { get; set; }
        public string JobTitle { get; set; }

        public Professional(int id, string employerName, string jobTitle)
        {
            Id = id;
            EmployerName = employerName;
            JobTitle = jobTitle;
        }
    }
}
