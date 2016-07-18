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
    public partial class CustomerRecords : Form
    {
        Customer _displayedCustomer;

        public CustomerRecords(Customer customerToDisplay)
        {
            InitializeComponent();

            _displayedCustomer = customerToDisplay;
            RefreshGrid();

        }

        private void RefreshGrid()
        {
            dgvRentalRecords.AutoGenerateColumns = true;
            dgvRentalRecords.DataSource = null;
            dgvRentalRecords.DataSource = Start.carYard.SearchRentalByCustomer(_displayedCustomer).ToList();
        }

        

        private void Receive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }
    }
}
