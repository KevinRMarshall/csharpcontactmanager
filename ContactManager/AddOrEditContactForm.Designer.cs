namespace ContactManager
{
    partial class AddOrEditContactForm
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
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.cboTypePhone = new System.Windows.Forms.ComboBox();
            this.lblTypePhone = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.cboTypeEmail = new System.Windows.Forms.ComboBox();
            this.lblTypeEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboTypeAddress = new System.Windows.Forms.ComboBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTypeAddress = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbPhone.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.mskPhone);
            this.grbPhone.Controls.Add(this.cboTypePhone);
            this.grbPhone.Controls.Add(this.lblTypePhone);
            this.grbPhone.Location = new System.Drawing.Point(9, 454);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(416, 75);
            this.grbPhone.TabIndex = 17;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(19, 33);
            this.mskPhone.Mask = "(000) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(189, 22);
            this.mskPhone.TabIndex = 3;
            // 
            // cboTypePhone
            // 
            this.cboTypePhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypePhone.FormattingEnabled = true;
            this.cboTypePhone.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboTypePhone.Location = new System.Drawing.Point(277, 33);
            this.cboTypePhone.Name = "cboTypePhone";
            this.cboTypePhone.Size = new System.Drawing.Size(133, 24);
            this.cboTypePhone.TabIndex = 2;
            // 
            // lblTypePhone
            // 
            this.lblTypePhone.AutoSize = true;
            this.lblTypePhone.Location = new System.Drawing.Point(227, 36);
            this.lblTypePhone.Name = "lblTypePhone";
            this.lblTypePhone.Size = new System.Drawing.Size(44, 17);
            this.lblTypePhone.TabIndex = 1;
            this.lblTypePhone.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.cboTypeEmail);
            this.grbEmail.Controls.Add(this.lblTypeEmail);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Location = new System.Drawing.Point(9, 373);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(416, 75);
            this.grbEmail.TabIndex = 16;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // cboTypeEmail
            // 
            this.cboTypeEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeEmail.FormattingEnabled = true;
            this.cboTypeEmail.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cboTypeEmail.Location = new System.Drawing.Point(277, 33);
            this.cboTypeEmail.Name = "cboTypeEmail";
            this.cboTypeEmail.Size = new System.Drawing.Size(133, 24);
            this.cboTypeEmail.TabIndex = 3;
            // 
            // lblTypeEmail
            // 
            this.lblTypeEmail.AutoSize = true;
            this.lblTypeEmail.Location = new System.Drawing.Point(227, 36);
            this.lblTypeEmail.Name = "lblTypeEmail";
            this.lblTypeEmail.Size = new System.Drawing.Size(44, 17);
            this.lblTypeEmail.TabIndex = 1;
            this.lblTypeEmail.Text = "Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 33);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.cboProvince);
            this.grbAddress.Controls.Add(this.cboTypeAddress);
            this.grbAddress.Controls.Add(this.mskZip);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblTypeAddress);
            this.grbAddress.Location = new System.Drawing.Point(9, 184);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(416, 183);
            this.grbAddress.TabIndex = 15;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // cboProvince
            // 
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cboProvince.Location = new System.Drawing.Point(245, 138);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(56, 24);
            this.cboProvince.TabIndex = 12;
            // 
            // cboTypeAddress
            // 
            this.cboTypeAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeAddress.FormattingEnabled = true;
            this.cboTypeAddress.Items.AddRange(new object[] {
            "Business",
            "Home"});
            this.cboTypeAddress.Location = new System.Drawing.Point(72, 33);
            this.cboTypeAddress.Name = "cboTypeAddress";
            this.cboTypeAddress.Size = new System.Drawing.Size(133, 24);
            this.cboTypeAddress.TabIndex = 11;
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(345, 138);
            this.mskZip.Mask = "L0L 0L0";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(62, 22);
            this.mskZip.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(72, 138);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(307, 141);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 17);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(181, 141);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(67, 17);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 141);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(72, 86);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(335, 22);
            this.txtStreet.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(16, 89);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 17);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // lblTypeAddress
            // 
            this.lblTypeAddress.AutoSize = true;
            this.lblTypeAddress.Location = new System.Drawing.Point(16, 36);
            this.lblTypeAddress.Name = "lblTypeAddress";
            this.lblTypeAddress.Size = new System.Drawing.Size(44, 17);
            this.lblTypeAddress.TabIndex = 0;
            this.lblTypeAddress.Text = "Type:";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(179, 114);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(101, 28);
            this.btnAddPhoto.TabIndex = 14;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.BtnAddPhoto_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(262, 76);
            this.txtLastName.MaxLength = 18;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 22);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(262, 35);
            this.txtFirstName.MaxLength = 18;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(176, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(176, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name:";
            // 
            // picContact
            // 
            this.picContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picContact.Image = global::ContactManager.Properties.Resources.defaultUser;
            this.picContact.Location = new System.Drawing.Point(28, 12);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(130, 130);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 9;
            this.picContact.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddOrEditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 582);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddContactForm";
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblTypePhone;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.Label lblTypeEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTypeAddress;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.ComboBox cboTypePhone;
        private System.Windows.Forms.ComboBox cboTypeEmail;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboTypeAddress;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.Button btnSave;
    }
}