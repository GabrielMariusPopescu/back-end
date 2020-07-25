using FileHandler;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FileHandlerUI
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private static ClsFileHandler oFh = new ClsFileHandler();

    //
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnGetFile_Click(object sender, EventArgs e)
    {
      var openFileDialog = new OpenFileDialog
      {
        Filter = @"(*.csv)|*.csv|*.txt)|*.txt|All files (*.*)|*.*",
        FilterIndex = 0
      };

      if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        txtFileName.Text = openFileDialog.FileName;
    }

    private void btnGetDetails_Click(object sender, EventArgs e)
    {
      oFh = new ClsFileHandler(txtFileName.Text);

      if (!oFh.FileInf.Exists)
        return;

      txtCreationTime.Text = Convert.ToString(oFh.FileInf.CreationTime, CultureInfo.InvariantCulture);
      txtDirectoryPath.Text = oFh.FileInf.DirectoryName;
      txtExists.Text = Convert.ToString(oFh.FileInf.Exists);
      txtExt.Text = oFh.FileInf.Extension;
      txtFullName.Text = oFh.FileInf.FullName;
      txtLastAccessTime.Text = Convert.ToString(oFh.FileInf.LastAccessTime, CultureInfo.InvariantCulture);
      txtLastWriteTime.Text = Convert.ToString(oFh.FileInf.LastWriteTime, CultureInfo.InvariantCulture);
      txtLength.Text = Convert.ToString(oFh.FileInf.Length);
      txtName.Text = oFh.FileInf.Name;
      txtNameOnly.Text = oFh.NameOnly;
      txtUNCPath.Text = oFh.UncPath;
    }

    private DataTable dtData;

    private void btnGetData_Click(object sender, EventArgs e)
    {
      oFh.Delimiter = txtDelimiter.Text;
      oFh.DataRow1 = Convert.ToInt32(numDataRow.Value);
      oFh.HeaderRow = Convert.ToInt32(numTitleRow.Value);
      oFh.MaxRows = (int)numMax.Value;
      dtData = oFh.CSVToTable;
      DataGridView1.DataSource = dtData;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      var folder = AppDomain.CurrentDomain.BaseDirectory;
      var sFile = Path.Combine(folder, txtFileNameOut.Text);
      oFh.Delimiter = txtDelimiterOUT.Text;
      oFh.FileInf = new FileInfo(sFile);
      txtDestination.Text = oFh.TableToCSV(dtData.DefaultView, !chkIncludeTitle.Checked)
        ? sFile
        : @"Export failed";
    }
  }
}