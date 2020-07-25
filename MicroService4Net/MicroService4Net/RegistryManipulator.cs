using Microsoft.Win32;

namespace MicroService4Net
{
    internal class RegistryManipulator
    {
        public RegistryManipulator(string serviceName)
        {
            serviceRegistryPath = @"SYSTEM\CurrentControlSet\services\" + serviceName;
        }

        internal void RemoveMinusServiceFromRegistry()
        {
            var key = Registry.LocalMachine.OpenSubKey(serviceRegistryPath, true);
            var path = key.GetValue(IMAGE_PATH).ToString().Replace(MINUS_SERVICE, "");
            key.SetValue(IMAGE_PATH, path);
            key.Close();
        }

        internal void AddMinusServiceToRegistry()
        {
            var key = Registry.LocalMachine.OpenSubKey(serviceRegistryPath, true);
            var path = key.GetValue(IMAGE_PATH) + MINUS_SERVICE;
            key.SetValue(IMAGE_PATH, path);
            key.Close();
        }

        //

        private readonly string serviceRegistryPath;
        private const string IMAGE_PATH = "ImagePath";
        private const string MINUS_SERVICE = " -service";

    }
}
