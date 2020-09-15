using FindMethods.BL.Expressions;
using FindMethods.BL.Implementation;
using System.Collections.Generic;
using System.Linq;

namespace FindMethods.BL
{
    public class Worker
    {
        public Worker()
        {
            regEx = new RegularExpressions();
        }

        public List<List<Definition>> CreateDefinitions(List<string> lines)
        {
            var mainList = new List<List<Definition>>();
            foreach (var line in lines)
            {
                var definitions = new List<Definition>();

                //TODO: The logic below needs to change
                definitions.AddRange(lines
                  .Select(it => line.Trim())
                  .Select(WorkerProcessor.SetDefinition)
                  .Where(definition => !(definition.Type == DefinitionType.XmlComments && definition.Line == ""))
                  .ToList());

                mainList.Add(definitions);
            }
            return mainList;
        }

        public List<List<string>> EliminateUnknownDefinitions(List<List<Definition>> mainList)
        {
            return mainList
              .Select(definitions => definitions.Where(definition => definition.Type != DefinitionType.Unknown)
                .Where(definition => definition.Line != "//")
                .Select(definition => definition.Type + ": " + Trimmed(definition.Line))
                .ToList())
              .ToList();
        }

        //
        private readonly RegularExpressions regEx;

        private string Trimmed(string line)
        {
            if (line.EndsWith(";"))
                return line.TrimEnd(';');
            return line.EndsWith("{")
              ? line.TrimEnd('{')
              : line;
        }
    }
}