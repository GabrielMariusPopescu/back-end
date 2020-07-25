namespace TreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radTreeView2 = new Telerik.WinControls.UI.RadTreeView();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // iconsList
            // 
            this.iconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsList.ImageStream")));
            this.iconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsList.Images.SetKeyName(0, "all_emails.png");
            this.iconsList.Images.SetKeyName(1, "e_mail.png");
            this.iconsList.Images.SetKeyName(2, "email_attachment.png");
            this.iconsList.Images.SetKeyName(3, "email_mark_important.png");
            this.iconsList.Images.SetKeyName(4, "email_open.png");
            this.iconsList.Images.SetKeyName(5, "email_replied.png");
            this.iconsList.Images.SetKeyName(6, "sent_mail.png");
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1089, 764);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "rsc";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radTreeView1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(542, 764);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radTreeView2);
            this.splitPanel2.Location = new System.Drawing.Point(546, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(543, 764);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radTreeView1
            // 
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(542, 764);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ItemDrag += new Telerik.WinControls.UI.RadTreeView.ItemDragHandler(this.radTreeView1_ItemDrag);
            this.radTreeView1.DragEnded += new Telerik.WinControls.UI.RadTreeView.DragEndedHandler(this.radTreeView1_DragEnded);
            // 
            // radTreeView2
            // 
            this.radTreeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView2.Location = new System.Drawing.Point(0, 0);
            this.radTreeView2.Name = "radTreeView2";
            this.radTreeView2.Size = new System.Drawing.Size(543, 764);
            this.radTreeView2.SpacingBetweenNodes = -1;
            this.radTreeView2.TabIndex = 0;
            this.radTreeView2.Text = "radTreeView2";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTextBox1.Location = new System.Drawing.Point(0, 0);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(1089, 24);
            this.radTextBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 764);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag \'n\' Drop Tree View";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iconsList;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadTreeView radTreeView2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}