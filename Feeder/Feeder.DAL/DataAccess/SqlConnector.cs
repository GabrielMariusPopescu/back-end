using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Feeder.DAL.Models;

namespace Feeder.DAL.DataAccess
{
  public class SqlConnector
  {
    public void CreateRow(List<Row> rows)
    {
      using (var data = new DataTable())
      {
        data.Columns.Add("Id", typeof(int));
        data.Columns.Add("FirstName", typeof(string));
        data.Columns.Add("MiddleName", typeof(string));
        data.Columns.Add("LastName", typeof(string));
        data.Columns.Add("Email", typeof(string));

        foreach (var row in rows)
          data.Rows.Add(row.Id, row.FirstName, row.MiddleName, row.LastName, row.Email);

        BulkInsert("Email", data);
      }
    }

    //
    private void BulkInsert(string tableName, DataTable data)
    {
      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        connection.Open();

        using (var bulk = new SqlBulkCopy(CONNECTION_STRING, SqlBulkCopyOptions.TableLock))
        {
          bulk.BatchSize = 1000;
          bulk.DestinationTableName = tableName;
          bulk.WriteToServer(data);
        }
      }
    }

    private const string CONNECTION_STRING = "Data Source=.\\SQLEXPRESS;Initial Catalog=Emails;Persist Security Info=False;Integrated Security=true;";
  }
}
