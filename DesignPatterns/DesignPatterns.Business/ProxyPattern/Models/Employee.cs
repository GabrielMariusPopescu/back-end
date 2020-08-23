namespace DesignPatterns.Business.ProxyPattern.Models
{
    public class Employee
    {
        public string Username { get; }

        public string Role { get; }

        public Employee(string username, string role)
        {
            Username = username;
            Role = role;
        }
    }
}
