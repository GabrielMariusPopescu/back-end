using System.Collections.Generic;
using System.Linq;
using Contacts.Business.Contracts;
using Contacts.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contacts.Business.Tests
{
    [TestClass]
    public class FileProcessorTests
    {
        [TestInitialize]
        public void Setup()
        {
            fileProcessor = new FileProcessor();
            directories = fileProcessor.GetOneDriveDirectories();
            files = fileProcessor.GetFiles(directories);
            numbers = new[] { 11, 9, 2409 };
        }

        [TestMethod]
        public void GetDirectoriesReturnsOneDriveDirectories()
        {
            Assert.AreEqual(numbers[0], directories.Count());
        }

        [TestMethod]
        public void GetFilesReturnsContactFiles()
        {
            Assert.AreEqual(numbers[1], files.Count());
        }

        [TestMethod]
        public void ReadReturnsAllLines()
        {
            var lines = fileProcessor.Read(files);
            Assert.AreEqual(numbers[2], lines.Select(line => line.Length).Sum());
        }

        [TestMethod]
        public void SeparateFilesReturnsDictionary()
        {
            var lines = fileProcessor.Read(files);

            var actual = fileProcessor.SeparateFiles(lines);
            Assert.AreEqual(numbers[1], actual.Keys.Count);
            Assert.AreEqual(numbers[2] - numbers[1], actual.Values.Select(it => it.Count()).Sum());
        }

        //

        private IFileProcessor fileProcessor;
        private IEnumerable<string> directories;
        private IEnumerable<string> files;
        private int[] numbers;
    }
}
