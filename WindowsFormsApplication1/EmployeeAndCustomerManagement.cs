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
    public partial class EmployeeAndCustomerManagement : Form
    {
        public EmployeeAndCustomerManagement()
        {
            InitializeComponent();
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            EmployeeRefresh();
            txtSearchBoxEmployee.Visible = false;
            dtmBirth.Visible = false;
            pnlDefaultEmployee.Show();
            pnlAddEmployee.Hide();
            CustomerRefresh();
            txtSearchBoxCustomer.Visible = false;
            dtpBirthSearchCustomer.Visible = false;
            pnlDefaultCustomer.Show();
            pnlAddCustomer.Hide();
            PersonRefresh();
            dtpBirthSearchPerson.Visible = false;
            txtSearchBoxPerson.Visible = false;
            pnlPersonDefault.Show();
            tvEmployee_AfterSelect(null, null);

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Enabled = true;
            pnlDefaultEmployee.Hide();
            pnlAddEmployee.Show();
            txtID.Clear();
            txtTelephone.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtOfficeAddress.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtPhoneExtensionNo.Clear();
            dtpBirth.Value = DateTime.Now;
            pbEmployee.ImageLocation = "";
            cbRole.SelectedItem = Role.admin;

            txtID.Enabled = true;
            txtTelephone.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cbRole.Enabled = true;
            tvEmployee.SelectedNode = null;


        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            pnlDefaultCustomer.Hide();
            pnlAddCustomer.Show();
            txtIdCustomer.Clear();
            txtTelephoneCustomer.Clear();
            txtNameCustomer.Clear();
            txtAddressCustomer.Clear();
            dtpBirth.Value = DateTime.Now;
            txtLicenseNumberCustomer.Clear();
            dtpDateOfBirthCustomer.Value = DateTime.Now;
            txtAgeCustomer.Clear();

            txtIdCustomer.Enabled = true;
            txtTelephoneCustomer.Enabled = true;
            txtNameCustomer.Enabled = true;
            txtAddressCustomer.Enabled = true;
            txtLicenseNumberCustomer.Enabled = true;            
            txtAgeCustomer.Clear();

            tvCustomer.SelectedNode = null;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvEmployee.SelectedNode == null)
                {
                    Employee employee1 = new Employee(txtOfficeAddress.Text, txtPassword.Text, int.Parse(txtPhoneExtensionNo.Text), (Role)cbRole.SelectedItem, txtUsername.Text, txtAddress.Text, dtpBirth.Value, int.Parse(txtID.Text), txtName.Text, long.Parse(txtTelephone.Text));
                    employee1.PicturePath = pbEmployee.ImageLocation;
                    Start.carYard.employees.Add(employee1);
                    EmployeeRefresh();
                    pnlDefaultEmployee.Show();
                    pnlAddEmployee.Hide();
                    tvEmployee.SelectedNode = null;
                    tvEmployee_AfterSelect(null, null);


                }
                else if (tvEmployee.SelectedNode.Tag is Employee)
                {
                    Employee selectedEmployee = (Employee)tvEmployee.SelectedNode.Tag;
                    selectedEmployee.Name = txtName.Text;
                    selectedEmployee.OfficeAddress = txtOfficeAddress.Text;
                    selectedEmployee.Password = txtPassword.Text;
                    selectedEmployee.PhoneExtensionNumber = int.Parse(txtPhoneExtensionNo.Text);
                    selectedEmployee.TelephoneNo = int.Parse(txtTelephone.Text);
                    selectedEmployee.Username = txtUsername.Text;
                    selectedEmployee.Address = txtAddress.Text;
                    selectedEmployee.DateOfBirth = dtpBirth.Value;
                    selectedEmployee.PicturePath = pbEmployee.ImageLocation;
                    pnlAddEmployee.Hide();
                    pnlDefaultEmployee.Show();
                    EmployeeRefresh();
                    tvEmployee.SelectedNode = null;
                    tvEmployee_AfterSelect(null, null);
                }

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

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try { 
            if (tvCustomer.SelectedNode == null)
            {
                Customer customer1 = new Customer(dtpLicenceExpiryDateCustomer.Value, txtLicenseNumberCustomer.Text, txtAddressCustomer.Text, dtpDateOfBirthCustomer.Value, int.Parse(txtIdCustomer.Text), txtNameCustomer.Text, long.Parse(txtTelephoneCustomer.Text));
                Start.carYard.customers.Add(customer1);
                CustomerRefresh();
                pnlAddCustomer.Hide();
                pnlDefaultCustomer.Show();

            }
            else if (tvCustomer.SelectedNode.Tag is Customer)
            {
                Customer selectedCustomer = (Customer)tvCustomer.SelectedNode.Tag;
                ((Customer)tvCustomer.SelectedNode.Tag).Address = txtAddressCustomer.Text;
                ((Customer)tvCustomer.SelectedNode.Tag).Name = txtNameCustomer.Text;
                ((Customer)tvCustomer.SelectedNode.Tag).TelephoneNo = long.Parse(txtTelephoneCustomer.Text);
                ((Customer)tvCustomer.SelectedNode.Tag).DateOfBirth = dtpDateOfBirthCustomer.Value;
                ((Customer)tvCustomer.SelectedNode.Tag).LicenseExpiryDate = dtpLicenceExpiryDateCustomer.Value;
                ((Customer)tvCustomer.SelectedNode.Tag).LicenseNumber = txtLicenseNumberCustomer.Text;

                pnlAddCustomer.Hide();
                pnlDefaultCustomer.Show();
                CustomerRefresh();
            }
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
        }
        private void EmployeeRefresh()
        {
            tvEmployee.Nodes.Clear();
            if (Start.carYard.employees == null)
            {
                return;
            }
            foreach (Employee employee in Start.carYard.employees)
            {
                TreeNode node1 = new TreeNode(employee.Name);
                tvEmployee.Nodes.Add(node1);
                node1.Tag = employee;
            }

        }

        private void CustomerRefresh()
        {
            tvCustomer.Nodes.Clear();
            if (Start.carYard.customers == null)
            {
                Start.carYard.customers = new HashSet<Customer>();
            }
            foreach (Customer customer in Start.carYard.customers)
            {
                TreeNode node1 = new TreeNode(customer.Name);
                tvCustomer.Nodes.Add(node1);
                node1.Tag = customer;
            }

        }

        private void PersonRefresh()
        {
            tvPerson.Nodes.Clear();
            

        }

        private void btnRemoveEmployees_Click(object sender, EventArgs e)
        {
            if ((Employee)tvEmployee.SelectedNode.Tag == Start.carYard.loggedInEmployee)
            {
                MessageBox.Show("You can't delete the logged in user.");
                return;
            }
            Start.carYard.employees.Remove((Employee)tvEmployee.SelectedNode.Tag);
            EmployeeRefresh();
            pnlAddEmployee.Hide();
            pnlDefaultEmployee.Show();
            tvEmployee.SelectedNode = null;
            tvEmployee_AfterSelect(null, null);

        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
    
            Start.carYard.customers.Remove((Customer)tvCustomer.SelectedNode.Tag);
            CustomerRefresh();
            pnlAddCustomer.Hide();
            pnlDefaultCustomer.Show();
            tvCustomer.SelectedNode = null;


        }

        private void ViewEmployeeDetails()
        {

            Employee selectedEmployee = (Employee)tvEmployee.SelectedNode.Tag;

            pnlAddEmployee.Show();
            pnlDefaultEmployee.Hide();

            txtID.Enabled = false;
            cbRole.Enabled = false;
            txtPassword.Text = "";
            txtAddress.Text = selectedEmployee.Address;
            cbRole.SelectedItem = selectedEmployee.Role;
            dtpBirth.Value = selectedEmployee.DateOfBirth;
            txtName.Text = selectedEmployee.Name;
            txtID.Text = selectedEmployee.Id.ToString();
            txtOfficeAddress.Text = selectedEmployee.OfficeAddress;
            txtUsername.Text = selectedEmployee.Username;
            txtTelephone.Text = selectedEmployee.TelephoneNo.ToString();
            txtPhoneExtensionNo.Text = selectedEmployee.PhoneExtensionNumber.ToString();

            pbEmployee.ImageLocation = selectedEmployee.PicturePath;

        }

        private void ViewCustomerDetails()
        {

            Customer selectedCustomer = (Customer)tvCustomer.SelectedNode.Tag;

            pnlAddCustomer.Show();
            pnlDefaultCustomer.Hide();

            txtIdCustomer.Enabled = false;
            txtAgeCustomer.Enabled = false;

            txtAddressCustomer.Text = selectedCustomer.Address;
            dtpDateOfBirthCustomer.Value = selectedCustomer.DateOfBirth;
            dtpLicenceExpiryDateCustomer.Value = selectedCustomer.LicenseExpiryDate;
            txtNameCustomer.Text = selectedCustomer.Name;
            txtIdCustomer.Text = selectedCustomer.Id.ToString();
            txtAgeCustomer.Text = selectedCustomer.Age.ToString();
            txtLicenseNumberCustomer.Text = selectedCustomer.LicenseNumber;
            txtTelephoneCustomer.Text = selectedCustomer.TelephoneNo.ToString();
        }

        private void ViewPersonDetails()
        {
            pnlPersonDefault.Hide();

            if (tvPerson.SelectedNode.Tag is Customer)
            {
                Customer selectedCustomer = (Customer)tvPerson.SelectedNode.Tag;

                lblPersonCustomerAddress.Text = selectedCustomer.Address;
               lblPersonCustomerDateOfBirth.Text = selectedCustomer.DateOfBirth.ToShortDateString();
               lblPersonCustomerLicenceExpiryDate.Text = selectedCustomer.LicenseExpiryDate.ToShortDateString();
                lblPersonCustomerName.Text = selectedCustomer.Name;
                lblPersonCustomerId.Text = selectedCustomer.Id.ToString();
                lblPersonCustomerAge.Text = selectedCustomer.Age.ToString();
                lblPersonCustomerLicenceNumber.Text = selectedCustomer.LicenseNumber;
                lblPersonCustomerTelephone.Text = selectedCustomer.TelephoneNo.ToString();
            }

            if (tvPerson.SelectedNode.Tag is Employee)
            {
                Employee selectedEmployee = (Employee)tvPerson.SelectedNode.Tag;
                lblPersonEmployeeAddress.Text = selectedEmployee.Address;
                lblPersonEmployeeDateOfBirth.Text = selectedEmployee.DateOfBirth.ToShortDateString();
                lblPersonEmployeeName.Text = selectedEmployee.Name;
                lblPersonEmployeeId.Text = selectedEmployee.Id.ToString();
                lblPersonEmployeeTelephone.Text = selectedEmployee.TelephoneNo.ToString();
                lblPersonEmployeeOfficeAddress.Text = selectedEmployee.OfficeAddress;
                lblPersonEmployeeUsername.Text = selectedEmployee.Username;
                lblPersonEmployeeRole.Text = selectedEmployee.Role.ToString();
                lblPersonEmployeePhoneExtension.Text = selectedEmployee.PhoneExtensionNumber.ToString();
            }
        }
        

        private void tvEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEmployee.SelectedNode==null)
            {
                pnlAddEmployee.Enabled = false;
                btnRemoveEmployees.Enabled = false;
                btnAddEmployee.Enabled = true;
            }
            else if (tvEmployee.SelectedNode.Tag is Employee)
            {
                ViewEmployeeDetails();
                pnlAddEmployee.Enabled = true;
                btnRemoveEmployees.Enabled = true;
                btnAddEmployee.Enabled = true;
            }
        }

        private void tvCustomer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Customer)
            {
                ViewCustomerDetails();
                pnlAddCustomer.Enabled = true;
              
            }

        }

        private void tvPerson_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Customer)
            {
                ViewPersonDetails();
                pnlPersonCustomerDetails.Show();
                pnlPersonEmployeeDetails.Hide();

            }

            if (e.Node.Tag is Employee)
            {
                ViewPersonDetails();
                pnlPersonEmployeeDetails.Show();
                pnlPersonCustomerDetails.Hide();

            }

        }

        private void btnUploadEmployeePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            DialogResult selectedPhoto = photo.ShowDialog();
            pbEmployee.ImageLocation = photo.FileName;

        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

            SwitchSearchMode();
            PerformSearch();
        }

        private void cbSearchTypeCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchSearchModeCustomer();
            PerformSearchForCustomer();
        }

        private void cbSearchPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchSearchModePerson();
            PerformSearchForPerson();
        }
        private void SwitchSearchMode()
        {
            txtSearchBoxEmployee.Text = "";
            txtSearchBoxEmployee.Visible = false;
            dtmBirth.Visible = false;

            if ((string)cbSearchEmployee.SelectedItem == "ID")
            {
                txtSearchBoxEmployee.Text = "";
                txtSearchBoxEmployee.Visible = true;

            }
            else if ((string)cbSearchEmployee.SelectedItem == "Name")
            {
                txtSearchBoxEmployee.Text = "";
                txtSearchBoxEmployee.Visible = true;
            }

            else if ((string)cbSearchEmployee.SelectedItem == "Date Of Birth")
            {
                dtmBirth.Visible = true;
            }
        }

        private void SwitchSearchModeCustomer()
        {
            txtSearchBoxCustomer.Text = "";
            txtSearchBoxCustomer.Visible = false;
            dtpBirthSearchCustomer.Visible = false;

            if ((string)cbSearchTypeCustomer.SelectedItem == "ID")
            {
                txtSearchBoxCustomer.Text = "";
                txtSearchBoxCustomer.Visible = true;

            }
            else if ((string)cbSearchTypeCustomer.SelectedItem == "Name")
            {
                txtSearchBoxCustomer.Text = "";
                txtSearchBoxCustomer.Visible = true;
            }

            else if ((string)cbSearchTypeCustomer.SelectedItem == "Date Of Birth")
            {
                dtpBirthSearchCustomer.Visible = true;
            }
        }

        private void SwitchSearchModePerson()
        {
            txtSearchBoxPerson.Text = "";
            txtSearchBoxPerson.Visible = false;
            dtpBirthSearchPerson.Visible = false;

            if ((string)cbSearchTypePerson.SelectedItem == "ID")
            {
                txtSearchBoxPerson.Text = "";
                txtSearchBoxPerson.Visible = true;

            }
            else if ((string)cbSearchTypePerson.SelectedItem == "Name")
            {
                txtSearchBoxPerson.Text = "";
                txtSearchBoxPerson.Visible = true;
            }

            else if ((string)cbSearchTypePerson.SelectedItem == "Date Of Birth")
            {
                dtpBirthSearchPerson.Visible = true;
            }
        }

        private void PerformSearchForCustomer()
        {


            if (txtSearchBoxCustomer.Text == "" && txtSearchBoxCustomer.Visible == true)
            {
                CustomerRefresh();
                return;
            }

            HashSet<Customer> resultCustomers = new HashSet<Customer>();

            if ((string)cbSearchTypeCustomer.SelectedItem == "ID")
            {
                resultCustomers = Start.carYard.SearchIdCustomer(int.Parse(txtSearchBoxCustomer.Text));
            }
            else if ((string)cbSearchTypeCustomer.SelectedItem == "Name")
            {
                resultCustomers = Start.carYard.SearchNameCustomer(txtSearchBoxCustomer.Text);
            }

            else if ((string)cbSearchTypeCustomer.SelectedItem == "Date Of Birth")
            {
                resultCustomers = Start.carYard.SearchDateOfBirthCustomer(dtpBirthSearchCustomer.Value);
            }
            else
            {
                CustomerRefresh();
                return;
            }


            tvCustomer.Nodes.Clear();

            int counter = 1;
            foreach (Customer customer in resultCustomers)
            {
                TreeNode node2 = new TreeNode(customer.Name);
                tvCustomer.Nodes.Add(node2);
                node2.Tag = customer;
                counter++;
            }
        }

        private void PerformSearchForPerson()
        {


           if (txtSearchBoxPerson.Text == "" && txtSearchBoxPerson.Visible == true)
            {
                PersonRefresh();
                return;
            }

            HashSet<Customer> resultCustomers = new HashSet<Customer>();
            HashSet<Employee> resultEmployees = new HashSet<Employee>();

            if ((string)cbSearchTypePerson.SelectedItem == "ID")
            {
                resultCustomers = Start.carYard.SearchIdCustomer(int.Parse(txtSearchBoxPerson.Text));
                resultEmployees = Start.carYard.SearchId(int.Parse(txtSearchBoxPerson.Text));
            }
            else if ((string)cbSearchTypePerson.SelectedItem == "Name")
            {
                resultCustomers = Start.carYard.SearchNameCustomer(txtSearchBoxPerson.Text);
                resultEmployees = Start.carYard.SearchName(txtSearchBoxPerson.Text);
            }

            else if ((string)cbSearchTypePerson.SelectedItem == "Date Of Birth")
            {
                resultCustomers = Start.carYard.SearchDateOfBirthCustomer(dtpBirthSearchPerson.Value);
                resultEmployees = Start.carYard.SearchDateOfBirth(dtpBirthSearchPerson.Value);
            }
            else
            {
                PersonRefresh();
                return;
            }


            tvPerson.Nodes.Clear();
           

            int counter = 1;
            foreach (Customer customer in resultCustomers)
            {
                TreeNode node2 = new TreeNode(customer.Name);
                tvPerson.Nodes.Add(node2);
                node2.Tag = customer;
                counter++;
            }

            foreach (Employee employee in resultEmployees)
            {
                TreeNode node2 = new TreeNode(employee.Name);
                tvPerson.Nodes.Add(node2);
                node2.Tag = employee;
                counter++;
            }
        }

        private void PerformSearch()
        {


            if (txtSearchBoxEmployee.Text == "" && txtSearchBoxEmployee.Visible == true)
            {
                EmployeeRefresh();
                return;
            }

            HashSet<Employee> resultEmployee = new HashSet<Employee>();

            if ((string)cbSearchEmployee.SelectedItem == "ID")
            {
                resultEmployee = Start.carYard.SearchId(int.Parse(txtSearchBoxEmployee.Text));
            }
            else if ((string)cbSearchEmployee.SelectedItem == "Name")
            {
                resultEmployee = Start.carYard.SearchName(txtSearchBoxEmployee.Text);
            }

            else if ((string)cbSearchEmployee.SelectedItem == "Date Of Birth")
            {
                resultEmployee = Start.carYard.SearchDateOfBirth(dtmBirth.Value);
            }
            else
            {
                EmployeeRefresh();
                return;
            }


            tvEmployee.Nodes.Clear();

            int counter = 1;
            foreach (Employee employee in resultEmployee)
            {
                TreeNode node2 = new TreeNode(employee.Name);
                tvEmployee.Nodes.Add(node2);
                node2.Tag = employee;
                counter++;
            }
        }

        private void txtSearchBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            PerformSearchForCustomer();
        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtSearchBoxPerson_TextChanged(object sender, EventArgs e)
        {
            PerformSearchForPerson();
        }

        private void dtmBirth_ValueChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dtpBirthSearchCustomer_ValueChanged(object sender, EventArgs e)
        {
            PerformSearchForCustomer();
        }

        private void dtpBirthSearchPerson_ValueChanged(object sender, EventArgs e)
        {
            PerformSearchForPerson();
        }

        private void EmployeeAndCustomerManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();

        }

        private void EmployeeAndCustomerManagement_Load(object sender, EventArgs e)
        {
            CustomerRefresh();
            EmployeeRefresh();

        }

        private void pnlPersonEmployeeDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPersonCustomerDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlPersonEmployeeDetails_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnShowAllEmployee_Click(object sender, EventArgs e)
        {
            cbSearchEmployee.SelectedItem = null;
            txtSearchBoxEmployee.Text = "";
            dtmBirth.Value = DateTime.Now;
            pnlDefaultEmployee.Show();
            pnlAddEmployee.Hide();
        }

        private void btnShowAllCustomer_Click(object sender, EventArgs e)
        {
            cbSearchTypeCustomer.SelectedItem = null;
            txtSearchBoxCustomer.Text = "";
            dtpBirthSearchCustomer.Value = DateTime.Now;
            pnlDefaultCustomer.Show();
            pnlAddCustomer.Hide();
        }

        private void btnShowAllPerson_Click(object sender, EventArgs e)
        {
            cbSearchTypePerson.SelectedItem = null;
            txtSearchBoxPerson.Text = "";
            dtpBirthSearchPerson.Value = DateTime.Now;
            pnlPersonDefault.Show();
            pnlPersonEmployeeDetails.Hide();
            pnlPersonCustomerDetails.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewCustomerRentals_Click(object sender, EventArgs e)
        {
            if(tvCustomer.SelectedNode.Tag is Customer)
            {
                CustomerRecords customerRecords = new CustomerRecords((Customer)tvCustomer.SelectedNode.Tag);
                customerRecords.Closed += (s, args) => this.Show();
                customerRecords.Show();
                this.Hide();
            }
        }

        private void txtSearchBoxPerson_TextChanged_1(object sender, EventArgs e)
        {
            PerformSearchForPerson();
        }
    }
}
