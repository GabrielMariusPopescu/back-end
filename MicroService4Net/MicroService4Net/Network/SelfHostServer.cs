using System;
using System.Linq;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace MicroService4Net.Network
{
    public class SelfHostServer : IDisposable
    {
        private readonly HttpSelfHostServer server;

        public SelfHostServer(string uri, bool callControllersStaticConstructorsOnInit = true)
        {
            var config = new HttpSelfHostConfiguration(uri);

            config.MapHttpAttributeRoutes();

            config.EnableCors();
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            server = new HttpSelfHostServer(config);

            if (callControllersStaticConstructorsOnInit)
                CallControllersStaticConstructors();
        }


        public void Connect()
        {
            try
            {
                server.OpenAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async void Dispose()
        {
            await server.CloseAsync();
        }

        private void CallControllersStaticConstructors()
        {
            var types = Assembly.GetEntryAssembly()?.DefinedTypes.Where(type => type.IsSubclassOf(typeof(ApiController)));

            if (types == null)
                return;

            foreach (var type in types)
                InvokeStaticConstructor(type);
        }

        private void InvokeStaticConstructor(TypeInfo type)
        {
            Activator.CreateInstance(type);
        }
    }
}
