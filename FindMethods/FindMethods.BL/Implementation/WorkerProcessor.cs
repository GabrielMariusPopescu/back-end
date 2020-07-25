using FindMethods.BL.Expressions;

namespace FindMethods.BL.Implementation
{
  public static class WorkerProcessor
  {
    public static Definition SetDefinition(string line)
    {
      if (REG_EX.IsProject(line))
        return new Definition(DefinitionType.Project, $"{index++} : {line}");
      if (REG_EX.IsTitle(line))
        return new Definition(DefinitionType.Title, line);
      if (REG_EX.AreXmlComments(line))
        return new Definition(DefinitionType.XmlComments, line);
      if (REG_EX.AreMethods(line))
        return new Definition(DefinitionType.Methods, line);
      return REG_EX.IsLineBreak(line)
        ? new Definition(DefinitionType.LineBreaks, line)
        : new Definition(DefinitionType.Unknown, line);
    }

    //
    static int index = 1;
    private static readonly RegularExpressions REG_EX = new RegularExpressions();
  }
}
