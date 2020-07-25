using System;
using System.Collections.Generic;
using System.Linq;
using Feeder.BLL.Services;
using Feeder.DAL.Services;

namespace Feeder.UI
{
  public class Worker
  {
    public Worker()
    {
      textDocument = new TextDocument();
      databaseDocument = new DatabaseDocument();
    }

    public void DoWork()
    {
      var files = textDocument.GetFiles();
      var index = 1;

      RemoveDupes(files, index);
      WriteToDatabase(files, index);
    }

    //

    private readonly TextDocument textDocument;
    private readonly DatabaseDocument databaseDocument;

    private void RemoveDupes(List<string> files, int index)
    {
      foreach (var file in files)
      {
        Console.WriteLine($"Checking for duplicates file {index}...");
        var lines = textDocument.ReadFile(file);
        var rows = textDocument.RemoveDuplicates(lines);
        textDocument.WriteFile(rows);
        Console.WriteLine($"File no: {index} contains no duplicates.");
        index++;
      }
    }

    private void WriteToDatabase(List<string> files, int index)
    {
      foreach (var file in files.Where(it => it.Contains("No dupes")))
      {
        Console.WriteLine($"Sending file {index}...");
        var lines = textDocument.ReadFile(file);
        var rows = textDocument.BindModel(lines);
        databaseDocument.Populate(rows);
        Console.WriteLine($"File no: {index} added to the database!");
        index++;
      }
    }
  }
}
