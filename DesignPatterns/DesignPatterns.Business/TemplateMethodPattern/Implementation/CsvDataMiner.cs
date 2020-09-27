using DesignPatterns.Business.TemplateMethodPattern.Contracts;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Business.TemplateMethodPattern.Implementation
{
    public class CsvDataMiner : IDataMiner
    {
        public IEnumerable<string> StartMining(string file)
        {
            var lines = new List<string>();
            using (var fileStream = new FileStream(file, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    lines.Add(line);
                }

            return lines.Select(line => line).ToList();
        }
    }
}
