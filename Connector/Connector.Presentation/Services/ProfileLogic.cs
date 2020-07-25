using Connector.Library;
using Connector.Library.Models;
using Connector.Presentation.Resources1;
using System.Collections.Generic;
using System.Linq;

namespace Connector.Presentation.Services
{
    public class ProfileLogic
    {
        public ProfileLogic()
        {
            cities = new Cities();
        }

        public IList<string> Genders { get; } = new List<string> { "Male", "Female", "Unknown" };

        public IList<string> GetCitiesNTowns() =>
            cities.Dict.Select(kv => $"{kv.Key} {kv.Value}").ToList();


        public void Register(Educational educational) =>
            GlobalConfiguration.Connection.InsertEducational(educational);

        public void Register(Professional professional) =>
            GlobalConfiguration.Connection.InsertProfessional(professional);

        public void Register(UserProfile userProfile) =>
            GlobalConfiguration.Connection.InsertUserProfile(userProfile);

        //

        private readonly Cities cities;

        public IList<string> GetSchools()
        {
            throw new System.NotImplementedException();
        }

        public IList<string> GetEmployers()
        {
            throw new System.NotImplementedException();
        }
    }
}
