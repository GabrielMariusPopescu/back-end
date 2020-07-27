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
            var subscribers = new List<ISubscriber> { australianSubscriber, romanianSubscriber, unitedKingdomSubscriber };
            weather = new Weather(subscribers);
            australianSubscriber = new AustralianSubscriber(weather);
            romanianSubscriber = new RomanianSubscriber(weather);
            unitedKingdomSubscriber = new UnitedKingdomSubscriber(weather);
        }

        [Test]
        public void EverybodySubscribed()
        {
            weather.Subscribe(australianSubscriber);
            Assert.AreEqual("Australian subscriber", australianSubscriber.Name);
            Assert.AreEqual("Australian subscriber subscribed!", weather.Message);
            weather.Subscribe(romanianSubscriber);
            Assert.AreEqual("Romanian subscriber", romanianSubscriber.Name);
            Assert.AreEqual("Romanian subscriber subscribed!", weather.Message);
            weather.Subscribe(unitedKingdomSubscriber);
            Assert.AreEqual("United Kingdom subscriber", unitedKingdomSubscriber.Name);
            Assert.AreEqual("United Kingdom subscriber subscribed!", weather.Message);
        }

        [Test]
        public void EverybodyUnsubscribed()
        {
            weather.Unsubscribe(australianSubscriber);
            Assert.AreEqual("Australian subscriber", australianSubscriber.Name);
            Assert.AreEqual("Australian subscriber unsubscribed!", weather.Message);
            weather.Unsubscribe(romanianSubscriber);
            Assert.AreEqual("Romanian subscriber", romanianSubscriber.Name);
            Assert.AreEqual("Romanian subscriber unsubscribed!", weather.Message);
            weather.Unsubscribe(unitedKingdomSubscriber);
            Assert.AreEqual("United Kingdom subscriber", unitedKingdomSubscriber.Name);
            Assert.AreEqual("United Kingdom subscriber unsubscribed!", weather.Message);
        }

        [Test]
        public void AustralianSubscriberIsNotified()
        {
            weather.Subscribe(australianSubscriber);
            weather.Degree = 40;
            weather.Notify();
            Assert.AreEqual("It's normal out here!", australianSubscriber.Message);
        }

        [Test]
        public void RomanianSubscriberIsNotified()
        {
            weather.Subscribe(romanianSubscriber);
            weather.Degree = -10;
            weather.Notify();
            Assert.AreEqual("It's freezing!", romanianSubscriber.Message);
        }

        [Test]
        public void EnglishSubscriberIsNotified()
        {
            weather.Subscribe(unitedKingdomSubscriber);
            weather.Degree = 250;
            weather.Notify();
            Assert.AreEqual("It's roasting!", unitedKingdomSubscriber.Message);
        }

        [Test]
        public void AustralianAndEnglishSubscribersAreNotified()
        {
            weather.Subscribe(unitedKingdomSubscriber);
            weather.Subscribe(australianSubscriber);
            weather.Degree = 40;
            weather.Notify();
            Assert.AreEqual("It's roasting!", unitedKingdomSubscriber.Message);
            Assert.AreEqual("It's normal out here!", australianSubscriber.Message);
        }

        //

        private IWeather weather;
        private ISubscriber australianSubscriber;
        private ISubscriber romanianSubscriber;
        private ISubscriber unitedKingdomSubscriber;
    }
}
