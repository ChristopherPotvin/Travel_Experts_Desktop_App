namespace Travel_Experts
{
    partial class AdministratorControl
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
            this.btnAdminSup = new System.Windows.Forms.Button();
            this.btnAdminPdct = new System.Windows.Forms.Button();
            this.btnAdminPkg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminSup
            // 
            this.btnAdminSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSup.Location = new System.Drawing.Point(401, 3);
            this.btnAdminSup.Name = "btnAdminSup";
            this.btnAdminSup.Size = new System.Drawing.Size(146, 37);
            this.btnAdminSup.TabIndex = 5;
            this.btnAdminSup.Text = "Supplier";
            this.btnAdminSup.UseVisualStyleBackColor = true;
            // 
            // btnAdminPdct
            // 
            this.btnAdminPdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPdct.Location = new System.Drawing.Point(232, 3);
            this.btnAdminPdct.Name = "btnAdminPdct";
            this.btnAdminPdct.Size = new System.Drawing.Size(146, 37);
            this.btnAdminPdct.TabIndex = 4;
            this.btnAdminPdct.Text = "Product";
            this.btnAdminPdct.UseVisualStyleBackColor = true;
            // 
            // btnAdminPkg
            // 
            this.btnAdminPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPkg.Location = new System.Drawing.Point(63, 3);
            this.btnAdminPkg.Name = "btnAdminPkg";
            this.btnAdminPkg.Size = new System.Drawing.Size(146, 37);
            this.btnAdminPkg.TabIndex = 3;
            this.btnAdminPkg.Text = "Package";
            this.btnAdminPkg.UseVisualStyleBackColor = true;
            // 
            // AdministratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdminSup);
            this.Controls.Add(this.btnAdminPdct);
            this.Controls.Add(this.btnAdminPkg);
            this.Name = "AdministratorControl";
            this.Size = new System.Drawing.Size(601, 395);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminSup;
        private System.Windows.Forms.Button btnAdminPdct;
        private System.Windows.Forms.Button btnAdminPkg;
    }
}
