using QualityVehicleCars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityVehicleForms
{
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();           
            pnlRentDefault.Show();
            pnlAddCustomer.Hide();
            pnlExistingCustomers.Hide();
            StockRefresh();
            CustomerRefresh();
            timer1.Start();
            
        }

        private void StockRefresh()
        {
            tvCars.Nodes.Clear();
            foreach (CarModel carModel in Start.carYard.Models)
            {
                TreeNode node1 = new TreeNode(carModel.Model + ":" + carModel.Brand);
                tvCars.Nodes.Add(node1);
                node1.Tag = carModel;

                int counter = 1;
                foreach (Car car in carModel.AllCars)
                {
                    TreeNode node2 = new TreeNode("Car " + counter + ": " + car.EngineNumber.ToString());
                    node1.Nodes.Add(node2);
                    node2.Tag = car;
                    counter++;
                }
            }

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            pnlRentDefault.Hide();
            pnlAddCustomer.Show();
            pnlExistingCustomers.Hide();



            tvCars.SelectedNode = null;

        }

        private void btnOldCustomer_Click(object sender, EventArgs e)
        {
            pnlRentDefault.Hide();
            pnlAddCustomer.Hide();
            pnlExistingCustomers.Show();
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

        private void tvCars_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvCars_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is CarModel)
            {
                if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            HashSet<Car> checkedCars = new HashSet<Car>();
            foreach (TreeNode carModelNode in tvCars.Nodes)
            {
                foreach (TreeNode carNode in carModelNode.Nodes)
                {
                    if (carNode.Checked)
                    {
                        checkedCars.Add((Car)carNode.Tag);
                    }
                }
            }
            try
            {
                Customer customerToRentTo = null;
                if (pnlExistingCustomers.Visible)
                {
                    customerToRentTo = (Customer)tvCustomer.SelectedNode.Tag;
                }
                else
                {
                    customerToRentTo = new Customer(dtpLicenceExpiryDateCustomer.Value, txtLicenseNumberCustomer.Text, txtAddressCustomer.Text, dtpDateOfBirthCustomer.Value, int.Parse(txtIdCustomer.Text), txtNameCustomer.Text, long.Parse(txtTelephoneCustomer.Text));
                    if (Start.carYard.customers.Contains(customerToRentTo))
                    {
                        throw new ArgumentException("A customer with this ID or Licence Number already exists.");
                    }
                }

                

                HashSet<RentalRecord> records = customerToRentTo.RentCar(Start.carYard.loggedInEmployee, checkedCars, dtpFrom.Value, dtpTo.Value);

                foreach (RentalRecord item in records)
                {
                    Start.carYard.RentalRecords.Add(item);
                }

                if (records.Count > 0)
                {
                    Start.carYard.customers.Add(customerToRentTo);
                }

                MessageBox.Show(string.Format("Successfully rented {0} out of {1} cars", records.Count, checkedCars.Count)); }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (InvalidOperationException ex)
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


                CustomerRefresh();
            StockRefresh();
            pnlRentDefault.Show();
            tvCars.SelectedNode = null;
            pnlExistingCustomers.Hide();

            txtIdCustomer.Clear();
            txtTelephoneCustomer.Clear();
            txtNameCustomer.Clear();
            txtAddressCustomer.Clear();
            txtLicenseNumberCustomer.Clear();
            dtpDateOfBirthCustomer.Value = DateTime.Now;
            txtLicenseNumberCustomer.Clear();
            dtpLicenceExpiryDateCustomer.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now;

            txtIdCustomer.Enabled = true;
            txtTelephoneCustomer.Enabled = true;
            txtNameCustomer.Enabled = true;
            txtAddressCustomer.Enabled = true;
            txtLicenseNumberCustomer.Enabled = true;
            
        }

        private void Rent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }


        private void tvCars_DoubleClick(object sender, EventArgs e)
        {
            if (tvCars.SelectedNode != null && tvCars.SelectedNode.Tag is Car)
            {
                CarDetails carDetailsForm = new CarDetails((Car)tvCars.SelectedNode.Tag);
                carDetailsForm.Closed += (s, args) => this.Show();
                carDetailsForm.Show();
                this.Hide();
            }
        }

        private void tvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (tvCustomer.SelectedNode != null && tvCustomer.SelectedNode.Tag is Customer)
            {
                CustomerDetails customerDetailsForm = new CustomerDetails((Customer)tvCustomer.SelectedNode.Tag);
                customerDetailsForm.Closed += (s, args) => this.Show();
                customerDetailsForm.Show();
                this.Hide();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            foreach (TreeNode node in tvCars.Nodes)
            {
                if (!(node.Tag is Car))
                {
                    node.Checked = false;
                }
            }
        }
    }
}
