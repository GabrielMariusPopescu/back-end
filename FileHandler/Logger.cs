using FileHandler.Contracts;
using System;
using System.IO;

namespace FileHandler
{
  public class Logger : ILogger
  {
    public string FilePath { get; set; }
    public void WriteException(string exceptionMessage) => File.AppendAllText(FilePath, exceptionMessage + Environment.NewLine);
  }
}