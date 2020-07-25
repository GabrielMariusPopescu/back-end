using DesignPatterns.Business.ObserverPattern.Contracts;
using DesignPatterns.Business.ObserverPattern.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class ObserverPatternTests
    {
        [SetUp]
        public void Init()
        {
            australianSubscriber = new AustralianSubscriber();
            romanianSubscriber = new RomanianSubscriber();
            unitedKingdomSubscriber = new UnitedKingdomSubscriber();
        }

        [Test]
        public void AustraliaSubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { australianSubscriber });
            weather.Subscribe(australianSubscriber);
            Assert.AreEqual("Australian subscriber", australianSubscriber.Name);
            Assert.AreEqual("Australian subscriber subscribed!", weather.Message);
        }

        [Test]
        public void RomaniaSubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { romanianSubscriber });
            weather.Subscribe(romanianSubscriber);
            Assert.AreEqual("Romanian subscriber", romanianSubscriber.Name);
            Assert.AreEqual("Romanian subscriber subscribed!", weather.Message);
        }

        [Test]
        public void UnitedKingdomSubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { unitedKingdomSubscriber });
            weather.Subscribe(unitedKingdomSubscriber);
            Assert.AreEqual("United Kingdom subscriber", unitedKingdomSubscriber.Name);
            Assert.AreEqual("United Kingdom subscriber subscribed!", weather.Message);
        }

        [Test]
        public void AustraliaUnsubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { australianSubscriber });
            weather.Unsubscribe(australianSubscriber);
            Assert.AreEqual("Australian subscriber", australianSubscriber.Name);
            Assert.AreEqual("Australian subscriber unsubscribed!", weather.Message);
        }

        [Test]
        public void RomaniaUnsubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { romanianSubscriber });
            weather.Unsubscribe(romanianSubscriber);
            Assert.AreEqual("Romanian subscriber", romanianSubscriber.Name);
            Assert.AreEqual("Romanian subscriber unsubscribed!", weather.Message);
        }

        [Test]
        public void UnitedKingdomUnsubscribe()
        {
            IWeather weather = new Weather(new List<ISubscriber> { unitedKingdomSubscriber });
            weather.Unsubscribe(unitedKingdomSubscriber);
            Assert.AreEqual("United Kingdom subscriber", unitedKingdomSubscriber.Name);
            Assert.AreEqual("United Kingdom subscriber unsubscribed!", weather.Message);
        }

        [Test]
        public void AustralianWeatherNotify()
        {
            IWeather weather = new Weather(new List<ISubscriber> { australianSubscriber });
            weather.Degree = 40;
            weather.Notify();
            Assert.AreEqual("It's normal out here!", australianSubscriber.Message);
        }

        [Test]
        public void RomanianWeatherNotify()
        {
            IWeather weather = new Weather(new List<ISubscriber> { romanianSubscriber });
            weather.Degree = -10;
            weather.Notify();
            Assert.AreEqual("It's freezing!", romanianSubscriber.Message);
        }

        [Test]
        public void UnitedKingdomWeatherNotify()
        {
            IWeather weather = new Weather(new List<ISubscriber> { unitedKingdomSubscriber });
            weather.Degree = 250;
            weather.Notify();
            Assert.AreEqual("It's roasting!", unitedKingdomSubscriber.Message);
        }

        //

        private ISubscriber australianSubscriber;
        private ISubscriber romanianSubscriber;
        private ISubscriber unitedKingdomSubscriber;
    }
}
