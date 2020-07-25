using System.Collections.Generic;
using Feeder.DAL.DataAccess;
using Feeder.DAL.Models;

namespace Feeder.DAL.Services
{
  public class DatabaseDocument
  {
    public DatabaseDocument()
    {
      sqlConnector = new SqlConnector();
    }
    public void Populate(List<Row> rows) => sqlConnector.CreateRow(rows);

    //

    private readonly SqlConnector sqlConnector;
  }
}
