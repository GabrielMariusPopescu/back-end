using FileHandler.Contracts;
using System;
using System.Data;
using System.IO;
using System.Management;
using System.Text;

namespace FileHandler
{
  public class ClsFileHandler
  {

    public ClsFileHandler()
    {
    }
    public ClsFileHandler(string sFilename)
    {
      FileInf = new FileInfo(sFilename);
      logger = new Logger { FilePath = @"../../Logs/Exception.txt" };
    }
    public FileInfo FileInf { get; set; }
    public int HeaderRow { private get; set; } = -1;
    public int DataRow1 { private get; set; }
    public string Delimiter { private get; set; }
    public int MaxRows { private get; set; }
    public string NameOnly //read only
      => FileInf.Name.Substring(0, FileInf.Name.Length - FileInf.Extension.Length);

    public DataTable CSVToTable
    {
      get
      {
        try
        {
          // trap if the file info has not been added to the object
          if (FileInf == null)
            return null;

          var dtData = new DataTable();
          TextReader oTr = File.OpenText(FileInf.FullName);
          string sLine = null;
          var iRows = 0;

          //get the header row
          if (HeaderRow > -1)
          {
            for (var i = 0; i < HeaderRow + 1; i++)
            {
              sLine = CleanString(oTr.ReadLine());
            }
          }
          else //get the first row to count the columns
          {
            sLine = CleanString(oTr.ReadLine());
          }
          //create the columns in the table
          CreateColumns(dtData, sLine);

          //bail if the table failed
          if (dtData.Columns.Count == 0)
          {
            return null;
          }

          //reset the text reader
          oTr.Close();
          oTr = File.OpenText(FileInf.FullName);

          //get the first data line
          for (var i = 0; i < DataRow1 + 1; i++)
          {
            sLine = CleanString(oTr.ReadLine());
          }
          while (true)
          {
            //populate the string array with the line data
            var arData = sLine?.Split(new[] { Delimiter }, StringSplitOptions.None); //array of strings to load the data into for each line read in
                                                                                     //load the data row
            var drData = dtData.NewRow();
            for (var i = 0; i < dtData.Columns.Count; i++)
            {
              //test for additional fields - this can happen if there are stray commas
              if (i < arData?.Length)
              {
                drData[i] = arData[i];
              }
            }
            //only get the top N rows if there is a max rows value > 0
            iRows++;
            if (MaxRows > 0 && iRows > MaxRows)
            {
              break;
            }

            //add the row to the table
            dtData.Rows.Add(drData);

            //read in the next line
            sLine = CleanString(oTr.ReadLine());
            if (sLine == null)
            {
              break;
            }
          }
          oTr.Close();
          oTr.Dispose();
          dtData.AcceptChanges();
          return dtData;
        }
        catch (Exception ex)
        {
          var now = DateTime.Now.Date;
          logger.WriteException($"{now} ~ {ex.Message}");
        }
        return new DataTable();
      }
    }

    public bool TableToCSV(DataView dvData, bool bExcludeTitles)
    {
      try
      {
        if (dvData == null)
        {
          return false;
        }
        var sLine = new StringBuilder();

        //Delete the existing file
        if (FileInf.Exists)
        {
          FileInf.Delete();
        }
        var oSw = new StreamWriter(new FileStream(FileInf.FullName, FileMode.Create));

        if (!bExcludeTitles)
        {
          foreach (DataColumn oCol in dvData.Table.Columns)
          {
            sLine.AppendFormat($"{oCol.Caption}{Delimiter}");
          }
          //strip the trailing comma
          sLine.Length = sLine.Length - 1;

          //write the line
          oSw.WriteLine(sLine.ToString());
        }

        for (var i = 0; i < dvData.Count; i++)
        {
          sLine.Length = 0;
          for (var j = 0; j < dvData.Table.Columns.Count; j++)
          {
            sLine.AppendFormat($"{Convert.ToString(dvData[i][j])}{Delimiter}");
          }
          oSw.WriteLine(sLine.ToString());
        }
        oSw.Flush();
        oSw.Close();
        return true;
      }
      catch (Exception ex)
      {
        var now = DateTime.Now.Date;
        logger.WriteException($"{now} ~ {ex.Message}");
        return false;
      }
    }
    //
    public string UncPath => GetUncPath();

    private string GetUncPath()
    {
      var sPath = new StringBuilder();
      try
      {
        var sLtr = FileInf.FullName.Substring(0, 2);
        var query = new SelectQuery(
          "select name, ProviderName from win32_logicaldisk where drive type=4");
        var searcher = new ManagementObjectSearcher(query);

        foreach (var mo in searcher.Get())
        {
          var sNetLtr = Convert.ToString(mo["name"]);
          if (sNetLtr == sLtr)
            sPath.AppendFormat($"{mo["ProviderName"]}{FileInf.DirectoryName?.Substring(2)}");
        }
      }
      catch (Exception ex)
      {
        var now = DateTime.Now.Date;
        logger.WriteException($"{now} ~ {ex.Message}");
      }
      return sPath.ToString();
    }

    //
    private string CleanString(string sLine)
    {
      try
      {
        if (sLine == null)
        {
          return null;
        }
        sLine = sLine.Replace("'", "''");
        sLine = sLine.Replace("\"", "");
        return sLine;
      }
      catch (Exception ex)
      {
        var now = DateTime.Now.Date;
        logger.WriteException($"{now} ~ {ex.Message}");
      }
      return sLine;
    }
    private void CreateColumns(DataTable oTable, string sLine)
    {
      try
      {
        var arData = sLine.Split(new[] { Delimiter }, StringSplitOptions.None);
        for (var i = 0; i < arData.Length; i++)
        {
          //get the header labels from the row
          var sTemp = string.Empty;
          if (HeaderRow != -1)
          {
            sTemp = arData[i];
          }

          //deal with the empty string (may be missing from the row)
          if (sTemp.Trim().Length == 0)
          {
            sTemp = $"ColName_{i}";
          }

          //Deal with duplicate column names in the title row
          var iCol = oTable.Columns.Count + 100;
          while (oTable.Columns.Contains(sTemp))
          {
            sTemp = $"ColName_{iCol}";
          }

          var oCol = new DataColumn(sTemp, typeof(string));
          oTable.Columns.Add(oCol);
        }
      }
      catch (Exception exc)
      {
        var now = DateTime.Now.Date;
        logger.WriteException($"{now} ~ {exc.Message}");
      }
    }

    private readonly ILogger logger;
  }
}