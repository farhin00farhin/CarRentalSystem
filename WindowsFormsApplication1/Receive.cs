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
    public partial class Receive : Form
    {
        public Receive()
        {
            InitializeComponent();

            RefreshGrid();

        }

        private void RefreshGrid()
        {
            dgvRentalRecords.AutoGenerateColumns = true;
            dgvRentalRecords.DataSource = null;
            dgvRentalRecords.DataSource = Start.carYard.OutstandingRentalRecords.ToList();
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvRentalRecords.SelectedRows.Count == 0) {
                return;
            }
            

                RentalRecord record = (RentalRecord)dgvRentalRecords.SelectedRows[0].DataBoundItem;
                record.RentingCustomer.ReturnCar(Start.carYard.loggedInEmployee, record);
                MessageBox.Show("Returned successfully");
                
                RefreshGrid();
            
            dgvRentalRecords.ClearSelection();


        }

        private void Receive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }
    }
}
