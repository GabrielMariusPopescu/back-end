using System.Text.RegularExpressions;

namespace FindMethods.BL.Expressions
{
  public class RegularExpressions
  {
    public bool IsProject(string line) => Regex.IsMatch(line, @"\bnamespace\b", RegexOptions.Compiled);

    public bool IsTitle(string line) => Regex.IsMatch(line, @"\bclass\b", RegexOptions.Compiled);

    public bool AreXmlComments(string line) => Regex.IsMatch(line, @"^(?:(\/\/\/))", RegexOptions.Compiled);

    public bool AreMethods(string line) =>
      Regex.IsMatch(line, @"(?:(\bpublic\b|\bprivate\b|\binternal\b|\bprotected\b)\s((\babstract\b\s)?)(T\s|\w+<?\w+<?\w+>?>?\s)(\w+<T>|[a-zA-Z0-9]+)(\(.*\))(\s=>\s\w+)?)", RegexOptions.Compiled);

    public bool IsLineBreak(string line) => Regex.IsMatch(line, "-{44}", RegexOptions.Compiled);


    public static string GetProjectName(string project)
    {
      var match = Regex.Match(project, @"(?:(\\ls.common\\)(LS.|)(Common.?|\w+)*(.?\w+)?)", RegexOptions.Compiled);

      return match.Groups[3].Value + match.Groups[4].Value;
    }
  }
}
