using QualityVehicleCars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityVehicleForms
{
    public partial class EmployeeAccount : Form
    {
        public EmployeeAccount()
        {
            InitializeComponent();
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            txtID.Enabled = false;
            cbRole.Enabled = false;
            txtName.Text= Start.carYard.loggedInEmployee.Name ;
            txtOfficeAddress.Text= Start.carYard.loggedInEmployee.OfficeAddress ;
             txtPhoneExtensionNo.Text=Start.carYard.loggedInEmployee.PhoneExtensionNumber.ToString();
            txtTelephone.Text=Start.carYard.loggedInEmployee.TelephoneNo.ToString() ;
            txtID.Text = Start.carYard.loggedInEmployee.Id.ToString();
            txtUsername.Text=Start.carYard.loggedInEmployee.Username;
            txtAddress.Text =Start.carYard.loggedInEmployee.Address;
             dtpDateOfBirth.Value=Start.carYard.loggedInEmployee.DateOfBirth;
             cbRole.SelectedItem=(Role)Start.carYard.loggedInEmployee.Role;
            pbUploadEmployee.ImageLocation = Start.carYard.loggedInEmployee.PicturePath;

        }

        private void btnUploadEmployeePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            DialogResult selectedPhoto = photo.ShowDialog();
            pbUploadEmployee.ImageLocation = photo.FileName;
        }

        private void btnSaveEmployeePersonalInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Start.carYard.loggedInEmployee.Name = txtName.Text;
                Start.carYard.loggedInEmployee.OfficeAddress = txtOfficeAddress.Text;
                Start.carYard.loggedInEmployee.Password = txtPassword.Text;
                Start.carYard.loggedInEmployee.PhoneExtensionNumber = int.Parse(txtPhoneExtensionNo.Text);
                Start.carYard.loggedInEmployee.TelephoneNo = int.Parse(txtTelephone.Text);
                Start.carYard.loggedInEmployee.Username = txtUsername.Text;
                Start.carYard.loggedInEmployee.Address = txtAddress.Text;
                Start.carYard.loggedInEmployee.DateOfBirth = dtpDateOfBirth.Value;
                Start.carYard.loggedInEmployee.PicturePath = pbUploadEmployee.ImageLocation;

            }
           

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (OverflowException)
            {
                MessageBox.Show("A value that you entered was too large for the field. Please enter a smaller value.");

            }
            catch (FormatException)
            {
                MessageBox.Show("You can't leave the textboxes empty or enter characters in number fields. Please enter a valid value.");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error saving the data. Please ensure you've entered valid values in all the fields.");

            }

            this.Close();
        }
    }
}
