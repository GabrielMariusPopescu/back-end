namespace FileHandlerUI
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Panel2 = new System.Windows.Forms.Panel();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.btnGetFile = new System.Windows.Forms.Button();
      this.Label1 = new System.Windows.Forms.Label();
      this.Label13 = new System.Windows.Forms.Label();
      this.numMax = new System.Windows.Forms.NumericUpDown();
      this.numDataRow = new System.Windows.Forms.NumericUpDown();
      this.numTitleRow = new System.Windows.Forms.NumericUpDown();
      this.txtNameOnly = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.Panel3 = new System.Windows.Forms.Panel();
      this.label17 = new System.Windows.Forms.Label();
      this.txtDelimiter = new System.Windows.Forms.TextBox();
      this.Label15 = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.btnGetData = new System.Windows.Forms.Button();
      this.Label16 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.Label9 = new System.Windows.Forms.Label();
      this.txtFileNameOut = new System.Windows.Forms.TextBox();
      this.txtDelimiterOUT = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.chkIncludeTitle = new System.Windows.Forms.CheckBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label19 = new System.Windows.Forms.Label();
      this.Panel4 = new System.Windows.Forms.Panel();
      this.txtDestination = new System.Windows.Forms.TextBox();
      this.btnExport = new System.Windows.Forms.Button();
      this.Label3 = new System.Windows.Forms.Label();
      this.TabPage3 = new System.Windows.Forms.TabPage();
      this.Label2 = new System.Windows.Forms.Label();
      this.TabPage2 = new System.Windows.Forms.TabPage();
      this.DataGridView1 = new System.Windows.Forms.DataGridView();
      this.txtLength = new System.Windows.Forms.TextBox();
      this.txtLastWriteTime = new System.Windows.Forms.TextBox();
      this.txtLastAccessTime = new System.Windows.Forms.TextBox();
      this.btnGetDetails = new System.Windows.Forms.Button();
      this.Label4 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.TabControl1 = new System.Windows.Forms.TabControl();
      this.TabPage1 = new System.Windows.Forms.TabPage();
      this.txtUNCPath = new System.Windows.Forms.TextBox();
      this.Label6 = new System.Windows.Forms.Label();
      this.txtFullName = new System.Windows.Forms.TextBox();
      this.txtExists = new System.Windows.Forms.TextBox();
      this.txtDirectoryPath = new System.Windows.Forms.TextBox();
      this.txtCreationTime = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtExt = new System.Windows.Forms.TextBox();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.Panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numDataRow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTitleRow)).BeginInit();
      this.Panel3.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.TabPage3.SuspendLayout();
      this.TabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Panel2
      // 
      this.Panel2.Controls.Add(this.txtFileName);
      this.Panel2.Controls.Add(this.btnGetFile);
      this.Panel2.Controls.Add(this.Label1);
      this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel2.Location = new System.Drawing.Point(0, 0);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(734, 36);
      this.Panel2.TabIndex = 7;
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(161, 8);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.ReadOnly = true;
      this.txtFileName.Size = new System.Drawing.Size(566, 20);
      this.txtFileName.TabIndex = 1;
      this.txtFileName.Text = "C:\\Documents and Settings\\markandrew\\My Documents\\Articles\\FileHandler\\AdventureW" +
    "orksContact.csv";
      // 
      // btnGetFile
      // 
      this.btnGetFile.Location = new System.Drawing.Point(3, 4);
      this.btnGetFile.Name = "btnGetFile";
      this.btnGetFile.Size = new System.Drawing.Size(75, 23);
      this.btnGetFile.TabIndex = 0;
      this.btnGetFile.Text = "Get File:";
      this.btnGetFile.UseVisualStyleBackColor = true;
      this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
      // 
      // Label1
      // 
      this.Label1.Location = new System.Drawing.Point(86, 6);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(72, 20);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "File Name:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label13
      // 
      this.Label13.Location = new System.Drawing.Point(5, 154);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(110, 20);
      this.Label13.TabIndex = 28;
      this.Label13.Text = "Exists:";
      this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // numMax
      // 
      this.numMax.Location = new System.Drawing.Point(507, 34);
      this.numMax.Name = "numMax";
      this.numMax.Size = new System.Drawing.Size(39, 20);
      this.numMax.TabIndex = 18;
      // 
      // numDataRow
      // 
      this.numDataRow.Location = new System.Drawing.Point(114, 58);
      this.numDataRow.Name = "numDataRow";
      this.numDataRow.Size = new System.Drawing.Size(39, 20);
      this.numDataRow.TabIndex = 17;
      // 
      // numTitleRow
      // 
      this.numTitleRow.Location = new System.Drawing.Point(114, 34);
      this.numTitleRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.numTitleRow.Name = "numTitleRow";
      this.numTitleRow.Size = new System.Drawing.Size(39, 20);
      this.numTitleRow.TabIndex = 16;
      this.numTitleRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      // 
      // txtNameOnly
      // 
      this.txtNameOnly.Location = new System.Drawing.Point(120, 309);
      this.txtNameOnly.Name = "txtNameOnly";
      this.txtNameOnly.ReadOnly = true;
      this.txtNameOnly.Size = new System.Drawing.Size(593, 20);
      this.txtNameOnly.TabIndex = 29;
      // 
      // Label10
      // 
      this.Label10.Location = new System.Drawing.Point(5, 232);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(110, 20);
      this.Label10.TabIndex = 25;
      this.Label10.Text = "Last Write Time:";
      this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Panel3
      // 
      this.Panel3.Controls.Add(this.label17);
      this.Panel3.Controls.Add(this.numMax);
      this.Panel3.Controls.Add(this.numDataRow);
      this.Panel3.Controls.Add(this.numTitleRow);
      this.Panel3.Controls.Add(this.txtDelimiter);
      this.Panel3.Controls.Add(this.Label15);
      this.Panel3.Controls.Add(this.Label14);
      this.Panel3.Controls.Add(this.Label12);
      this.Panel3.Controls.Add(this.Label11);
      this.Panel3.Controls.Add(this.btnGetData);
      this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel3.Location = new System.Drawing.Point(3, 3);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new System.Drawing.Size(720, 87);
      this.Panel3.TabIndex = 3;
      // 
      // label17
      // 
      this.label17.Location = new System.Drawing.Point(158, 34);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(100, 20);
      this.label17.TabIndex = 19;
      this.label17.Text = "-1 = No Title";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtDelimiter
      // 
      this.txtDelimiter.Location = new System.Drawing.Point(507, 8);
      this.txtDelimiter.Name = "txtDelimiter";
      this.txtDelimiter.Size = new System.Drawing.Size(25, 20);
      this.txtDelimiter.TabIndex = 15;
      this.txtDelimiter.Text = ",";
      // 
      // Label15
      // 
      this.Label15.Location = new System.Drawing.Point(12, 58);
      this.Label15.Name = "Label15";
      this.Label15.Size = new System.Drawing.Size(100, 20);
      this.Label15.TabIndex = 11;
      this.Label15.Text = "First Data Row:";
      this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label14
      // 
      this.Label14.Location = new System.Drawing.Point(12, 34);
      this.Label14.Name = "Label14";
      this.Label14.Size = new System.Drawing.Size(100, 20);
      this.Label14.TabIndex = 10;
      this.Label14.Text = "Title Row No:";
      this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label12
      // 
      this.Label12.Location = new System.Drawing.Point(313, 34);
      this.Label12.Name = "Label12";
      this.Label12.Size = new System.Drawing.Size(181, 20);
      this.Label12.TabIndex = 9;
      this.Label12.Text = "Maximum Rows to read (optional)";
      this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label11
      // 
      this.Label11.Location = new System.Drawing.Point(313, 8);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(181, 20);
      this.Label11.TabIndex = 8;
      this.Label11.Text = "Field Delimiter:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnGetData
      // 
      this.btnGetData.Location = new System.Drawing.Point(507, 57);
      this.btnGetData.Name = "btnGetData";
      this.btnGetData.Size = new System.Drawing.Size(75, 23);
      this.btnGetData.TabIndex = 6;
      this.btnGetData.Text = "Get Data";
      this.btnGetData.UseVisualStyleBackColor = true;
      this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
      // 
      // Label16
      // 
      this.Label16.Location = new System.Drawing.Point(5, 310);
      this.Label16.Name = "Label16";
      this.Label16.Size = new System.Drawing.Size(110, 20);
      this.Label16.TabIndex = 30;
      this.Label16.Text = "Name Only:";
      this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label8
      // 
      this.Label8.Location = new System.Drawing.Point(5, 206);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(110, 20);
      this.Label8.TabIndex = 23;
      this.Label8.Text = "Last Access Time:";
      this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label9
      // 
      this.Label9.Location = new System.Drawing.Point(5, 258);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(110, 20);
      this.Label9.TabIndex = 24;
      this.Label9.Text = "Length:";
      this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFileNameOut
      // 
      this.txtFileNameOut.Location = new System.Drawing.Point(108, 9);
      this.txtFileNameOut.Name = "txtFileNameOut";
      this.txtFileNameOut.Size = new System.Drawing.Size(234, 20);
      this.txtFileNameOut.TabIndex = 16;
      this.txtFileNameOut.Text = "Data.csv";
      // 
      // txtDelimiterOUT
      // 
      this.txtDelimiterOUT.Location = new System.Drawing.Point(106, 62);
      this.txtDelimiterOUT.Name = "txtDelimiterOUT";
      this.txtDelimiterOUT.Size = new System.Drawing.Size(25, 20);
      this.txtDelimiterOUT.TabIndex = 15;
      this.txtDelimiterOUT.Text = ",";
      // 
      // Label7
      // 
      this.Label7.Location = new System.Drawing.Point(5, 180);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(110, 20);
      this.Label7.TabIndex = 22;
      this.Label7.Text = "Full Name:";
      this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // chkIncludeTitle
      // 
      this.chkIncludeTitle.Checked = true;
      this.chkIncludeTitle.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkIncludeTitle.Location = new System.Drawing.Point(107, 38);
      this.chkIncludeTitle.Name = "chkIncludeTitle";
      this.chkIncludeTitle.Size = new System.Drawing.Size(190, 24);
      this.chkIncludeTitle.TabIndex = 7;
      this.chkIncludeTitle.Text = "Include Titles";
      this.chkIncludeTitle.UseVisualStyleBackColor = true;
      // 
      // Label5
      // 
      this.Label5.Location = new System.Drawing.Point(5, 128);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(110, 20);
      this.Label5.TabIndex = 21;
      this.Label5.Text = "Directory Path:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label19
      // 
      this.Label19.Location = new System.Drawing.Point(135, 62);
      this.Label19.Name = "Label19";
      this.Label19.Size = new System.Drawing.Size(181, 20);
      this.Label19.TabIndex = 8;
      this.Label19.Text = "Field Delimiter:";
      this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Panel4
      // 
      this.Panel4.Controls.Add(this.txtDestination);
      this.Panel4.Controls.Add(this.txtFileNameOut);
      this.Panel4.Controls.Add(this.txtDelimiterOUT);
      this.Panel4.Controls.Add(this.Label19);
      this.Panel4.Controls.Add(this.chkIncludeTitle);
      this.Panel4.Controls.Add(this.btnExport);
      this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.Panel4.Location = new System.Drawing.Point(0, 0);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new System.Drawing.Size(726, 150);
      this.Panel4.TabIndex = 4;
      // 
      // txtDestination
      // 
      this.txtDestination.Location = new System.Drawing.Point(186, 90);
      this.txtDestination.Name = "txtDestination";
      this.txtDestination.ReadOnly = true;
      this.txtDestination.Size = new System.Drawing.Size(520, 20);
      this.txtDestination.TabIndex = 18;
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(105, 89);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(75, 23);
      this.btnExport.TabIndex = 6;
      this.btnExport.Text = "Export Data";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // Label3
      // 
      this.Label3.Location = new System.Drawing.Point(5, 102);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(110, 20);
      this.Label3.TabIndex = 20;
      this.Label3.Text = "Creation Time:";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TabPage3
      // 
      this.TabPage3.Controls.Add(this.Panel4);
      this.TabPage3.Location = new System.Drawing.Point(4, 22);
      this.TabPage3.Name = "TabPage3";
      this.TabPage3.Size = new System.Drawing.Size(726, 347);
      this.TabPage3.TabIndex = 2;
      this.TabPage3.Text = "Table to CSV";
      this.TabPage3.UseVisualStyleBackColor = true;
      // 
      // Label2
      // 
      this.Label2.Location = new System.Drawing.Point(5, 76);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(110, 20);
      this.Label2.TabIndex = 19;
      this.Label2.Text = "Name:";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TabPage2
      // 
      this.TabPage2.Controls.Add(this.DataGridView1);
      this.TabPage2.Controls.Add(this.Panel3);
      this.TabPage2.Location = new System.Drawing.Point(4, 22);
      this.TabPage2.Name = "TabPage2";
      this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.TabPage2.Size = new System.Drawing.Size(726, 347);
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "CSV to Table";
      this.TabPage2.UseVisualStyleBackColor = true;
      // 
      // DataGridView1
      // 
      this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridView1.Location = new System.Drawing.Point(3, 90);
      this.DataGridView1.Name = "DataGridView1";
      this.DataGridView1.Size = new System.Drawing.Size(720, 254);
      this.DataGridView1.TabIndex = 2;
      // 
      // txtLength
      // 
      this.txtLength.Location = new System.Drawing.Point(120, 257);
      this.txtLength.Name = "txtLength";
      this.txtLength.ReadOnly = true;
      this.txtLength.Size = new System.Drawing.Size(593, 20);
      this.txtLength.TabIndex = 16;
      // 
      // txtLastWriteTime
      // 
      this.txtLastWriteTime.Location = new System.Drawing.Point(120, 231);
      this.txtLastWriteTime.Name = "txtLastWriteTime";
      this.txtLastWriteTime.ReadOnly = true;
      this.txtLastWriteTime.Size = new System.Drawing.Size(593, 20);
      this.txtLastWriteTime.TabIndex = 15;
      // 
      // txtLastAccessTime
      // 
      this.txtLastAccessTime.Location = new System.Drawing.Point(120, 205);
      this.txtLastAccessTime.Name = "txtLastAccessTime";
      this.txtLastAccessTime.ReadOnly = true;
      this.txtLastAccessTime.Size = new System.Drawing.Size(593, 20);
      this.txtLastAccessTime.TabIndex = 14;
      // 
      // btnGetDetails
      // 
      this.btnGetDetails.Location = new System.Drawing.Point(6, 7);
      this.btnGetDetails.Name = "btnGetDetails";
      this.btnGetDetails.Size = new System.Drawing.Size(75, 23);
      this.btnGetDetails.TabIndex = 6;
      this.btnGetDetails.Text = "Get Details";
      this.btnGetDetails.UseVisualStyleBackColor = true;
      this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
      // 
      // Label4
      // 
      this.Label4.Location = new System.Drawing.Point(5, 50);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(110, 20);
      this.Label4.TabIndex = 2;
      this.Label4.Text = "Extension:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(652, 9);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // TabControl1
      // 
      this.TabControl1.Controls.Add(this.TabPage1);
      this.TabControl1.Controls.Add(this.TabPage2);
      this.TabControl1.Controls.Add(this.TabPage3);
      this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControl1.Location = new System.Drawing.Point(0, 36);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new System.Drawing.Size(734, 373);
      this.TabControl1.TabIndex = 8;
      // 
      // TabPage1
      // 
      this.TabPage1.Controls.Add(this.txtUNCPath);
      this.TabPage1.Controls.Add(this.Label6);
      this.TabPage1.Controls.Add(this.Label16);
      this.TabPage1.Controls.Add(this.txtNameOnly);
      this.TabPage1.Controls.Add(this.Label13);
      this.TabPage1.Controls.Add(this.Label10);
      this.TabPage1.Controls.Add(this.Label9);
      this.TabPage1.Controls.Add(this.Label8);
      this.TabPage1.Controls.Add(this.Label7);
      this.TabPage1.Controls.Add(this.Label5);
      this.TabPage1.Controls.Add(this.Label3);
      this.TabPage1.Controls.Add(this.Label2);
      this.TabPage1.Controls.Add(this.txtLength);
      this.TabPage1.Controls.Add(this.txtLastWriteTime);
      this.TabPage1.Controls.Add(this.txtLastAccessTime);
      this.TabPage1.Controls.Add(this.txtFullName);
      this.TabPage1.Controls.Add(this.txtExists);
      this.TabPage1.Controls.Add(this.txtDirectoryPath);
      this.TabPage1.Controls.Add(this.txtCreationTime);
      this.TabPage1.Controls.Add(this.txtName);
      this.TabPage1.Controls.Add(this.txtExt);
      this.TabPage1.Controls.Add(this.btnGetDetails);
      this.TabPage1.Controls.Add(this.Label4);
      this.TabPage1.Location = new System.Drawing.Point(4, 22);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.TabPage1.Size = new System.Drawing.Size(726, 347);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "File Properties";
      this.TabPage1.UseVisualStyleBackColor = true;
      // 
      // txtUNCPath
      // 
      this.txtUNCPath.Location = new System.Drawing.Point(120, 283);
      this.txtUNCPath.Name = "txtUNCPath";
      this.txtUNCPath.ReadOnly = true;
      this.txtUNCPath.Size = new System.Drawing.Size(593, 20);
      this.txtUNCPath.TabIndex = 32;
      // 
      // Label6
      // 
      this.Label6.Location = new System.Drawing.Point(4, 284);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(110, 20);
      this.Label6.TabIndex = 31;
      this.Label6.Text = "UNC Path:";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFullName
      // 
      this.txtFullName.Location = new System.Drawing.Point(120, 179);
      this.txtFullName.Name = "txtFullName";
      this.txtFullName.ReadOnly = true;
      this.txtFullName.Size = new System.Drawing.Size(593, 20);
      this.txtFullName.TabIndex = 13;
      // 
      // txtExists
      // 
      this.txtExists.Location = new System.Drawing.Point(120, 153);
      this.txtExists.Name = "txtExists";
      this.txtExists.ReadOnly = true;
      this.txtExists.Size = new System.Drawing.Size(593, 20);
      this.txtExists.TabIndex = 12;
      // 
      // txtDirectoryPath
      // 
      this.txtDirectoryPath.Location = new System.Drawing.Point(120, 127);
      this.txtDirectoryPath.Name = "txtDirectoryPath";
      this.txtDirectoryPath.ReadOnly = true;
      this.txtDirectoryPath.Size = new System.Drawing.Size(593, 20);
      this.txtDirectoryPath.TabIndex = 11;
      // 
      // txtCreationTime
      // 
      this.txtCreationTime.Location = new System.Drawing.Point(120, 101);
      this.txtCreationTime.Name = "txtCreationTime";
      this.txtCreationTime.ReadOnly = true;
      this.txtCreationTime.Size = new System.Drawing.Size(593, 20);
      this.txtCreationTime.TabIndex = 10;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(120, 75);
      this.txtName.Name = "txtName";
      this.txtName.ReadOnly = true;
      this.txtName.Size = new System.Drawing.Size(593, 20);
      this.txtName.TabIndex = 9;
      // 
      // txtExt
      // 
      this.txtExt.Location = new System.Drawing.Point(120, 49);
      this.txtExt.Name = "txtExt";
      this.txtExt.ReadOnly = true;
      this.txtExt.Size = new System.Drawing.Size(593, 20);
      this.txtExt.TabIndex = 7;
      // 
      // Panel1
      // 
      this.Panel1.Controls.Add(this.btnClose);
      this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.Panel1.Location = new System.Drawing.Point(0, 409);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(734, 40);
      this.Panel1.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 449);
      this.Controls.Add(this.TabControl1);
      this.Controls.Add(this.Panel1);
      this.Controls.Add(this.Panel2);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CSV to Table demo";
      this.Panel2.ResumeLayout(false);
      this.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numDataRow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTitleRow)).EndInit();
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
      this.Panel4.ResumeLayout(false);
      this.Panel4.PerformLayout();
      this.TabPage3.ResumeLayout(false);
      this.TabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Panel Panel2;
    internal System.Windows.Forms.TextBox txtFileName;
    internal System.Windows.Forms.Button btnGetFile;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label Label13;
    internal System.Windows.Forms.NumericUpDown numMax;
    internal System.Windows.Forms.NumericUpDown numDataRow;
    internal System.Windows.Forms.NumericUpDown numTitleRow;
    internal System.Windows.Forms.TextBox txtNameOnly;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.Panel Panel3;
    internal System.Windows.Forms.TextBox txtDelimiter;
    internal System.Windows.Forms.Label Label15;
    internal System.Windows.Forms.Label Label14;
    internal System.Windows.Forms.Label Label12;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.Button btnGetData;
    internal System.Windows.Forms.Label Label16;
    internal System.Windows.Forms.Label Label8;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.TextBox txtFileNameOut;
    internal System.Windows.Forms.TextBox txtDelimiterOUT;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.CheckBox chkIncludeTitle;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label19;
    internal System.Windows.Forms.Panel Panel4;
    internal System.Windows.Forms.Button btnExport;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.TabPage TabPage3;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.TabPage TabPage2;
    internal System.Windows.Forms.DataGridView DataGridView1;
    internal System.Windows.Forms.TextBox txtLength;
    internal System.Windows.Forms.TextBox txtLastWriteTime;
    internal System.Windows.Forms.TextBox txtLastAccessTime;
    internal System.Windows.Forms.Button btnGetDetails;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.Button btnClose;
    internal System.Windows.Forms.TabControl TabControl1;
    internal System.Windows.Forms.TabPage TabPage1;
    internal System.Windows.Forms.TextBox txtFullName;
    internal System.Windows.Forms.TextBox txtExists;
    internal System.Windows.Forms.TextBox txtDirectoryPath;
    internal System.Windows.Forms.TextBox txtCreationTime;
    internal System.Windows.Forms.TextBox txtName;
    internal System.Windows.Forms.TextBox txtExt;
    internal System.Windows.Forms.Panel Panel1;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.TextBox txtDestination;
    internal System.Windows.Forms.TextBox txtUNCPath;
    internal System.Windows.Forms.Label Label6;
  }
}

