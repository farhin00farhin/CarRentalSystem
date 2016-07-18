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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
            cbRole.DataSource = Enum.GetValues(typeof(Role)); ///??

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Employee employee in Start.carYard.employees)
            {
                if (employee.Role == (Role)cbRole.SelectedItem && employee.Username == txtUsername.Text && employee.MatchPassword(txtPassword.Text) == true)
                {
                    Start.carYard.loggedInEmployee = employee;
                    this.Hide();
                   
                   
                    
                        WelcomeEmployee staffAccount = new WelcomeEmployee();
                        staffAccount.Closed += (s, args) => this.Show();
                        staffAccount.Show();
                    txtPassword.Clear();
                    txtUsername.Clear();
                  // cbRole.SelectedItem = Role.staff;
                    this.Hide();
                  
                    return;

                    

                }

            }

            MessageBox.Show("Sorry! Try again.");
        }

    }
}
