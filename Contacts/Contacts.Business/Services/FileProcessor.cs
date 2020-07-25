using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Contacts.Business.Contracts;

namespace Contacts.Business.Services
{
    public class FileProcessor : IFileProcessor
    {
        public IEnumerable<string> GetOneDriveDirectories()
        {
            var dict = Environment.GetEnvironmentVariables();
            var oneDrive = dict["OneDrive"].ToString();
            return Directory.EnumerateDirectories(oneDrive);
        }

        public IEnumerable<string> GetFiles(IEnumerable<string> directories)
        {
            var path = directories.FirstOrDefault(directory => directory.EndsWith("Contacts"));
            return !string.IsNullOrEmpty(path) ? Directory.EnumerateFiles(path, "*.csv", SearchOption.TopDirectoryOnly) : new[] { "" };
        }

        public IEnumerable<string[]> Read(IEnumerable<string> originalFiles) =>
            originalFiles.Select(File.ReadAllLines).ToList();

        public Dictionary<IEnumerable<string>, IEnumerable<string>> SeparateFiles(IEnumerable<string[]> items)
        {
            var dict = new Dictionary<IEnumerable<string>, IEnumerable<string>>();
            foreach (var item in items)
            {
                var key = item.Take(1);
                var value = item.Skip(1);
                dict.Add(key, value);
            }

            return dict;
        }
    }
}