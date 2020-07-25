using DesignPatterns.Business.ObserverPattern.Contracts;

namespace DesignPatterns.Business.ObserverPattern.Services
{
    public class RomanianSubscriber : ISubscriber
    {
        public string Name => "Romanian subscriber";

        public string Message { get; private set; }

        public void Update(IWeather weather)
        {
            if (weather.Degree < 0)
            {
                Message = "It's freezing!";
            }
        }
    }
}
