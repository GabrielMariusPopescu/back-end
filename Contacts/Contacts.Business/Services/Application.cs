using System.Linq;
using System.Reflection;
using Contacts.Business.Contracts;

namespace Contacts.Business.Services
{
    public class Application : IApplication
    {
        public Application()
        {
            Assembly = Assembly.GetEntryAssembly();
        }

        public string GetName() => Assembly.CustomAttributes.ElementAt(3).ConstructorArguments[0].Value.ToString();

        public string GetLocation() => Assembly.Location;

        public string SetDecoration() => new string('=', GetName().Length);


        //

        private Assembly Assembly { get; }
    }
}
