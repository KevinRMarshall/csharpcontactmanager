namespace ContactManager
{
    partial class MainForm
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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grbTakeNote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtTakeNote = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.txtTypePhone = new System.Windows.Forms.TextBox();
            this.lblTypePhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.txtTypeEmail = new System.Windows.Forms.TextBox();
            this.lblTypeEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtTypeAddress = new System.Windows.Forms.TextBox();
            this.lblTypeAddress = new System.Windows.Forms.Label();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.pnlContactInfo.SuspendLayout();
            this.grbNotes.SuspendLayout();
            this.grbTakeNote.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(10, 24);
            this.lstContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(114, 392);
            this.lstContacts.Sorted = true;
            this.lstContacts.TabIndex = 1;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.LstContacts_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(10, 427);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(113, 24);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // pnlContactInfo
            // 
            this.pnlContactInfo.Controls.Add(this.grbNotes);
            this.pnlContactInfo.Controls.Add(this.grbTakeNote);
            this.pnlContactInfo.Controls.Add(this.grbPhone);
            this.pnlContactInfo.Controls.Add(this.grbEmail);
            this.pnlContactInfo.Controls.Add(this.grbAddress);
            this.pnlContactInfo.Controls.Add(this.btnEditContact);
            this.pnlContactInfo.Controls.Add(this.txtLastName);
            this.pnlContactInfo.Controls.Add(this.txtFirstName);
            this.pnlContactInfo.Controls.Add(this.lblLastName);
            this.pnlContactInfo.Controls.Add(this.lblFirstName);
            this.pnlContactInfo.Controls.Add(this.picContact);
            this.pnlContactInfo.Enabled = false;
            this.pnlContactInfo.Location = new System.Drawing.Point(128, 11);
            this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContactInfo.Name = "pnlContactInfo";
            this.pnlContactInfo.Size = new System.Drawing.Size(674, 444);
            this.pnlContactInfo.TabIndex = 2;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Location = new System.Drawing.Point(320, 141);
            this.grbNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbNotes.Size = new System.Drawing.Size(352, 299);
            this.grbNotes.TabIndex = 10;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(4, 17);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(344, 278);
            this.txtNotes.TabIndex = 0;
            // 
            // grbTakeNote
            // 
            this.grbTakeNote.Controls.Add(this.btnAddNote);
            this.grbTakeNote.Controls.Add(this.txtTakeNote);
            this.grbTakeNote.Location = new System.Drawing.Point(320, 3);
            this.grbTakeNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakeNote.Name = "grbTakeNote";
            this.grbTakeNote.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTakeNote.Size = new System.Drawing.Size(352, 133);
            this.grbTakeNote.TabIndex = 9;
            this.grbTakeNote.TabStop = false;
            this.grbTakeNote.Text = "Take a Note";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(267, 108);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(81, 20);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // txtTakeNote
            // 
            this.txtTakeNote.Location = new System.Drawing.Point(4, 17);
            this.txtTakeNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTakeNote.Multiline = true;
            this.txtTakeNote.Name = "txtTakeNote";
            this.txtTakeNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeNote.Size = new System.Drawing.Size(344, 87);
            this.txtTakeNote.TabIndex = 0;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.txtTypePhone);
            this.grbPhone.Controls.Add(this.lblTypePhone);
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Location = new System.Drawing.Point(3, 379);
            this.grbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPhone.Size = new System.Drawing.Size(312, 61);
            this.grbPhone.TabIndex = 8;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // txtTypePhone
            // 
            this.txtTypePhone.Location = new System.Drawing.Point(208, 27);
            this.txtTypePhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypePhone.Name = "txtTypePhone";
            this.txtTypePhone.ReadOnly = true;
            this.txtTypePhone.Size = new System.Drawing.Size(101, 20);
            this.txtTypePhone.TabIndex = 2;
            // 
            // lblTypePhone
            // 
            this.lblTypePhone.AutoSize = true;
            this.lblTypePhone.Location = new System.Drawing.Point(170, 29);
            this.lblTypePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypePhone.Name = "lblTypePhone";
            this.lblTypePhone.Size = new System.Drawing.Size(34, 13);
            this.lblTypePhone.TabIndex = 1;
            this.lblTypePhone.Text = "Type:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(14, 27);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(143, 20);
            this.txtPhone.TabIndex = 0;
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.txtTypeEmail);
            this.grbEmail.Controls.Add(this.lblTypeEmail);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Location = new System.Drawing.Point(3, 314);
            this.grbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmail.Size = new System.Drawing.Size(312, 61);
            this.grbEmail.TabIndex = 7;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // txtTypeEmail
            // 
            this.txtTypeEmail.Location = new System.Drawing.Point(208, 27);
            this.txtTypeEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeEmail.Name = "txtTypeEmail";
            this.txtTypeEmail.ReadOnly = true;
            this.txtTypeEmail.Size = new System.Drawing.Size(101, 20);
            this.txtTypeEmail.TabIndex = 2;
            // 
            // lblTypeEmail
            // 
            this.lblTypeEmail.AutoSize = true;
            this.lblTypeEmail.Location = new System.Drawing.Point(170, 29);
            this.lblTypeEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeEmail.Name = "lblTypeEmail";
            this.lblTypeEmail.Size = new System.Drawing.Size(34, 13);
            this.lblTypeEmail.TabIndex = 1;
            this.lblTypeEmail.Text = "Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 27);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.txtTypeAddress);
            this.grbAddress.Controls.Add(this.lblTypeAddress);
            this.grbAddress.Location = new System.Drawing.Point(3, 160);
            this.grbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAddress.Size = new System.Drawing.Size(312, 149);
            this.grbAddress.TabIndex = 6;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(255, 112);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(54, 20);
            this.txtZip.TabIndex = 9;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(190, 112);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(32, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(56, 112);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(76, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(226, 115);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zip:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(136, 115);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(14, 115);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(56, 70);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(252, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(14, 72);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // txtTypeAddress
            // 
            this.txtTypeAddress.Location = new System.Drawing.Point(56, 27);
            this.txtTypeAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeAddress.Name = "txtTypeAddress";
            this.txtTypeAddress.ReadOnly = true;
            this.txtTypeAddress.Size = new System.Drawing.Size(101, 20);
            this.txtTypeAddress.TabIndex = 1;
            // 
            // lblTypeAddress
            // 
            this.lblTypeAddress.AutoSize = true;
            this.lblTypeAddress.Location = new System.Drawing.Point(14, 29);
            this.lblTypeAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeAddress.Name = "lblTypeAddress";
            this.lblTypeAddress.Size = new System.Drawing.Size(34, 13);
            this.lblTypeAddress.TabIndex = 0;
            this.lblTypeAddress.Text = "Type:";
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(218, 116);
            this.btnEditContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(87, 20);
            this.btnEditContact.TabIndex = 5;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.BtnEditContact_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(193, 72);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(113, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(193, 39);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(113, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(128, 75);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(128, 41);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // picContact
            // 
            this.picContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picContact.Image = global::ContactManager.Properties.Resources.defaultUser;
            this.picContact.Location = new System.Drawing.Point(17, 20);
            this.picContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(98, 106);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 0;
            this.picContact.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 462);
            this.Controls.Add(this.pnlContactInfo);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.pnlContactInfo.ResumeLayout(false);
            this.pnlContactInfo.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            this.grbTakeNote.ResumeLayout(false);
            this.grbTakeNote.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Panel pnlContactInfo;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox grbTakeNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtTakeNote;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.TextBox txtTypePhone;
        private System.Windows.Forms.Label lblTypePhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtTypeEmail;
        private System.Windows.Forms.Label lblTypeEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtTypeAddress;
        private System.Windows.Forms.Label lblTypeAddress;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox picContact;
    }
}

