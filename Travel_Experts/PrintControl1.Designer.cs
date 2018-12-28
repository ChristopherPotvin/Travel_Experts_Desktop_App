namespace Travel_Experts
{
    partial class PrintControl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPackages = new System.Windows.Forms.RadioButton();
            this.btnProducts = new System.Windows.Forms.RadioButton();
            this.btnSuppliers = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuppliers);
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Controls.Add(this.btnPackages);
            this.groupBox1.Location = new System.Drawing.Point(109, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Form";
            // 
            // btnPackages
            // 
            this.btnPackages.AutoSize = true;
            this.btnPackages.Location = new System.Drawing.Point(28, 39);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(73, 17);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.TabStop = true;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = true;
            this.btnProducts.Location = new System.Drawing.Point(119, 39);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(67, 17);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.TabStop = true;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.Location = new System.Drawing.Point(210, 39);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(68, 17);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.TabStop = true;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // PrintControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintControl1";
            this.Size = new System.Drawing.Size(553, 376);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnSuppliers;
        private System.Windows.Forms.RadioButton btnProducts;
        private System.Windows.Forms.RadioButton btnPackages;
    }
}
