using Connector.Library;
using Connector.Library.Models;
using Connector.Presentation.Content;
using System.Collections.Generic;
using System.Linq;

namespace Connector.Presentation.Services
{
    public class MainLogic
    {
        public MainLogic()
        {
            domains = new Domains();
        }

        public bool IsDomainValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            if (value.StartsWith("@"))
                return false;

            if (value.Length < 4)
                return false;

            return value.Contains("@") && EmailDomains.Any(value.Contains);
        }

        public bool IsPasswordValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (value.Length < 4 || value.Length > 20)
                return false;

            return true;
        }

        public bool IsRegistered(string email)
        {
            var user = GlobalConfiguration.Connection.GetUsers().FirstOrDefault(it => it.Email == email);
            return user != null;
        }

        public void Register(User user) =>
            GlobalConfiguration.Connection.InsertUser(user);

        public User Login(string email, string password) =>
            GlobalConfiguration
            .Connection
            .GetUsers()
            .Where(u => u.Email == email)
            .FirstOrDefault(u => u.Password == password);

        //

        private readonly Domains domains;
        private IEnumerable<string> EmailDomains => domains.Get();
    }
}