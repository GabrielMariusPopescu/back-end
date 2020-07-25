namespace Connector.Presentation
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.mpnlRegistration = new MetroFramework.Controls.MetroPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mLblAdmin = new MetroFramework.Controls.MetroLabel();
            this.mTileCancel = new MetroFramework.Controls.MetroTile();
            this.mTileRegistration = new MetroFramework.Controls.MetroTile();
            this.mLblFirstName = new MetroFramework.Controls.MetroLabel();
            this.mLblLastName = new MetroFramework.Controls.MetroLabel();
            this.mTxtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.mTxtLastName = new MetroFramework.Controls.MetroTextBox();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.mchkAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.mpnlRegistration.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnlRegistration
            // 
            this.mpnlRegistration.Controls.Add(this.tlpMain);
            this.mpnlRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnlRegistration.HorizontalScrollbarBarColor = true;
            this.mpnlRegistration.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlRegistration.HorizontalScrollbarSize = 10;
            this.mpnlRegistration.Location = new System.Drawing.Point(20, 60);
            this.mpnlRegistration.Name = "mpnlRegistration";
            this.mpnlRegistration.Size = new System.Drawing.Size(614, 360);
            this.mpnlRegistration.TabIndex = 0;
            this.mpnlRegistration.VerticalScrollbarBarColor = true;
            this.mpnlRegistration.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlRegistration.VerticalScrollbarSize = 10;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.mLblAdmin, 0, 1);
            this.tlpMain.Controls.Add(this.mTileCancel, 0, 3);
            this.tlpMain.Controls.Add(this.mTileRegistration, 2, 3);
            this.tlpMain.Controls.Add(this.mLblFirstName, 1, 1);
            this.tlpMain.Controls.Add(this.mLblLastName, 1, 2);
            this.tlpMain.Controls.Add(this.mTxtFirstName, 2, 1);
            this.tlpMain.Controls.Add(this.mTxtLastName, 2, 2);
            this.tlpMain.Controls.Add(this.mTileAbout, 1, 0);
            this.tlpMain.Controls.Add(this.pctBoxLogo, 0, 0);
            this.tlpMain.Controls.Add(this.mchkAdmin, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(614, 360);
            this.tlpMain.TabIndex = 3;
            // 
            // mLblAdmin
            // 
            this.mLblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLblAdmin.AutoSize = true;
            this.mLblAdmin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblAdmin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblAdmin.ForeColor = System.Drawing.Color.Crimson;
            this.mLblAdmin.Location = new System.Drawing.Point(25, 122);
            this.mLblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLblAdmin.Name = "mLblAdmin";
            this.mLblAdmin.Size = new System.Drawing.Size(71, 25);
            this.mLblAdmin.Style = MetroFramework.MetroColorStyle.Red;
            this.mLblAdmin.TabIndex = 8;
            this.mLblAdmin.Text = "Admin";
            this.mLblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblAdmin.UseStyleColors = true;
            // 
            // mTileCancel
            // 
            this.mTileCancel.ActiveControl = null;
            this.mTileCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpMain.SetColumnSpan(this.mTileCancel, 2);
            this.mTileCancel.Location = new System.Drawing.Point(4, 274);
            this.mTileCancel.Margin = new System.Windows.Forms.Padding(4);
            this.mTileCancel.Name = "mTileCancel";
            this.mTileCancel.Size = new System.Drawing.Size(275, 82);
            this.mTileCancel.TabIndex = 3;
            this.mTileCancel.Text = "Cancel Registration";
            this.mTileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mTileCancel.UseSelectable = true;
            this.mTileCancel.Click += new System.EventHandler(this.mTileCancel_Click);
            // 
            // mTileRegistration
            // 
            this.mTileRegistration.ActiveControl = null;
            this.mTileRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTileRegistration.Location = new System.Drawing.Point(312, 274);
            this.mTileRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.mTileRegistration.Name = "mTileRegistration";
            this.mTileRegistration.Size = new System.Drawing.Size(298, 82);
            this.mTileRegistration.TabIndex = 4;
            this.mTileRegistration.Text = "Continue Registration";
            this.mTileRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileRegistration.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileRegistration.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mTileRegistration.UseSelectable = true;
            this.mTileRegistration.Click += new System.EventHandler(this.mTileRegistration_Click);
            // 
            // mLblFirstName
            // 
            this.mLblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblFirstName.AutoSize = true;
            this.mLblFirstName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblFirstName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblFirstName.ForeColor = System.Drawing.Color.Teal;
            this.mLblFirstName.Location = new System.Drawing.Point(195, 122);
            this.mLblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLblFirstName.Name = "mLblFirstName";
            this.mLblFirstName.Size = new System.Drawing.Size(107, 25);
            this.mLblFirstName.Style = MetroFramework.MetroColorStyle.Teal;
            this.mLblFirstName.TabIndex = 2;
            this.mLblFirstName.Text = "First Name";
            this.mLblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblFirstName.UseStyleColors = true;
            // 
            // mLblLastName
            // 
            this.mLblLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblLastName.AutoSize = true;
            this.mLblLastName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblLastName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblLastName.ForeColor = System.Drawing.Color.Teal;
            this.mLblLastName.Location = new System.Drawing.Point(198, 212);
            this.mLblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLblLastName.Name = "mLblLastName";
            this.mLblLastName.Size = new System.Drawing.Size(104, 25);
            this.mLblLastName.Style = MetroFramework.MetroColorStyle.Teal;
            this.mLblLastName.TabIndex = 3;
            this.mLblLastName.Text = "Last Name";
            this.mLblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblLastName.UseStyleColors = true;
            // 
            // mTxtFirstName
            // 
            this.mTxtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTxtFirstName.CustomButton.Image = null;
            this.mTxtFirstName.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.mTxtFirstName.CustomButton.Name = "";
            this.mTxtFirstName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTxtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtFirstName.CustomButton.TabIndex = 1;
            this.mTxtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtFirstName.CustomButton.UseSelectable = true;
            this.mTxtFirstName.CustomButton.Visible = false;
            this.mTxtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtFirstName.Lines = new string[0];
            this.mTxtFirstName.Location = new System.Drawing.Point(311, 120);
            this.mTxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtFirstName.MaxLength = 32767;
            this.mTxtFirstName.Name = "mTxtFirstName";
            this.mTxtFirstName.PasswordChar = '\0';
            this.mTxtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtFirstName.SelectedText = "";
            this.mTxtFirstName.SelectionLength = 0;
            this.mTxtFirstName.SelectionStart = 0;
            this.mTxtFirstName.ShortcutsEnabled = true;
            this.mTxtFirstName.Size = new System.Drawing.Size(297, 29);
            this.mTxtFirstName.TabIndex = 1;
            this.mTxtFirstName.UseSelectable = true;
            this.mTxtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxtLastName
            // 
            this.mTxtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTxtLastName.CustomButton.Image = null;
            this.mTxtLastName.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.mTxtLastName.CustomButton.Name = "";
            this.mTxtLastName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTxtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtLastName.CustomButton.TabIndex = 1;
            this.mTxtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtLastName.CustomButton.UseSelectable = true;
            this.mTxtLastName.CustomButton.Visible = false;
            this.mTxtLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtLastName.Lines = new string[0];
            this.mTxtLastName.Location = new System.Drawing.Point(311, 210);
            this.mTxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtLastName.MaxLength = 32767;
            this.mTxtLastName.Name = "mTxtLastName";
            this.mTxtLastName.PasswordChar = '\0';
            this.mTxtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtLastName.SelectedText = "";
            this.mTxtLastName.SelectionLength = 0;
            this.mTxtLastName.SelectionStart = 0;
            this.mTxtLastName.ShortcutsEnabled = true;
            this.mTxtLastName.Size = new System.Drawing.Size(297, 29);
            this.mTxtLastName.TabIndex = 2;
            this.mTxtLastName.UseSelectable = true;
            this.mTxtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTileAbout
            // 
            this.mTileAbout.ActiveControl = null;
            this.tlpMain.SetColumnSpan(this.mTileAbout, 2);
            this.mTileAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTileAbout.Location = new System.Drawing.Point(126, 4);
            this.mTileAbout.Margin = new System.Windows.Forms.Padding(4);
            this.mTileAbout.Name = "mTileAbout";
            this.mTileAbout.Size = new System.Drawing.Size(484, 82);
            this.mTileAbout.Style = MetroFramework.MetroColorStyle.Green;
            this.mTileAbout.TabIndex = 6;
            this.mTileAbout.Text = "Lite Social Network For Networking Socialities";
            this.mTileAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileAbout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mTileAbout.UseSelectable = true;
            this.mTileAbout.Click += new System.EventHandler(this.mTileAbout_Click);
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxLogo.Image")));
            this.pctBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctBoxLogo.InitialImage")));
            this.pctBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.pctBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(114, 82);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 7;
            this.pctBoxLogo.TabStop = false;
            // 
            // mchkAdmin
            // 
            this.mchkAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mchkAdmin.Appearance = System.Windows.Forms.Appearance.Button;
            this.mchkAdmin.AutoSize = true;
            this.mchkAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mchkAdmin.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkAdmin.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.mchkAdmin.Location = new System.Drawing.Point(53, 225);
            this.mchkAdmin.MaximumSize = new System.Drawing.Size(40, 40);
            this.mchkAdmin.MinimumSize = new System.Drawing.Size(40, 40);
            this.mchkAdmin.Name = "mchkAdmin";
            this.mchkAdmin.Size = new System.Drawing.Size(40, 40);
            this.mchkAdmin.Style = MetroFramework.MetroColorStyle.Red;
            this.mchkAdmin.TabIndex = 9;
            this.mchkAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mchkAdmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mchkAdmin.UseSelectable = true;
            this.mchkAdmin.UseStyleColors = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(654, 440);
            this.Controls.Add(this.mpnlRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Registration Form";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.mpnlRegistration.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnlRegistration;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTile mTileCancel;
        private MetroFramework.Controls.MetroTile mTileRegistration;
        private MetroFramework.Controls.MetroLabel mLblFirstName;
        private MetroFramework.Controls.MetroLabel mLblLastName;
        private MetroFramework.Controls.MetroTextBox mTxtFirstName;
        private MetroFramework.Controls.MetroTextBox mTxtLastName;
        private MetroFramework.Controls.MetroTile mTileAbout;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private MetroFramework.Controls.MetroLabel mLblAdmin;
        private MetroFramework.Controls.MetroCheckBox mchkAdmin;
    }
}