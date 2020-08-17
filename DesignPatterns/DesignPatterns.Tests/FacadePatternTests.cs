using DesignPatterns.Business.FacadePattern;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class FacadePatternTests
    {
        [SetUp]
        public void Init()
        {
            facade = new Converter();
        }

        [Test]
        public void FacadeIsCalledForAudioMixer()
        {
            facade.Convert<AudioMixer>();

            Assert.AreEqual("AudioMixer", facade.VideoFormat);
            Assert.AreEqual("AudioMixer has been converted with the filename AudioMixer", facade.Result);
        }

        [Test]
        public void FacadeIsCalledForBitrateMixer()
        {
            facade.Convert<BitrateReader>();

            Assert.AreEqual("BitrateReader", facade.VideoFormat);
            Assert.AreEqual("BitrateReader has been converted with the filename BitrateReader", facade.Result);
        }

        [Test]
        public void FacadeIsCalledForCodecFactory()
        {
            facade.Convert<CodecFactory>();

            Assert.AreEqual("CodecFactory", facade.VideoFormat);
            Assert.AreEqual("CodecFactory has been converted with the filename CodecFactory", facade.Result);
        }

        [Test]
        public void FacadeIsCalledForMpeg4CompressionCodec()
        {
            facade.Convert<Mpeg4CompressionCodec>();

            Assert.AreEqual("Mpeg4CompressionCodec", facade.VideoFormat);
            Assert.AreEqual("Mpeg4CompressionCodec has been converted with the filename Mpeg4CompressionCodec", facade.Result);
        }

        [Test]
        public void FacadeIsCalledForOggCompressionCodec()
        {
            facade.Convert<OggCompressionCodec>();

            Assert.AreEqual("OggCompressionCodec", facade.VideoFormat);
            Assert.AreEqual("OggCompressionCodec has been converted with the filename OggCompressionCodec", facade.Result);
        }

        [Test]
        public void FacadeIsCalledForVideoFile()
        {
            facade.Convert<VideoFile>();

            Assert.AreEqual("VideoFile", facade.VideoFormat);
            Assert.AreEqual("VideoFile has been converted with the filename VideoFile", facade.Result);
        }

        //

        private Converter facade;
    }
}
