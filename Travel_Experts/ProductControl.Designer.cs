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
            this.btnProdSearch = new System.Windows.Forms.Button();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.btnProdClear.Location = new System.Drawing.Point(427, 319);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(75, 23);
            this.btnProdClear.TabIndex = 29;
            this.btnProdClear.Text = "Clear";
            this.btnProdClear.UseVisualStyleBackColor = true;
            // 
            // btnProdSearch
            // 
            this.btnProdSearch.Location = new System.Drawing.Point(299, 263);
            this.btnProdSearch.Name = "btnProdSearch";
            this.btnProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProdSearch.TabIndex = 28;
            this.btnProdSearch.Text = "Search";
            this.btnProdSearch.UseVisualStyleBackColor = true;
            this.btnProdSearch.Click += new System.EventHandler(this.btnProdSearch_Click_1);
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(216, 185);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(125, 20);
            this.txtProdID.TabIndex = 27;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(216, 229);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(125, 20);
            this.txtProdName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Name :";
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
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.ForeColor = System.Drawing.Color.Red;
            this.lblProdId.Location = new System.Drawing.Point(347, 188);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(155, 13);
            this.lblProdId.TabIndex = 31;
            this.lblProdId.Text = "Enter a valid product Id number";
            this.lblProdId.Visible = false;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.ForeColor = System.Drawing.Color.Red;
            this.lblProdName.Location = new System.Drawing.Point(347, 232);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(134, 13);
            this.lblProdName.TabIndex = 32;
            this.lblProdName.Text = "Enter a valid product name";
            this.lblProdName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUpdate);
            this.groupBox1.Controls.Add(this.rdbDelete);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Location = new System.Drawing.Point(162, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 54);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(146, 19);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rdbUpdate.TabIndex = 2;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(84, 19);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(56, 17);
            this.rdbDelete.TabIndex = 1;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(25, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(44, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(392, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdId);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.btnProdSearch);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(546, 385);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.Button btnProdSearch;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Button btnSubmit;
    }
}
