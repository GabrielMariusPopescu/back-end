using FindMethods.BL.Expressions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FindMethods.BL
{
  public class Reader
  {
    public List<string> EnumerateAllDirectories(string filePath)
    {
      var directories = Directory
        .GetDirectories(filePath, "*.*", SearchOption.TopDirectoryOnly)
        .Where(it => !ExcludedDirectories.Any(it.Contains))
        .ToList();

      Projects = (from directory in directories
                  let isEmpty = Directory.GetFiles(directory, "*.csproj", SearchOption.AllDirectories).Length == 0
                  where !isEmpty
                  select directory).ToList();

      return Projects;
    }

    public List<string> GetProjectsNames(List<string> projects)
    {
      return projects
        .Select(RegularExpressions.GetProjectName)
        .ToList();
    }

    public List<List<string>> GetProjectFiles(List<string> directories)
    {
      foreach (var directory in directories)
      {
        var projects = new List<string>();
        projects.AddRange(Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories)
            .Where(it => !ExcludedDirectories.Any(it.Contains))
            .Where(it => !ExcludedFiles.Any(it.Contains))
            .ToList());

        Files.Add(projects);
      }

      return Files;
    }

    public List<string> EnumerateAllLines(List<string> projectsNames, List<List<string>> list)
    {
      var lines = new List<string>();
      foreach (var files in list)
      {
        lines.Add(projectsNames[0]);
        projectsNames.RemoveAt(0);

        foreach (var file in files)
        {
          lines.AddRange(File.ReadAllLines(file, Encoding.Default));
        }
        lines.Add("--------------------------------------------");
        lines.Add(Environment.NewLine);
      }

      return lines;
    }

    //
    private IEnumerable<string> ExcludedDirectories { get; } = new[] { ".git", ".vs", "_Installer", "_ReSharper.Caches", "packages", "bin", "obj", "Properties" };
    private IEnumerable<string> ExcludedFiles { get; } = new[] { "Designer.cs", "Reference.cs", "AssemblyInfo.cs" };

    private List<string> Projects { get; set; }
    private List<List<string>> Files { get; } = new List<List<string>>();
  }
}
