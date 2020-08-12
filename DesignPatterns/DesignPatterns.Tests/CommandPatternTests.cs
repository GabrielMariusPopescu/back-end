using DesignPatterns.Business.CommandPattern.Contracts;
using DesignPatterns.Business.CommandPattern.Models;
using DesignPatterns.Business.CommandPattern.Services;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class CommandPatternTests
    {
        [SetUp]
        public void Init()
        {
            light = new Light();
        }

        [Test]
        public void TurnOnCommandInvoked()
        {
            command = new TurnOnCommand(light);

            command.Do();

            Assert.AreEqual("Light is turned on.", light.State);

            command.Undo();

            Assert.AreEqual("Light is turned off.", light.State);
        }

        [Test]
        public void TurnOffCommandInvoked()
        {
            command = new TurnOffCommand(light);

            command.Do();

            Assert.AreEqual("Light is turned off.", light.State);

            command.Undo();

            Assert.AreEqual("Light is turned on.", light.State);
        }

        [Test]
        public void DimCommandInvoked()
        {
            command = new DimCommand(light);

            command.Do();

            Assert.AreEqual("Light is dimmed.", light.State);

            command.Undo();

            Assert.AreEqual("Light is brighter.", light.State);
        }

        [Test]
        public void BrightCommandInvoked()
        {
            command = new BrightCommand(light);

            command.Do();

            Assert.AreEqual("Light is brighter.", light.State);

            command.Undo();

            Assert.AreEqual("Light is dimmed.", light.State);
        }

        //

        private Light light;
        private ICommand command;
    }
}
