namespace FileHandler.Contracts
{
  public interface ILogger
  {
    void WriteException(string exceptionMessage);
    string FilePath { get; set; }
  }
}
