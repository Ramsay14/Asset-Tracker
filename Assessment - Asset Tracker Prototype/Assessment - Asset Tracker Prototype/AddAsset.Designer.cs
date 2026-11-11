namespace Assessment___Asset_Tracker_Prototype
{
    partial class AddAsset
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
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblHardwareType = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtHardwareType = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(268, 207);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(159, 21);
            this.cmbEmployee.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(344, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Asset";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(40, 64);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(72, 13);
            this.lblSystemName.TabIndex = 2;
            this.lblSystemName.Text = "System Name";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(40, 130);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 3;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(40, 191);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // lblHardwareType
            // 
            this.lblHardwareType.AutoSize = true;
            this.lblHardwareType.Location = new System.Drawing.Point(40, 253);
            this.lblHardwareType.Name = "lblHardwareType";
            this.lblHardwareType.Size = new System.Drawing.Size(80, 13);
            this.lblHardwareType.TabIndex = 5;
            this.lblHardwareType.Text = "Hardware Type";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(40, 316);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddress.TabIndex = 6;
            this.lblIPAddress.Text = "IP Address";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(40, 386);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(159, 13);
            this.lblPurchaseDate.TabIndex = 7;
            this.lblPurchaseDate.Text = "Purchase Date (DD/MM/YYYY)";
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(269, 64);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(84, 13);
            this.lblAdditionalNotes.TabIndex = 8;
            this.lblAdditionalNotes.Text = "Additional Notes";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(269, 191);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(89, 13);
            this.lblEmployee.TabIndex = 9;
            this.lblEmployee.Text = "Select Employee:";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(40, 80);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.ReadOnly = true;
            this.txtSystemName.Size = new System.Drawing.Size(159, 20);
            this.txtSystemName.TabIndex = 10;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(40, 146);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(159, 20);
            this.txtManufacturer.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(40, 207);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(159, 20);
            this.txtModel.TabIndex = 12;
            // 
            // txtHardwareType
            // 
            this.txtHardwareType.Location = new System.Drawing.Point(40, 271);
            this.txtHardwareType.Name = "txtHardwareType";
            this.txtHardwareType.ReadOnly = true;
            this.txtHardwareType.Size = new System.Drawing.Size(159, 20);
            this.txtHardwareType.TabIndex = 13;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(40, 332);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = true;
            this.txtIPAddress.Size = new System.Drawing.Size(159, 20);
            this.txtIPAddress.TabIndex = 14;
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Location = new System.Drawing.Point(40, 402);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(159, 20);
            this.txtPurchaseDate.TabIndex = 15;
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(268, 80);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(159, 86);
            this.txtAdditionalNotes.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Asset";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtHardwareType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSystemName);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblHardwareType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbEmployee);
            this.Name = "AddAsset";
            this.Text = "Add Asset";
            this.Load += new System.EventHandler(this.AddAsset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblHardwareType;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtHardwareType;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPurchaseDate;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

