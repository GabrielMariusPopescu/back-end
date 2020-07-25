namespace Connector.Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpnlMain = new MetroFramework.Controls.MetroPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mTileRegister = new MetroFramework.Controls.MetroTile();
            this.mTileLogIn = new MetroFramework.Controls.MetroTile();
            this.mLblEmail = new MetroFramework.Controls.MetroLabel();
            this.mLblPassword = new MetroFramework.Controls.MetroLabel();
            this.mTxtBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.mTxtBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.mpnlMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnlMain
            // 
            this.mpnlMain.Controls.Add(this.tlpMain);
            this.mpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnlMain.HorizontalScrollbarBarColor = true;
            this.mpnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlMain.HorizontalScrollbarSize = 13;
            this.mpnlMain.Location = new System.Drawing.Point(29, 90);
            this.mpnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.mpnlMain.Name = "mpnlMain";
            this.mpnlMain.Size = new System.Drawing.Size(597, 322);
            this.mpnlMain.TabIndex = 0;
            this.mpnlMain.VerticalScrollbarBarColor = true;
            this.mpnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlMain.VerticalScrollbarSize = 13;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.mTileRegister, 0, 3);
            this.tlpMain.Controls.Add(this.mTileLogIn, 2, 3);
            this.tlpMain.Controls.Add(this.mLblEmail, 1, 1);
            this.tlpMain.Controls.Add(this.mLblPassword, 1, 2);
            this.tlpMain.Controls.Add(this.mTxtBoxEmail, 2, 1);
            this.tlpMain.Controls.Add(this.mTxtBoxPassword, 2, 2);
            this.tlpMain.Controls.Add(this.mTileAbout, 1, 0);
            this.tlpMain.Controls.Add(this.pctBoxLogo, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(597, 322);
            this.tlpMain.TabIndex = 2;
            // 
            // mTileRegister
            // 
            this.mTileRegister.ActiveControl = null;
            this.mTileRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpMain.SetColumnSpan(this.mTileRegister, 2);
            this.mTileRegister.Location = new System.Drawing.Point(4, 244);
            this.mTileRegister.Margin = new System.Windows.Forms.Padding(4);
            this.mTileRegister.Name = "mTileRegister";
            this.mTileRegister.Size = new System.Drawing.Size(290, 74);
            this.mTileRegister.TabIndex = 3;
            this.mTileRegister.Text = "Continue Registration";
            this.mTileRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileRegister.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileRegister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mTileRegister.UseSelectable = true;
            this.mTileRegister.Click += new System.EventHandler(this.mTileRegister_Click);
            // 
            // mTileLogIn
            // 
            this.mTileLogIn.ActiveControl = null;
            this.mTileLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTileLogIn.Location = new System.Drawing.Point(302, 244);
            this.mTileLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.mTileLogIn.Name = "mTileLogIn";
            this.mTileLogIn.Size = new System.Drawing.Size(291, 74);
            this.mTileLogIn.TabIndex = 4;
            this.mTileLogIn.Text = "Continue Login";
            this.mTileLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileLogIn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileLogIn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mTileLogIn.UseSelectable = true;
            this.mTileLogIn.Click += new System.EventHandler(this.mTileLogIn_Click);
            // 
            // mLblEmail
            // 
            this.mLblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblEmail.AutoSize = true;
            this.mLblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblEmail.ForeColor = System.Drawing.Color.Teal;
            this.mLblEmail.Location = new System.Drawing.Point(235, 107);
            this.mLblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLblEmail.Name = "mLblEmail";
            this.mLblEmail.Size = new System.Drawing.Size(59, 25);
            this.mLblEmail.Style = MetroFramework.MetroColorStyle.Teal;
            this.mLblEmail.TabIndex = 2;
            this.mLblEmail.Text = "Email";
            this.mLblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblEmail.UseStyleColors = true;
            // 
            // mLblPassword
            // 
            this.mLblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mLblPassword.AutoSize = true;
            this.mLblPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblPassword.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblPassword.ForeColor = System.Drawing.Color.Teal;
            this.mLblPassword.Location = new System.Drawing.Point(197, 187);
            this.mLblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLblPassword.Name = "mLblPassword";
            this.mLblPassword.Size = new System.Drawing.Size(97, 25);
            this.mLblPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.mLblPassword.TabIndex = 3;
            this.mLblPassword.Text = "Password";
            this.mLblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblPassword.UseStyleColors = true;
            // 
            // mTxtBoxEmail
            // 
            this.mTxtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mTxtBoxEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTxtBoxEmail.Lines = new string[0];
            this.mTxtBoxEmail.Location = new System.Drawing.Point(302, 105);
            this.mTxtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtBoxEmail.MaxLength = 32767;
            this.mTxtBoxEmail.Name = "mTxtBoxEmail";
            this.mTxtBoxEmail.PasswordChar = '\0';
            this.mTxtBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtBoxEmail.SelectedText = "";
            this.mTxtBoxEmail.SelectionLength = 0;
            this.mTxtBoxEmail.SelectionStart = 0;
            this.mTxtBoxEmail.ShortcutsEnabled = true;
            this.mTxtBoxEmail.Size = new System.Drawing.Size(291, 29);
            this.mTxtBoxEmail.TabIndex = 1;
            this.mTxtBoxEmail.UseSelectable = true;
            this.mTxtBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtBoxEmail.Validated += new System.EventHandler(this.mTxtBoxEmail_Validated);
            // 
            // mTxtBoxPassword
            // 
            this.mTxtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mTxtBoxPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTxtBoxPassword.Lines = new string[0];
            this.mTxtBoxPassword.Location = new System.Drawing.Point(302, 185);
            this.mTxtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtBoxPassword.MaxLength = 32767;
            this.mTxtBoxPassword.Name = "mTxtBoxPassword";
            this.mTxtBoxPassword.PasswordChar = '*';
            this.mTxtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtBoxPassword.SelectedText = "";
            this.mTxtBoxPassword.SelectionLength = 0;
            this.mTxtBoxPassword.SelectionStart = 0;
            this.mTxtBoxPassword.ShortcutsEnabled = true;
            this.mTxtBoxPassword.Size = new System.Drawing.Size(291, 29);
            this.mTxtBoxPassword.TabIndex = 2;
            this.mTxtBoxPassword.UseSelectable = true;
            this.mTxtBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtBoxPassword.Validated += new System.EventHandler(this.mTxtBoxPassword_Validated);
            // 
            // mTileAbout
            // 
            this.mTileAbout.ActiveControl = null;
            this.tlpMain.SetColumnSpan(this.mTileAbout, 2);
            this.mTileAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTileAbout.Location = new System.Drawing.Point(123, 4);
            this.mTileAbout.Margin = new System.Windows.Forms.Padding(4);
            this.mTileAbout.Name = "mTileAbout";
            this.mTileAbout.Size = new System.Drawing.Size(470, 72);
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
            this.pctBoxLogo.Location = new System.Drawing.Point(4, 4);
            this.pctBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(111, 72);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 7;
            this.pctBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomRight;
            this.ClientSize = new System.Drawing.Size(655, 442);
            this.Controls.Add(this.mpnlMain);
            this.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(29, 90, 29, 30);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Connector";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mpnlMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTile mTileRegister;
        private MetroFramework.Controls.MetroTile mTileLogIn;
        private MetroFramework.Controls.MetroLabel mLblEmail;
        private MetroFramework.Controls.MetroLabel mLblPassword;
        private MetroFramework.Controls.MetroTextBox mTxtBoxEmail;
        private MetroFramework.Controls.MetroTextBox mTxtBoxPassword;
        private MetroFramework.Controls.MetroTile mTileAbout;
        private System.Windows.Forms.PictureBox pctBoxLogo;
    }
}

