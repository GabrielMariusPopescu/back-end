﻿namespace FindMethods.BL
{
  public class Definition
  {
    public DefinitionType Type { get; set; }
    public string Line { get; }

    public Definition(DefinitionType type, string line)
    {
      Type = type;
      Line = line;
    }
  }
}
