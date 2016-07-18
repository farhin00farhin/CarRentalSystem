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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails(Customer selectedCustomer)
        {
            InitializeComponent();
            lblPersonCustomerAddress.Text = selectedCustomer.Address;
            lblPersonCustomerDateOfBirth.Text = selectedCustomer.DateOfBirth.ToShortDateString();
            lblPersonCustomerLicenceExpiryDate.Text = selectedCustomer.LicenseExpiryDate.ToShortDateString();
            lblPersonCustomerName.Text = selectedCustomer.Name;
            lblPersonCustomerId.Text = selectedCustomer.Id.ToString();
            lblPersonCustomerAge.Text = selectedCustomer.Age.ToString();
            lblPersonCustomerLicenceNumber.Text = selectedCustomer.LicenseNumber;
            lblPersonCustomerTelephone.Text = selectedCustomer.TelephoneNo.ToString();
        }
    }
}
