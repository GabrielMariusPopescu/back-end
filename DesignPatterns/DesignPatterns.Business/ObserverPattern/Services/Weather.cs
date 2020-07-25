using DesignPatterns.Business.ObserverPattern.Contracts;
using System.Collections.Generic;

namespace DesignPatterns.Business.ObserverPattern.Services
{
    public class Weather : IWeather
    {
        public Weather(List<ISubscriber> observers)
        {
            this.observers = observers;
        }

        public string Message { get; private set; }

        public int Degree { get; set; }

        public void Subscribe(ISubscriber subscriber)
        {
            observers.Add(subscriber);
            Message = $"{subscriber.Name} subscribed!";
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            observers.Remove(subscriber);
            Message = $"{subscriber.Name} unsubscribed!";
        }

        public void Notify()
        {
            observers.ForEach(observer => observer.Update(this));
        }

        //

        private readonly List<ISubscriber> observers;
    }
}
