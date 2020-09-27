using DesignPatterns.Business.TemplateMethodPattern.Contracts;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Business.TemplateMethodPattern.Implementation
{
    public class PdfDataMiner : IDataMiner
    {
        public IEnumerable<string> StartMining(string file)
        {
            var reader = new PdfReader(file);
            var lines = new List<string>();
            for (var page = 1; page <= reader.NumberOfPages; page++)
            {
                var textFromPage = PdfTextExtractor.GetTextFromPage(reader, page);
                var items = textFromPage.Split('\n');
                lines.AddRange(items.Select(item => Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(item))).Where(line => !line.Equals(" ")));
            }

            reader.Close();
            return lines;
        }
    }
}
