namespace Connector.Presentation
{
    partial class ProfileForm
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
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.tlpProfile = new System.Windows.Forms.TableLayoutPanel();
            this.mLblGender = new MetroFramework.Controls.MetroLabel();
            this.mLblBirthdate = new MetroFramework.Controls.MetroLabel();
            this.mLblCurrentCity = new MetroFramework.Controls.MetroLabel();
            this.mLblHometown = new MetroFramework.Controls.MetroLabel();
            this.mLblInterests = new MetroFramework.Controls.MetroLabel();
            this.mCmbGender = new MetroFramework.Controls.MetroComboBox();
            this.mDateTimeBirthdate = new MetroFramework.Controls.MetroDateTime();
            this.mCmbCurrentCity = new MetroFramework.Controls.MetroComboBox();
            this.mCmbHometown = new MetroFramework.Controls.MetroComboBox();
            this.mCmbInterests = new MetroFramework.Controls.MetroComboBox();
            this.mTileSaveProfile = new MetroFramework.Controls.MetroTile();
            this.mTitleAddInterests = new MetroFramework.Controls.MetroTile();
            this.grpProfessional = new System.Windows.Forms.GroupBox();
            this.tlpProfessional = new System.Windows.Forms.TableLayoutPanel();
            this.mLblSchool = new MetroFramework.Controls.MetroLabel();
            this.mLblYearGraduated = new MetroFramework.Controls.MetroLabel();
            this.mCmbSchool = new MetroFramework.Controls.MetroComboBox();
            this.mTxtYearGraduated = new MetroFramework.Controls.MetroTextBox();
            this.mTileAddEducation = new MetroFramework.Controls.MetroTile();
            this.mTileDeleteEducation = new MetroFramework.Controls.MetroTile();
            this.grpEducation = new System.Windows.Forms.GroupBox();
            this.tlpEducation = new System.Windows.Forms.TableLayoutPanel();
            this.mLblEmployer = new MetroFramework.Controls.MetroLabel();
            this.mLblJobTitle = new MetroFramework.Controls.MetroLabel();
            this.mCmbEmployer = new MetroFramework.Controls.MetroComboBox();
            this.mTxtJobTitle = new MetroFramework.Controls.MetroTextBox();
            this.mTileAddProfessional = new MetroFramework.Controls.MetroTile();
            this.mTileDeleteProfessional = new MetroFramework.Controls.MetroTile();
            this.grpProfile.SuspendLayout();
            this.tlpProfile.SuspendLayout();
            this.grpProfessional.SuspendLayout();
            this.tlpProfessional.SuspendLayout();
            this.grpEducation.SuspendLayout();
            this.tlpEducation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.tlpProfile);
            this.grpProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProfile.Location = new System.Drawing.Point(20, 60);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(460, 365);
            this.grpProfile.TabIndex = 0;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "First Name, Last Name";
            // 
            // tlpProfile
            // 
            this.tlpProfile.ColumnCount = 2;
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpProfile.Controls.Add(this.mLblGender, 0, 0);
            this.tlpProfile.Controls.Add(this.mLblBirthdate, 0, 1);
            this.tlpProfile.Controls.Add(this.mLblCurrentCity, 0, 2);
            this.tlpProfile.Controls.Add(this.mLblHometown, 0, 3);
            this.tlpProfile.Controls.Add(this.mLblInterests, 0, 4);
            this.tlpProfile.Controls.Add(this.mCmbGender, 1, 0);
            this.tlpProfile.Controls.Add(this.mDateTimeBirthdate, 1, 1);
            this.tlpProfile.Controls.Add(this.mCmbCurrentCity, 1, 2);
            this.tlpProfile.Controls.Add(this.mCmbHometown, 1, 3);
            this.tlpProfile.Controls.Add(this.mCmbInterests, 1, 5);
            this.tlpProfile.Controls.Add(this.mTileSaveProfile, 1, 4);
            this.tlpProfile.Controls.Add(this.mTitleAddInterests, 0, 5);
            this.tlpProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfile.Location = new System.Drawing.Point(3, 18);
            this.tlpProfile.Name = "tlpProfile";
            this.tlpProfile.RowCount = 6;
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpProfile.Size = new System.Drawing.Size(454, 344);
            this.tlpProfile.TabIndex = 0;
            // 
            // mLblGender
            // 
            this.mLblGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblGender.AutoSize = true;
            this.mLblGender.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblGender.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblGender.Location = new System.Drawing.Point(59, 20);
            this.mLblGender.Name = "mLblGender";
            this.mLblGender.Size = new System.Drawing.Size(51, 17);
            this.mLblGender.TabIndex = 0;
            this.mLblGender.Text = "Gender";
            this.mLblGender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblGender.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblBirthdate
            // 
            this.mLblBirthdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblBirthdate.AutoSize = true;
            this.mLblBirthdate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblBirthdate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblBirthdate.Location = new System.Drawing.Point(50, 77);
            this.mLblBirthdate.Name = "mLblBirthdate";
            this.mLblBirthdate.Size = new System.Drawing.Size(60, 17);
            this.mLblBirthdate.TabIndex = 1;
            this.mLblBirthdate.Text = "Birthdate";
            this.mLblBirthdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblBirthdate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblCurrentCity
            // 
            this.mLblCurrentCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblCurrentCity.AutoSize = true;
            this.mLblCurrentCity.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblCurrentCity.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblCurrentCity.Location = new System.Drawing.Point(34, 134);
            this.mLblCurrentCity.Name = "mLblCurrentCity";
            this.mLblCurrentCity.Size = new System.Drawing.Size(76, 17);
            this.mLblCurrentCity.TabIndex = 2;
            this.mLblCurrentCity.Text = "Current City";
            this.mLblCurrentCity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblCurrentCity.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblHometown
            // 
            this.mLblHometown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblHometown.AutoSize = true;
            this.mLblHometown.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblHometown.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblHometown.Location = new System.Drawing.Point(39, 191);
            this.mLblHometown.Name = "mLblHometown";
            this.mLblHometown.Size = new System.Drawing.Size(71, 17);
            this.mLblHometown.TabIndex = 3;
            this.mLblHometown.Text = "Hometown";
            this.mLblHometown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblHometown.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblInterests
            // 
            this.mLblInterests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mLblInterests.AutoSize = true;
            this.mLblInterests.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblInterests.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblInterests.Location = new System.Drawing.Point(28, 268);
            this.mLblInterests.Name = "mLblInterests";
            this.mLblInterests.Size = new System.Drawing.Size(57, 17);
            this.mLblInterests.TabIndex = 4;
            this.mLblInterests.Text = "Interests";
            this.mLblInterests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblInterests.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mCmbGender
            // 
            this.mCmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbGender.FormattingEnabled = true;
            this.mCmbGender.ItemHeight = 24;
            this.mCmbGender.Location = new System.Drawing.Point(116, 13);
            this.mCmbGender.Name = "mCmbGender";
            this.mCmbGender.Size = new System.Drawing.Size(335, 30);
            this.mCmbGender.TabIndex = 5;
            this.mCmbGender.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mCmbGender.UseSelectable = true;
            // 
            // mDateTimeBirthdate
            // 
            this.mDateTimeBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mDateTimeBirthdate.Location = new System.Drawing.Point(116, 70);
            this.mDateTimeBirthdate.MinimumSize = new System.Drawing.Size(0, 30);
            this.mDateTimeBirthdate.Name = "mDateTimeBirthdate";
            this.mDateTimeBirthdate.Size = new System.Drawing.Size(335, 30);
            this.mDateTimeBirthdate.TabIndex = 6;
            this.mDateTimeBirthdate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mCmbCurrentCity
            // 
            this.mCmbCurrentCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbCurrentCity.FormattingEnabled = true;
            this.mCmbCurrentCity.ItemHeight = 24;
            this.mCmbCurrentCity.Location = new System.Drawing.Point(116, 127);
            this.mCmbCurrentCity.Name = "mCmbCurrentCity";
            this.mCmbCurrentCity.Size = new System.Drawing.Size(335, 30);
            this.mCmbCurrentCity.TabIndex = 7;
            this.mCmbCurrentCity.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mCmbCurrentCity.UseSelectable = true;
            // 
            // mCmbHometown
            // 
            this.mCmbHometown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbHometown.FormattingEnabled = true;
            this.mCmbHometown.ItemHeight = 24;
            this.mCmbHometown.Location = new System.Drawing.Point(116, 184);
            this.mCmbHometown.Name = "mCmbHometown";
            this.mCmbHometown.Size = new System.Drawing.Size(335, 30);
            this.mCmbHometown.TabIndex = 8;
            this.mCmbHometown.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mCmbHometown.UseSelectable = true;
            // 
            // mCmbInterests
            // 
            this.mCmbInterests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbInterests.FormattingEnabled = true;
            this.mCmbInterests.ItemHeight = 24;
            this.mCmbInterests.Location = new System.Drawing.Point(116, 299);
            this.mCmbInterests.Name = "mCmbInterests";
            this.mCmbInterests.Size = new System.Drawing.Size(335, 30);
            this.mCmbInterests.TabIndex = 9;
            this.mCmbInterests.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mCmbInterests.UseSelectable = true;
            // 
            // mTileSaveProfile
            // 
            this.mTileSaveProfile.ActiveControl = null;
            this.mTileSaveProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.mTileSaveProfile.Location = new System.Drawing.Point(344, 231);
            this.mTileSaveProfile.Name = "mTileSaveProfile";
            this.mTileSaveProfile.Size = new System.Drawing.Size(107, 51);
            this.mTileSaveProfile.TabIndex = 12;
            this.mTileSaveProfile.Text = "&Save Profile";
            this.mTileSaveProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileSaveProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileSaveProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTileSaveProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileSaveProfile.UseSelectable = true;
            this.mTileSaveProfile.Click += new System.EventHandler(this.mTileSaveProfile_Click);
            // 
            // mTitleAddInterests
            // 
            this.mTitleAddInterests.ActiveControl = null;
            this.mTitleAddInterests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTitleAddInterests.Location = new System.Drawing.Point(3, 288);
            this.mTitleAddInterests.Name = "mTitleAddInterests";
            this.mTitleAddInterests.Size = new System.Drawing.Size(107, 53);
            this.mTitleAddInterests.TabIndex = 13;
            this.mTitleAddInterests.Text = "&Add Interests";
            this.mTitleAddInterests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTitleAddInterests.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTitleAddInterests.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTitleAddInterests.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTitleAddInterests.UseSelectable = true;
            // 
            // grpProfessional
            // 
            this.grpProfessional.Controls.Add(this.tlpProfessional);
            this.grpProfessional.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProfessional.Location = new System.Drawing.Point(20, 425);
            this.grpProfessional.Name = "grpProfessional";
            this.grpProfessional.Size = new System.Drawing.Size(460, 200);
            this.grpProfessional.TabIndex = 2;
            this.grpProfessional.TabStop = false;
            this.grpProfessional.Text = "Educational";
            // 
            // tlpProfessional
            // 
            this.tlpProfessional.ColumnCount = 2;
            this.tlpProfessional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProfessional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpProfessional.Controls.Add(this.mLblSchool, 0, 0);
            this.tlpProfessional.Controls.Add(this.mLblYearGraduated, 0, 1);
            this.tlpProfessional.Controls.Add(this.mCmbSchool, 1, 0);
            this.tlpProfessional.Controls.Add(this.mTxtYearGraduated, 1, 1);
            this.tlpProfessional.Controls.Add(this.mTileAddEducation, 0, 2);
            this.tlpProfessional.Controls.Add(this.mTileDeleteEducation, 1, 2);
            this.tlpProfessional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfessional.Location = new System.Drawing.Point(3, 18);
            this.tlpProfessional.Name = "tlpProfessional";
            this.tlpProfessional.RowCount = 3;
            this.tlpProfessional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProfessional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProfessional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProfessional.Size = new System.Drawing.Size(454, 179);
            this.tlpProfessional.TabIndex = 0;
            // 
            // mLblSchool
            // 
            this.mLblSchool.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblSchool.AutoSize = true;
            this.mLblSchool.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblSchool.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblSchool.Location = new System.Drawing.Point(86, 21);
            this.mLblSchool.Name = "mLblSchool";
            this.mLblSchool.Size = new System.Drawing.Size(47, 17);
            this.mLblSchool.TabIndex = 4;
            this.mLblSchool.Text = "School";
            this.mLblSchool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblSchool.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblYearGraduated
            // 
            this.mLblYearGraduated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblYearGraduated.AutoSize = true;
            this.mLblYearGraduated.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblYearGraduated.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblYearGraduated.Location = new System.Drawing.Point(34, 80);
            this.mLblYearGraduated.Name = "mLblYearGraduated";
            this.mLblYearGraduated.Size = new System.Drawing.Size(99, 17);
            this.mLblYearGraduated.TabIndex = 5;
            this.mLblYearGraduated.Text = "Year Graduated";
            this.mLblYearGraduated.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblYearGraduated.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mCmbSchool
            // 
            this.mCmbSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbSchool.FormattingEnabled = true;
            this.mCmbSchool.ItemHeight = 24;
            this.mCmbSchool.Location = new System.Drawing.Point(139, 14);
            this.mCmbSchool.Name = "mCmbSchool";
            this.mCmbSchool.Size = new System.Drawing.Size(312, 30);
            this.mCmbSchool.TabIndex = 9;
            this.mCmbSchool.UseSelectable = true;
            // 
            // mTxtYearGraduated
            // 
            this.mTxtYearGraduated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTxtYearGraduated.CustomButton.Image = null;
            this.mTxtYearGraduated.CustomButton.Location = new System.Drawing.Point(41, 2);
            this.mTxtYearGraduated.CustomButton.Name = "";
            this.mTxtYearGraduated.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTxtYearGraduated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtYearGraduated.CustomButton.TabIndex = 1;
            this.mTxtYearGraduated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtYearGraduated.CustomButton.UseSelectable = true;
            this.mTxtYearGraduated.CustomButton.Visible = false;
            this.mTxtYearGraduated.Lines = new string[0];
            this.mTxtYearGraduated.Location = new System.Drawing.Point(139, 70);
            this.mTxtYearGraduated.MaxLength = 32767;
            this.mTxtYearGraduated.Name = "mTxtYearGraduated";
            this.mTxtYearGraduated.PasswordChar = '\0';
            this.mTxtYearGraduated.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtYearGraduated.SelectedText = "";
            this.mTxtYearGraduated.SelectionLength = 0;
            this.mTxtYearGraduated.SelectionStart = 0;
            this.mTxtYearGraduated.ShortcutsEnabled = true;
            this.mTxtYearGraduated.Size = new System.Drawing.Size(75, 36);
            this.mTxtYearGraduated.TabIndex = 10;
            this.mTxtYearGraduated.UseSelectable = true;
            this.mTxtYearGraduated.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtYearGraduated.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTileAddEducation
            // 
            this.mTileAddEducation.ActiveControl = null;
            this.mTileAddEducation.Dock = System.Windows.Forms.DockStyle.Right;
            this.mTileAddEducation.Location = new System.Drawing.Point(3, 121);
            this.mTileAddEducation.Name = "mTileAddEducation";
            this.mTileAddEducation.Size = new System.Drawing.Size(130, 55);
            this.mTileAddEducation.TabIndex = 11;
            this.mTileAddEducation.Text = "&Add";
            this.mTileAddEducation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddEducation.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddEducation.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTileAddEducation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAddEducation.UseSelectable = true;
            // 
            // mTileDeleteEducation
            // 
            this.mTileDeleteEducation.ActiveControl = null;
            this.mTileDeleteEducation.Dock = System.Windows.Forms.DockStyle.Right;
            this.mTileDeleteEducation.Location = new System.Drawing.Point(321, 121);
            this.mTileDeleteEducation.Name = "mTileDeleteEducation";
            this.mTileDeleteEducation.Size = new System.Drawing.Size(130, 55);
            this.mTileDeleteEducation.TabIndex = 12;
            this.mTileDeleteEducation.Text = "&Delete";
            this.mTileDeleteEducation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDeleteEducation.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDeleteEducation.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTileDeleteEducation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileDeleteEducation.UseSelectable = true;
            // 
            // grpEducation
            // 
            this.grpEducation.Controls.Add(this.tlpEducation);
            this.grpEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEducation.Location = new System.Drawing.Point(20, 625);
            this.grpEducation.Name = "grpEducation";
            this.grpEducation.Size = new System.Drawing.Size(460, 200);
            this.grpEducation.TabIndex = 3;
            this.grpEducation.TabStop = false;
            this.grpEducation.Text = "Professional";
            // 
            // tlpEducation
            // 
            this.tlpEducation.ColumnCount = 2;
            this.tlpEducation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEducation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpEducation.Controls.Add(this.mLblEmployer, 0, 0);
            this.tlpEducation.Controls.Add(this.mLblJobTitle, 0, 1);
            this.tlpEducation.Controls.Add(this.mCmbEmployer, 1, 0);
            this.tlpEducation.Controls.Add(this.mTxtJobTitle, 1, 1);
            this.tlpEducation.Controls.Add(this.mTileAddProfessional, 0, 2);
            this.tlpEducation.Controls.Add(this.mTileDeleteProfessional, 1, 2);
            this.tlpEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEducation.Location = new System.Drawing.Point(3, 18);
            this.tlpEducation.Name = "tlpEducation";
            this.tlpEducation.RowCount = 3;
            this.tlpEducation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpEducation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpEducation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpEducation.Size = new System.Drawing.Size(454, 179);
            this.tlpEducation.TabIndex = 1;
            // 
            // mLblEmployer
            // 
            this.mLblEmployer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblEmployer.AutoSize = true;
            this.mLblEmployer.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblEmployer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblEmployer.Location = new System.Drawing.Point(70, 21);
            this.mLblEmployer.Name = "mLblEmployer";
            this.mLblEmployer.Size = new System.Drawing.Size(63, 17);
            this.mLblEmployer.TabIndex = 4;
            this.mLblEmployer.Text = "Employer";
            this.mLblEmployer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblEmployer.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mLblJobTitle
            // 
            this.mLblJobTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblJobTitle.AutoSize = true;
            this.mLblJobTitle.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mLblJobTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mLblJobTitle.Location = new System.Drawing.Point(76, 80);
            this.mLblJobTitle.Name = "mLblJobTitle";
            this.mLblJobTitle.Size = new System.Drawing.Size(57, 17);
            this.mLblJobTitle.TabIndex = 5;
            this.mLblJobTitle.Text = "Job Title";
            this.mLblJobTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mLblJobTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mCmbEmployer
            // 
            this.mCmbEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mCmbEmployer.FormattingEnabled = true;
            this.mCmbEmployer.ItemHeight = 24;
            this.mCmbEmployer.Location = new System.Drawing.Point(139, 14);
            this.mCmbEmployer.Name = "mCmbEmployer";
            this.mCmbEmployer.Size = new System.Drawing.Size(312, 30);
            this.mCmbEmployer.TabIndex = 9;
            this.mCmbEmployer.UseSelectable = true;
            // 
            // mTxtJobTitle
            // 
            this.mTxtJobTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTxtJobTitle.CustomButton.Image = null;
            this.mTxtJobTitle.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.mTxtJobTitle.CustomButton.Name = "";
            this.mTxtJobTitle.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTxtJobTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtJobTitle.CustomButton.TabIndex = 1;
            this.mTxtJobTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtJobTitle.CustomButton.UseSelectable = true;
            this.mTxtJobTitle.CustomButton.Visible = false;
            this.mTxtJobTitle.Lines = new string[0];
            this.mTxtJobTitle.Location = new System.Drawing.Point(139, 70);
            this.mTxtJobTitle.MaxLength = 32767;
            this.mTxtJobTitle.Name = "mTxtJobTitle";
            this.mTxtJobTitle.PasswordChar = '\0';
            this.mTxtJobTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtJobTitle.SelectedText = "";
            this.mTxtJobTitle.SelectionLength = 0;
            this.mTxtJobTitle.SelectionStart = 0;
            this.mTxtJobTitle.ShortcutsEnabled = true;
            this.mTxtJobTitle.Size = new System.Drawing.Size(312, 36);
            this.mTxtJobTitle.TabIndex = 10;
            this.mTxtJobTitle.UseSelectable = true;
            this.mTxtJobTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtJobTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTileAddProfessional
            // 
            this.mTileAddProfessional.ActiveControl = null;
            this.mTileAddProfessional.Dock = System.Windows.Forms.DockStyle.Right;
            this.mTileAddProfessional.Location = new System.Drawing.Point(3, 121);
            this.mTileAddProfessional.Name = "mTileAddProfessional";
            this.mTileAddProfessional.Size = new System.Drawing.Size(130, 55);
            this.mTileAddProfessional.TabIndex = 11;
            this.mTileAddProfessional.Text = "&Add";
            this.mTileAddProfessional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddProfessional.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddProfessional.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTileAddProfessional.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAddProfessional.UseSelectable = true;
            // 
            // mTileDeleteProfessional
            // 
            this.mTileDeleteProfessional.ActiveControl = null;
            this.mTileDeleteProfessional.Dock = System.Windows.Forms.DockStyle.Right;
            this.mTileDeleteProfessional.Location = new System.Drawing.Point(321, 121);
            this.mTileDeleteProfessional.Name = "mTileDeleteProfessional";
            this.mTileDeleteProfessional.Size = new System.Drawing.Size(130, 55);
            this.mTileDeleteProfessional.TabIndex = 12;
            this.mTileDeleteProfessional.Text = "&Delete";
            this.mTileDeleteProfessional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDeleteProfessional.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDeleteProfessional.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mTileDeleteProfessional.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileDeleteProfessional.UseSelectable = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 850);
            this.Controls.Add(this.grpEducation);
            this.Controls.Add(this.grpProfessional);
            this.Controls.Add(this.grpProfile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.Resizable = false;
            this.Text = "Profile Form";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.grpProfile.ResumeLayout(false);
            this.tlpProfile.ResumeLayout(false);
            this.tlpProfile.PerformLayout();
            this.grpProfessional.ResumeLayout(false);
            this.tlpProfessional.ResumeLayout(false);
            this.tlpProfessional.PerformLayout();
            this.grpEducation.ResumeLayout(false);
            this.tlpEducation.ResumeLayout(false);
            this.tlpEducation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.GroupBox grpProfessional;
        private System.Windows.Forms.TableLayoutPanel tlpProfile;
        private MetroFramework.Controls.MetroLabel mLblGender;
        private MetroFramework.Controls.MetroLabel mLblBirthdate;
        private MetroFramework.Controls.MetroLabel mLblCurrentCity;
        private MetroFramework.Controls.MetroLabel mLblHometown;
        private MetroFramework.Controls.MetroLabel mLblInterests;
        private MetroFramework.Controls.MetroComboBox mCmbGender;
        private MetroFramework.Controls.MetroDateTime mDateTimeBirthdate;
        private MetroFramework.Controls.MetroComboBox mCmbCurrentCity;
        private MetroFramework.Controls.MetroComboBox mCmbHometown;
        private MetroFramework.Controls.MetroComboBox mCmbInterests;
        private System.Windows.Forms.TableLayoutPanel tlpProfessional;
        private MetroFramework.Controls.MetroLabel mLblSchool;
        private MetroFramework.Controls.MetroLabel mLblYearGraduated;
        private MetroFramework.Controls.MetroComboBox mCmbSchool;
        private MetroFramework.Controls.MetroTextBox mTxtYearGraduated;
        private MetroFramework.Controls.MetroTile mTileAddEducation;
        private MetroFramework.Controls.MetroTile mTileDeleteEducation;
        private MetroFramework.Controls.MetroTile mTileSaveProfile;
        private MetroFramework.Controls.MetroTile mTitleAddInterests;
        private System.Windows.Forms.GroupBox grpEducation;
        private System.Windows.Forms.TableLayoutPanel tlpEducation;
        private MetroFramework.Controls.MetroLabel mLblEmployer;
        private MetroFramework.Controls.MetroLabel mLblJobTitle;
        private MetroFramework.Controls.MetroComboBox mCmbEmployer;
        private MetroFramework.Controls.MetroTextBox mTxtJobTitle;
        private MetroFramework.Controls.MetroTile mTileAddProfessional;
        private MetroFramework.Controls.MetroTile mTileDeleteProfessional;
    }
}