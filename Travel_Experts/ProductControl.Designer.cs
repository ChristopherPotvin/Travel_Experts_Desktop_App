namespace Travel_Experts
{
    partial class ProductControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnProdClear = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblPnameTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbProdName = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPnameCb = new System.Windows.Forms.Label();
            this.lblNewSup = new System.Windows.Forms.Label();
            this.cbNewSup = new System.Windows.Forms.ComboBox();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-86, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product ID :";
            // 
            // btnProdClear
            // 
            this.btnProdClear.Location = new System.Drawing.Point(438, 318);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(75, 23);
            this.btnProdClear.TabIndex = 29;
            this.btnProdClear.Text = "Clear";
            this.btnProdClear.UseVisualStyleBackColor = true;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(144, 235);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(125, 20);
            this.txtProdName.TabIndex = 26;
            // 
            // lblPnameTxt
            // 
            this.lblPnameTxt.AutoSize = true;
            this.lblPnameTxt.Location = new System.Drawing.Point(51, 238);
            this.lblPnameTxt.Name = "lblPnameTxt";
            this.lblPnameTxt.Size = new System.Drawing.Size(81, 13);
            this.lblPnameTxt.TabIndex = 24;
            this.lblPnameTxt.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Information";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbUpdate);
            this.gbOptions.Controls.Add(this.rbDelete);
            this.gbOptions.Controls.Add(this.rbAdd);
            this.gbOptions.Location = new System.Drawing.Point(144, 103);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(212, 54);
            this.gbOptions.TabIndex = 33;
            this.gbOptions.TabStop = false;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(75, 19);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbUpdate.TabIndex = 2;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(150, 19);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(56, 17);
            this.rbDelete.TabIndex = 1;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(25, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(438, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbProdName
            // 
            this.cbProdName.FormattingEnabled = true;
            this.cbProdName.Location = new System.Drawing.Point(144, 185);
            this.cbProdName.Name = "cbProdName";
            this.cbProdName.Size = new System.Drawing.Size(121, 21);
            this.cbProdName.TabIndex = 35;
            this.cbProdName.SelectedIndexChanged += new System.EventHandler(this.cbProdName_SelectedIndexChanged);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(392, 185);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbSupplier.TabIndex = 36;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(295, 188);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(82, 13);
            this.lblSupName.TabIndex = 24;
            this.lblSupName.Text = "Supplier Name :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(178, 301);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "label7";
            // 
            // lblPnameCb
            // 
            this.lblPnameCb.AutoSize = true;
            this.lblPnameCb.Location = new System.Drawing.Point(51, 188);
            this.lblPnameCb.Name = "lblPnameCb";
            this.lblPnameCb.Size = new System.Drawing.Size(81, 13);
            this.lblPnameCb.TabIndex = 24;
            this.lblPnameCb.Text = "Product Name :";
            // 
            // lblNewSup
            // 
            this.lblNewSup.AutoSize = true;
            this.lblNewSup.Location = new System.Drawing.Point(295, 242);
            this.lblNewSup.Name = "lblNewSup";
            this.lblNewSup.Size = new System.Drawing.Size(82, 13);
            this.lblNewSup.TabIndex = 24;
            this.lblNewSup.Text = "Supplier Name :";
            // 
            // cbNewSup
            // 
            this.cbNewSup.FormattingEnabled = true;
            this.cbNewSup.Location = new System.Drawing.Point(392, 239);
            this.cbNewSup.Name = "cbNewSup";
            this.cbNewSup.Size = new System.Drawing.Size(121, 21);
            this.cbNewSup.TabIndex = 36;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbNewSup);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbProdName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblNewSup);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblPnameCb);
            this.Controls.Add(this.lblPnameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(623, 425);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblPnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbProdName;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPnameCb;
        private System.Windows.Forms.Label lblNewSup;
        private System.Windows.Forms.ComboBox cbNewSup;
    }
}
