namespace LightSwitch
{
    partial class LightSwitch
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.Location = new System.Drawing.Point(3, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(194, 259);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            // 
            // btnOn
            // 
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Location = new System.Drawing.Point(51, 276);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(40, 23);
            this.btnOn.TabIndex = 1;
            this.btnOn.Text = "ON";
            this.btnOn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(97, 276);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(40, 23);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "OFF";
            this.btnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // LightSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(202, 305);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.pctBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LightSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightSwitch";
            this.Load += new System.EventHandler(this.LightSwitch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
    }
}

