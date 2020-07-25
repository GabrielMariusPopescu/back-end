using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Feeder.BLL.Helpers;
using Feeder.DAL.Models;

namespace Feeder.BLL.Services
{
    public class TextDocument
    {
        public List<string> GetFiles()
        {
            return Directory
              .GetFiles(Constants.ROOT_FOLDER)
              .ToList();
        }

        public List<string> ReadFile(string file)
        {
            return File
                .ReadAllLines(Path.Combine(Constants.ROOT_FOLDER, $"{file}"))
                .ToList();
        }

        public List<Row> BindModel(List<string> lines)
        {
            var rows = new List<Row>();
            foreach (var line in lines)
            {
                var before = line.GetBefore("@");

                string[] split = { };

                if (before.Contains('.'))
                    split = before.Split('.');
                if (before.Contains('-'))
                    split = before.Split('-');
                if (before.Contains('_'))
                    split = before.Split('_');

                string firstName;
                var middleName = "";
                var lastName = "";

                if (split.Length > 2)
                {
                    firstName = split[0] ?? "";
                    middleName = split[1] ?? "";
                    lastName = split[2] ?? "";
                }
                else if (split.Length > 1)
                {
                    firstName = split[0] ?? "";
                    lastName = split[1] ?? "";
                }
                else
                    firstName = before;

                var email = line;

                var row = new Row(index, firstName, middleName, lastName, email);
                rows.Add(row);
                index++;
            }
            return rows;
        }

        public List<string> RemoveDuplicates(List<string> lines)
        {
            var noDupes = new Dictionary<string, Guid>();

            foreach (var line in lines.Where(line => !noDupes.ContainsKey(line)))
            {
                noDupes.Add(line, new Guid());
            }

            return noDupes.Keys.ToList();
        }

        public void WriteFile(List<string> lines)
        {
            File.WriteAllLines(Path.Combine(Constants.ROOT_FOLDER, $"{index}{Constants.EMAIL}"), lines, Encoding.UTF8);
        }

        //

        private int index = 158662947;
    }
}
