namespace Travel_Experts
{
    partial class AdminControlSup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControlSup));
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pctExcel = new System.Windows.Forms.PictureBox();
            this.pctSave = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(397, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Supplier Information";
            // 
            // pctExcel
            // 
            this.pctExcel.Image = ((System.Drawing.Image)(resources.GetObject("pctExcel.Image")));
            this.pctExcel.Location = new System.Drawing.Point(485, 128);
            this.pctExcel.Name = "pctExcel";
            this.pctExcel.Size = new System.Drawing.Size(30, 21);
            this.pctExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcel.TabIndex = 87;
            this.pctExcel.TabStop = false;
            // 
            // pctSave
            // 
            this.pctSave.Image = ((System.Drawing.Image)(resources.GetObject("pctSave.Image")));
            this.pctSave.Location = new System.Drawing.Point(521, 128);
            this.pctSave.Name = "pctSave";
            this.pctSave.Size = new System.Drawing.Size(30, 21);
            this.pctSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSave.TabIndex = 86;
            this.pctSave.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(384, 327);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.ForeColor = System.Drawing.Color.Red;
            this.lblCurrency.Location = new System.Drawing.Point(424, 56);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(129, 13);
            this.lblCurrency.TabIndex = 84;
            this.lblCurrency.Text = "Please enter valid number";
            this.lblCurrency.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(48, 155);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(503, 150);
            this.productGridView.TabIndex = 82;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(433, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 13);
            this.lblName.TabIndex = 81;
            this.lblName.Text = "Please enter valid name";
            this.lblName.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(412, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(141, 13);
            this.lblId.TabIndex = 80;
            this.lblId.Text = "Please enter valid Id number";
            this.lblId.Visible = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(418, 56);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(135, 13);
            this.lblEmpty.TabIndex = 79;
            this.lblEmpty.Text = "Please enter a name/value";
            this.lblEmpty.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(294, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 77;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Search by:";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "All",
            "Id",
            "Name",
            "Start Date",
            "End Date",
            "Base Price",
            "Commission"});
            this.cboSearch.Location = new System.Drawing.Point(111, 32);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 75;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(341, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 74;
            // 
            // AdminControlSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctExcel);
            this.Controls.Add(this.pctSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "AdminControlSup";
            this.Size = new System.Drawing.Size(601, 395);
            ((System.ComponentModel.ISupportInitialize)(this.pctExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctExcel;
        private System.Windows.Forms.PictureBox pctSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
