namespace Travel_Experts
{
    partial class SuppliersControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.lblSupNameDD = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers Administration";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbDelete);
            this.gbOptions.Controls.Add(this.rbAdd);
            this.gbOptions.Controls.Add(this.rbUpdate);
            this.gbOptions.Location = new System.Drawing.Point(160, 90);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(283, 59);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(207, 19);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(56, 17);
            this.rbDelete.TabIndex = 2;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(32, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 2;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(115, 19);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbUpdate.TabIndex = 2;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(415, 251);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSupName
            // 
            this.cbSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(160, 178);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(210, 21);
            this.cbSupName.TabIndex = 14;
            this.cbSupName.SelectedIndexChanged += new System.EventHandler(this.supNameComboBox_SelectedIndexChanged);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(Model.Suppliers);
            // 
            // txtSupName
            // 
            this.txtSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.txtSupName.Location = new System.Drawing.Point(160, 222);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(210, 20);
            this.txtSupName.TabIndex = 17;
            // 
            // txtSupId
            // 
            this.txtSupId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierId", true));
            this.txtSupId.Location = new System.Drawing.Point(160, 258);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(210, 20);
            this.txtSupId.TabIndex = 18;
            // 
            // lblSupNameDD
            // 
            this.lblSupNameDD.AutoSize = true;
            this.lblSupNameDD.Location = new System.Drawing.Point(75, 186);
            this.lblSupNameDD.Name = "lblSupNameDD";
            this.lblSupNameDD.Size = new System.Drawing.Size(79, 13);
            this.lblSupNameDD.TabIndex = 19;
            this.lblSupNameDD.Text = "Supplier Name:";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(75, 225);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(79, 13);
            this.lblSupName.TabIndex = 19;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // lblSupId
            // 
            this.lblSupId.AutoSize = true;
            this.lblSupId.Location = new System.Drawing.Point(92, 261);
            this.lblSupId.Name = "lblSupId";
            this.lblSupId.Size = new System.Drawing.Size(62, 13);
            this.lblSupId.TabIndex = 20;
            this.lblSupId.Text = "Supplier ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(168, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "label2";
            // 
            // SuppliersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSupId);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblSupNameDD);
            this.Controls.Add(this.txtSupId);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.cbSupName);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.label1);
            this.Name = "SuppliersControl";
            this.Size = new System.Drawing.Size(620, 348);
            this.Load += new System.EventHandler(this.SuppliersControl_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.Label lblSupId;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupNameDD;
        private System.Windows.Forms.Label lblStatus;
    }
}
