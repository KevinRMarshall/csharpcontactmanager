using System;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class AddOrEditContactForm : Form
    {
        public Contact MyContact { get; private set; }


        public AddOrEditContactForm(Contact contact)
        {
            InitializeComponent();
            MyContact = contact;
            UpdateForm();
        }


        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = @"c:\";
                openFile.Filter = @"Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    MyContact.PhotoPath = openFile.FileName;
                    picContact.ImageLocation = openFile.FileName;
                }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please ensure that both the First and Last names are filled.", "Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MyContact.FirstName = txtFirstName.Text;
                MyContact.LastName = txtLastName.Text;
                MyContact.AddressType = (string)cboTypeAddress.SelectedItem;
                MyContact.Street = txtStreet.Text;
                MyContact.City = txtCity.Text;
                MyContact.Province = (string)cboProvince.SelectedItem;
                MyContact.Zip = mskZip.Text.ToUpper();
                MyContact.Email = txtEmail.Text;
                MyContact.EmailType = (string)cboTypeEmail.SelectedItem;
                MyContact.Phone = mskPhone.Text;
                MyContact.PhoneType = (string)cboTypePhone.SelectedItem;

                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void UpdateForm()
        {
            txtFirstName.Text = MyContact.FirstName;
            txtLastName.Text = MyContact.LastName;
            cboTypeAddress.SelectedItem = MyContact.AddressType;
            txtStreet.Text = MyContact.Street;
            txtCity.Text = MyContact.City;
            cboProvince.SelectedItem = MyContact.Province;
            mskZip.Text = MyContact.Zip;
            txtEmail.Text = MyContact.Email;
            cboTypeEmail.SelectedItem = MyContact.EmailType;
            mskPhone.Text = MyContact.Phone;
            cboTypePhone.SelectedItem = MyContact.PhoneType;
            if (string.IsNullOrWhiteSpace(MyContact.PhotoPath))
            {
                picContact.Image = Properties.Resources.defaultUser;
            }
            else
            {
                picContact.ImageLocation = MyContact.PhotoPath;
            }
        }
    }
}