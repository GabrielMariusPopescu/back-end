using System.Reflection;

namespace DesignPatterns.Business.FacadePattern
{
    public class Converter
    {
        public string VideoFormat { get; private set; }

        public string Result { get; private set; }

        public void Convert<T>()
            where T : new()
        {
            var format = new T();
            VideoFormat = format.GetType().Name;
            var propertyInfo = format.GetType().GetProperty("Filename", BindingFlags.Instance | BindingFlags.Public);
            var value = propertyInfo?.GetValue(format).ToString();
            Result = $"{VideoFormat} has been converted with the filename {value}";
        }
    }
}
