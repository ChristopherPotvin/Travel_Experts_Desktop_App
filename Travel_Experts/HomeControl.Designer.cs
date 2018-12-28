namespace Travel_Experts
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLinkdn = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwitter = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsta = new System.Windows.Forms.PictureBox();
            this.picBoxFB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Page Control";
            // 
            // pictureBoxLinkdn
            // 
            this.pictureBoxLinkdn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLinkdn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLinkdn.Image")));
            this.pictureBoxLinkdn.Location = new System.Drawing.Point(543, 381);
            this.pictureBoxLinkdn.Name = "pictureBoxLinkdn";
            this.pictureBoxLinkdn.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxLinkdn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLinkdn.TabIndex = 27;
            this.pictureBoxLinkdn.TabStop = false;
            this.pictureBoxLinkdn.Click += new System.EventHandler(this.pictureBoxLinkdn_Click_1);
            // 
            // pictureBoxTwitter
            // 
            this.pictureBoxTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTwitter.Image")));
            this.pictureBoxTwitter.Location = new System.Drawing.Point(501, 381);
            this.pictureBoxTwitter.Name = "pictureBoxTwitter";
            this.pictureBoxTwitter.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTwitter.TabIndex = 26;
            this.pictureBoxTwitter.TabStop = false;
            this.pictureBoxTwitter.Click += new System.EventHandler(this.pictureBoxTwitter_Click_1);
            // 
            // pictureBoxInsta
            // 
            this.pictureBoxInsta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInsta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInsta.Image")));
            this.pictureBoxInsta.Location = new System.Drawing.Point(459, 381);
            this.pictureBoxInsta.Name = "pictureBoxInsta";
            this.pictureBoxInsta.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxInsta.TabIndex = 25;
            this.pictureBoxInsta.TabStop = false;
            this.pictureBoxInsta.Click += new System.EventHandler(this.pictureBoxInsta_Click_1);
            // 
            // picBoxFB
            // 
            this.picBoxFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFB.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFB.Image")));
            this.picBoxFB.Location = new System.Drawing.Point(417, 381);
            this.picBoxFB.Name = "picBoxFB";
            this.picBoxFB.Size = new System.Drawing.Size(36, 36);
            this.picBoxFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFB.TabIndex = 24;
            this.picBoxFB.TabStop = false;
            this.picBoxFB.Click += new System.EventHandler(this.picBoxFB_Click_1);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLinkdn);
            this.Controls.Add(this.pictureBoxTwitter);
            this.Controls.Add(this.pictureBoxInsta);
            this.Controls.Add(this.picBoxFB);
            this.Controls.Add(this.label1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(591, 429);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLinkdn;
        private System.Windows.Forms.PictureBox pictureBoxTwitter;
        private System.Windows.Forms.PictureBox pictureBoxInsta;
        private System.Windows.Forms.PictureBox picBoxFB;
    }
}
