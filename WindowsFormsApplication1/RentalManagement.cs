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
    public partial class RentalManagement : Form
    {
        public RentalManagement()
        {
            InitializeComponent();
            RefreshGrid();
            pnlDateRange.Visible = false;



        }

        private void RefreshGrid()
        {
            dgvRentalRecords.AutoGenerateColumns = true;
            dgvRentalRecords.DataSource = null;
            dgvRentalRecords.DataSource = Start.carYard.RentalRecords.ToList();
        }

        private void btnRentOut_Click(object sender, EventArgs e)
        {
            Rent rentCar = new Rent();
            rentCar.Closed += (s, args) => { this.Show(); RefreshGrid(); };
            rentCar.Show();
        }

        private void btnReceiveCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receive receiveCar = new Receive();
            receiveCar.Closed += (s, args) => { this.Show(); RefreshGrid(); };
            receiveCar.Show();
        }

        private void RentalManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }

        private void SwitchSearch()
        {
            pnlDateRange.Visible = false;

            if ((string)cbRentalSearch.SelectedItem == "Rent dates")
            {

                pnlDateRange.Visible = true;
            }

        }

        private void cbRentalSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformRentalSearch();
            SwitchSearch();
        }

        private void PerformRentalSearch()
        {

            HashSet<RentalRecord> results = new HashSet<RentalRecord>();

            if ((string)cbRentalSearch.SelectedItem == "Currently available for renting")
            {
                dgvRentalRecords.DataSource = null;
                dgvRentalRecords.DataSource = Start.carYard.GetAllAvailableCars.ToList();
                dgvRentalRecords.Columns["RentStart"].Visible = false;
                dgvRentalRecords.Columns["RentEnd"].Visible = false;
                dgvRentalRecords.Columns["PicturePath"].Visible = false;



            }
            else if ((string)cbRentalSearch.SelectedItem == "Currently rented out")

            {
                dgvRentalRecords.DataSource = null;
                dgvRentalRecords.DataSource = Start.carYard.OutstandingRentalRecords.ToList();
                dgvRentalRecords.Columns["CarReturnDate"].Visible = false;

            }


            else if ((string)cbRentalSearch.SelectedItem == "Overdue to return")
            {
                dgvRentalRecords.DataSource = null;

                dgvRentalRecords.DataSource = Start.carYard.OverdueCars().ToList();

            }
            else if ((string)cbRentalSearch.SelectedItem == "Rent dates")
            {
                dgvRentalRecords.DataSource = null;
                dgvRentalRecords.DataSource = Start.carYard.SearchRentalByDate(dtpFrom.Value, dtpTo.Value).ToList();
            }
            else
            {

                RefreshGrid();
            }


        }

        private void dgvRentalRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvRentalRecords.Columns[e.ColumnIndex].Name == "RentBeginDate" || this.dgvRentalRecords.Columns[e.ColumnIndex].Name == "RentEndDate" || this.dgvRentalRecords.Columns[e.ColumnIndex].Name == "CarReturnDate")
            {
                if ((DateTime)e.Value == DateTime.MinValue)
                {
                    e.Value= "";

                }
                else
                {
                    e.Value = ((DateTime)e.Value).ToShortDateString();
                    e.FormattingApplied = true;
                }
                
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            PerformRentalSearch();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            PerformRentalSearch();
        }

        private void btnShowAllRentals_Click(object sender, EventArgs e)
        {
            cbRentalSearch.SelectedItem = null;
        }
    }
}
