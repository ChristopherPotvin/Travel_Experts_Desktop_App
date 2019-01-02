namespace Travel_Experts
{
    partial class PackagesControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radUpdate = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Administration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDelete);
            this.groupBox1.Controls.Add(this.radUpdate);
            this.groupBox1.Controls.Add(this.radAdd);
            this.groupBox1.Location = new System.Drawing.Point(159, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packages";
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(180, 18);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(56, 17);
            this.radDelete.TabIndex = 2;
            this.radDelete.TabStop = true;
            this.radDelete.Text = "Delete";
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radUpdate
            // 
            this.radUpdate.AutoSize = true;
            this.radUpdate.Location = new System.Drawing.Point(103, 18);
            this.radUpdate.Name = "radUpdate";
            this.radUpdate.Size = new System.Drawing.Size(60, 17);
            this.radUpdate.TabIndex = 1;
            this.radUpdate.TabStop = true;
            this.radUpdate.Text = "Update";
            this.radUpdate.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(33, 18);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(44, 17);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(292, 163);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(68, 13);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.Text = "Commission :";
            // 
            // txtCommission
            // 
            this.txtCommission.Enabled = false;
            this.txtCommission.Location = new System.Drawing.Point(366, 160);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(148, 20);
            this.txtCommission.TabIndex = 4;
            this.txtCommission.TextChanged += new System.EventHandler(this.txtCommission_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(24, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(66, 160);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(339, 131);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(366, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 20);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(81, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search for Package";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.dateStart.Enabled = false;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(66, 190);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(135, 20);
            this.dateStart.TabIndex = 11;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 193);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(3, 225);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(66, 222);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(247, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 16;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Enabled = false;
            this.richTxtDescription.Location = new System.Drawing.Point(212, 199);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(354, 118);
            this.richTxtDescription.TabIndex = 17;
            this.richTxtDescription.Text = "";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(211, 185);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(106, 13);
            this.lblPackage.TabIndex = 18;
            this.lblPackage.Text = "Package Description";
            // 
            // PackagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PackagesControl";
            this.Size = new System.Drawing.Size(569, 399);
            this.Load += new System.EventHandler(this.PackagesControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radUpdate;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Label lblPackage;
    }
}
