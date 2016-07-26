namespace DCCharacters
{
    partial class firstAppearance
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
            this.pcbFirst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFirst
            // 
            this.pcbFirst.Location = new System.Drawing.Point(12, 12);
            this.pcbFirst.Name = "pcbFirst";
            this.pcbFirst.Size = new System.Drawing.Size(311, 461);
            this.pcbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFirst.TabIndex = 0;
            this.pcbFirst.TabStop = false;
            this.pcbFirst.Click += new System.EventHandler(this.pcbFirst_Click);
            // 
            // firstAppearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(336, 485);
            this.Controls.Add(this.pcbFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "firstAppearance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "firstAppearance";
            this.Load += new System.EventHandler(this.firstAppearance_Load);
            this.Click += new System.EventHandler(this.firstAppearance_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFirst;
    }
}