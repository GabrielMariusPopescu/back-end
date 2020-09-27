using DesignPatterns.Business.TemplateMethodPattern.Contracts;
using DesignPatterns.Business.TemplateMethodPattern.Implementation;
using NUnit.Framework;
using System.Linq;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class TemplateMethodPatternTests
    {

        [Test]
        public void ReadCsv()
        {
            IDataMiner dataMiner = new CsvDataMiner();
            var csv = dataMiner.StartMining(@"C:\Users\GabyM\Documents\GitHub\back-end\DesignPatterns\DesignPatterns.Business\TemplateMethodPattern\Employees.csv");
            Assert.AreEqual(5, csv.Count());
        }

        [Test]
        public void ReadPdf()
        {
            IDataMiner dataMiner = new PdfDataMiner();
            var pdf = dataMiner.StartMining(@"C:\Users\GabyM\Documents\GitHub\back-end\DesignPatterns\DesignPatterns.Business\TemplateMethodPattern\Employees.pdf");
            Assert.AreEqual(5, pdf.Count());
        }
    }
}
