using MicroService4Net.Network;
using MicroService4Net.ServiceInternals;
using System;
using System.Reflection;
using System.ServiceProcess;

namespace MicroService4Net
{
    public class MicroService
    {
        public event Action OnServiceStarted;
        public event Action OnServiceStopped;

        public MicroService(int port = 8080, string serviceDisplayName = null, string serviceName = null)
        {
            this.port = port;

            var assemblyName = Assembly.GetEntryAssembly()?.GetName().Name;
            this.serviceDisplayName = serviceDisplayName ?? assemblyName;
            serviceName = serviceName ?? assemblyName;

            serviceManager = new WindowsServiceManager(this.serviceDisplayName);
            registryManipulator = new RegistryManipulator(serviceName);

            InternalService.OsStarted += Start;
            InternalService.OsStopped += Stop;
            ProjectInstaller.InitInstaller(this.serviceDisplayName, serviceName);

        }

        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                RunConsole();
                return;
            }

            switch (args[0])
            {
                case "-service":
                    RunService();
                    break;
                case "-install":
                    InstallService();
                    break;
                case "-uninstall":
                    UnInstallService();
                    break;
                default:
                    throw new Exception(args[0] + " is not a valid command!");
            }
        }

        //


        private readonly string serviceDisplayName;
        private readonly int port;
        private readonly WindowsServiceManager serviceManager;
        private readonly RegistryManipulator registryManipulator;
        private SelfHostServer selfHostServer;

        private void RunConsole()
        {
            Start();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            Stop();
        }

        private static void RunService()
        {
            ServiceBase[] servicesToRun = { new InternalService() };
            ServiceBase.Run(servicesToRun);
        }

        private void InstallService()
        {
            serviceManager.Install();
            registryManipulator.AddMinusServiceToRegistry();
            serviceManager.Start();
        }

        private void UnInstallService()
        {
            serviceManager.Stop();
            registryManipulator.RemoveMinusServiceFromRegistry();
            serviceManager.UnInstall();
        }

        private void Stop()
        {
            selfHostServer.Dispose();
            if (OnServiceStopped != null)
                OnServiceStopped.Invoke();
        }

        private void Start()
        {
            selfHostServer = new SelfHostServer("http://localhost:" + port);

            selfHostServer.Connect();
            Console.WriteLine("Service {0} started on port {1}", serviceDisplayName, port);
            if (OnServiceStarted != null)
                OnServiceStarted.Invoke();
        }
    }
}
