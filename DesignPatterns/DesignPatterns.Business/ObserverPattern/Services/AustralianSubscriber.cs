﻿using DesignPatterns.Business.ObserverPattern.Contracts;

namespace DesignPatterns.Business.ObserverPattern.Services
{
    public class AustralianSubscriber : ISubscriber
    {
        public string Name => "Australian subscriber";

        public string Message { get; private set; }

        public void Update(IWeather weather)
        {
            if (weather.Degree > 30 || weather.Degree < 50)
            {
                Message = "It's normal out here!";
            }
        }
    }
}
