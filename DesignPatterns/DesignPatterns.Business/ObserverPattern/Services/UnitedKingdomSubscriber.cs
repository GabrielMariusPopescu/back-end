using DesignPatterns.Business.ObserverPattern.Contracts;

namespace DesignPatterns.Business.ObserverPattern.Services
{
    public class UnitedKingdomSubscriber : ISubscriber
    {
        public string Name => "United Kingdom subscriber";

        public string Message { get; private set; }

        public void Update(IWeather weather)
        {
            if (weather.Degree >= 20)
            {
                Message = "It's roasting!";
            }
        }
    }
}
