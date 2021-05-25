using System;
using System.IO;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class MainForm : Form
    {
        string path = @"contacts.txt";


        public MainForm()
        {
            InitializeComponent();
            AttemptLoad();
        }


        private void AttemptLoad()
        {
            if (File.Exists(path))
            {
                foreach (string contactData in File.ReadLines(path))
                {
                    Contact loadContact = new Contact();
                    loadContact.LoadDataFromString(contactData);
                    lstContacts.Items.Add(loadContact);
                }
            }
        }


        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            using (AddOrEditContactForm addContactForm = new AddOrEditContactForm(new Contact()))
            {
                addContactForm.ShowDialog(this);
                if (addContactForm.DialogResult == DialogResult.OK)
                {
                    lstContacts.Items.Add(addContactForm.MyContact);
                    lstContacts.SelectedIndex = lstContacts.Items.Count - 1;
                    SaveContactChanges();
                }
            }
        }


        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                Contact contact = (Contact)lstContacts.SelectedItem;
                contact.AddNote(txtTakeNote.Text);
                UpdateNotesDisplay(contact);
                txtTakeNote.Clear();
                txtTakeNote.Focus();
            }
        }


        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            using (AddOrEditContactForm addContactForm = new AddOrEditContactForm((Contact)lstContacts.SelectedItem))
            {
                addContactForm.ShowDialog(this);
                if (addContactForm.DialogResult == DialogResult.OK)
                {
                    SaveContactChanges();
                }
            }
        }


        private void LstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                pnlContactInfo.Enabled = true;
                UpdateContactInfoDisplay();
            }
            else
            {
                pnlContactInfo.Enabled = false;
            }
        }


        private void SaveContactChanges()
        {
            UpdateContactInfoDisplay();

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Contact eachContact in lstContacts.Items)
                {
                    writer.WriteLine(eachContact.ToSaveString());
                }
            }
        }


        private void UpdateContactInfoDisplay()
        {
            Contact contact = (Contact)lstContacts.SelectedItem;

            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtTypeAddress.Text = contact.AddressType;
            txtStreet.Text = contact.Street;
            txtCity.Text = contact.City;
            txtProvince.Text = contact.Province;
            txtZip.Text = contact.Zip;
            txtEmail.Text = contact.Email;
            txtTypeEmail.Text = contact.EmailType;
            txtPhone.Text = contact.Phone;
            txtTypePhone.Text = contact.PhoneType;
            if (string.IsNullOrWhiteSpace(contact.PhotoPath))
            {
                picContact.Image = Properties.Resources.defaultUser;
            }
            else
            {
                picContact.ImageLocation = contact.PhotoPath;
            }

            UpdateNotesDisplay(contact);
        }


        private void UpdateNotesDisplay(Contact contact)
        {
            txtNotes.Text = contact.NotesChronological();
        }
    }
}