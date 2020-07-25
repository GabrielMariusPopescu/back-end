﻿namespace FindMethods.WFP
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
      this.pnlLeft = new System.Windows.Forms.Panel();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnLoad = new System.Windows.Forms.Button();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lstBoxMethods = new System.Windows.Forms.ListBox();
      this.pnlLeft.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlLeft
      // 
      this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlLeft.Controls.Add(this.btnExit);
      this.pnlLeft.Controls.Add(this.btnLoad);
      this.pnlLeft.Controls.Add(this.lblTitle);
      this.pnlLeft.Controls.Add(this.lstBoxMethods);
      this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlLeft.Location = new System.Drawing.Point(0, 0);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Size = new System.Drawing.Size(1184, 761);
      this.pnlLeft.TabIndex = 1;
      // 
      // btnExit
      // 
      this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.Location = new System.Drawing.Point(1071, 7);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(100, 43);
      this.btnExit.TabIndex = 1;
      this.btnExit.Text = "E&xit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnLoad
      // 
      this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLoad.Location = new System.Drawing.Point(412, 7);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(169, 42);
      this.btnLoad.TabIndex = 2;
      this.btnLoad.Text = "Load Methods";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(11, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(395, 42);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "LS.Common Methods";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lstBoxMethods
      // 
      this.lstBoxMethods.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lstBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstBoxMethods.FormattingEnabled = true;
      this.lstBoxMethods.ItemHeight = 24;
      this.lstBoxMethods.Location = new System.Drawing.Point(0, 59);
      this.lstBoxMethods.Name = "lstBoxMethods";
      this.lstBoxMethods.Size = new System.Drawing.Size(1182, 700);
      this.lstBoxMethods.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1184, 761);
      this.Controls.Add(this.pnlLeft);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Find Methods";
      this.pnlLeft.ResumeLayout(false);
      this.pnlLeft.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.ListBox lstBoxMethods;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.Button btnExit;
  }
}

