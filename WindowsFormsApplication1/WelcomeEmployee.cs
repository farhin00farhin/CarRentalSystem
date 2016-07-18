using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QualityVehicleCars;

namespace QualityVehicleForms
{
    public partial class WelcomeEmployee : Form
    {
        public WelcomeEmployee()
        {
            InitializeComponent();
            if (Start.carYard.loggedInEmployee.Role != Role.admin)
            {
                btnManageCustomers.Visible = false;
            }
          
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement stockManagementform = new StockManagement();
            stockManagementform.Closed += (s, args) => this.Show();
            stockManagementform.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAndCustomerManagement personManagemetform = new EmployeeAndCustomerManagement();
            personManagemetform.Closed += (s, args) => this.Show();
            personManagemetform.Show();
        }

        private void btnManageRentals_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalManagement rentalManagementform = new RentalManagement();
            rentalManagementform.Closed += (s, args) => this.Show();
            rentalManagementform.Show();
        }

        private void btnEditProfileEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAccount employeeAccountform = new EmployeeAccount();
            employeeAccountform.Closed += (s, args) => this.Show();
            employeeAccountform.Show();
            
        }

        private void WelcomeStaff_Load(object sender, EventArgs e)
        {
        }

        private void WelcomeStaff_Activated(object sender, EventArgs e)
        {
            lblHello.Text = "Hello " + Start.carYard.loggedInEmployee.Name;
            pbEmployee.ImageLocation = Start.carYard.loggedInEmployee.PicturePath;
        }

        private void WelcomeStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }
    }
}
