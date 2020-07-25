namespace Connector.Library.Models
{
    public class Educational
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public int YearGraduated { get; set; }

        public Educational(int id, string schoolName, int yearGraduated)
        {
            Id = id;
            SchoolName = schoolName;
            YearGraduated = yearGraduated;
        }
    }
}
