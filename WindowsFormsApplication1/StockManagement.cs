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
using System.IO.IsolatedStorage;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace QualityVehicleForms
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
            SwitchSearchMode();
            pnlAddModel.Hide();
            pnlAddcar.Hide();
            pnlDefaultStock.Show();
            cbBodyStyle.DataSource = Enum.GetValues(typeof(BodyStyle));
            cbSearchCategory.ComboBox.DataSource = Enum.GetValues(typeof(BodyStyle));
            cbStatus.DataSource = Enum.GetValues(typeof(CarStatus));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (tvCars.SelectedNode == null)
            {
                CarModel carmodel1 = new CarModel(int.Parse(txtPassengerCapacity.Text), int.Parse(txtSeat.Text), txtBrand.Text, int.Parse(txtEngineSize.Text), int.Parse(txtFuelCapacity.Text), txtModel.Text, double.Parse(txtRentCharge.Text), int.Parse(txtYearOfManufacture.Text));
                Start.carYard.loggedInEmployee.AddModel(carmodel1, Start.carYard);
                StockRefresh();
                pnlDefaultStock.Show();
               
                pnlAddcar.Hide();
                pnlAddModel.Hide();
            }
            else if (tvCars.SelectedNode.Tag is CarModel)
            {
                CarModel selectedModel = (CarModel)tvCars.SelectedNode.Tag;

                selectedModel.RentChargePerDay = double.Parse(txtRentCharge.Text);
                tvCars.SelectedNode = null;
                tvCars_AfterSelect(null, null);
                pnlDefaultStock.Show();
                StockRefresh();
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



        private void btnRemoveModel_Click(object sender, EventArgs e)
        {

            Start.carYard.loggedInEmployee.RemoveModel((CarModel)tvCars.SelectedNode.Tag, Start.carYard);
            StockRefresh();
            pnlAddcar.Hide();
            pnlDefaultStock.Show();
            tvCars.SelectedNode = null;
            tvCars_AfterSelect(null, null);
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            pnlDefaultStock.Hide();
            pnlAddModel.Show();
            txtBrand.Clear();
            txtEngineSize.Clear();
            txtFuelCapacity.Clear();
            txtModel.Clear();
            txtPassengerCapacity.Clear();
            txtRentCharge.Clear();
            txtSeat.Clear();
            txtYearOfManufacture.Clear();


            txtBrand.Enabled = true;
            txtEngineSize.Enabled = true;
            txtFuelCapacity.Enabled = true;
            txtModel.Enabled = true;
            txtPassengerCapacity.Enabled = true;
            txtYearOfManufacture.Enabled = true;
            txtSeat.Enabled = true;

            tvCars.SelectedNode = null;
            tvCars_AfterSelect(null, null);

        }


        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvCars.SelectedNode == null)
                {
                    return;
                }

                else if (tvCars.SelectedNode.Tag is CarModel)
                {
                    Car car1 = new Car((BodyStyle)cbBodyStyle.SelectedValue, (CarStatus)cbStatus.SelectedValue, txtColor.Text, int.Parse(txtEngineNumber.Text), dtmRegistrationDate.Value, dtmWof.Value);
                    car1.PicturePath = pbCar.ImageLocation;
                    Start.carYard.loggedInEmployee.AddCarToExistingModel(car1, ((CarModel)tvCars.SelectedNode.Tag).Model, ((CarModel)tvCars.SelectedNode.Tag).Brand, Start.carYard);
                    StockRefresh();

                    pnlDefaultStock.Show();
                    tvCars.SelectedNode = null;
                    tvCars_AfterSelect(null, null);
                    pnlAddcar.Hide();
                    pnlAddModel.Hide();

                }

                else if (tvCars.SelectedNode.Tag is Car)
                {
                    Car selectedCar = (Car)tvCars.SelectedNode.Tag;
                    selectedCar.Colour = txtColor.Text;
                    selectedCar.CurrentCarStatus = (CarStatus)cbStatus.SelectedValue;
                    selectedCar.RegistrationDueDate = dtmRegistrationDate.Value;
                    selectedCar.WofDueDate = dtmWof.Value;
                    selectedCar.PicturePath = pbCar.ImageLocation;
                    pnlDefaultStock.Show();
                    tvCars.SelectedNode = null;
                    tvCars_AfterSelect(null, null);
                    pnlAddcar.Hide();
                    pnlAddModel.Hide();
                    StockRefresh();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (FormatException)
            {
                MessageBox.Show("You can't leave the textboxes empty. Please enter a valid value.");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error saving the data. Please ensure you've entered valid values in all the fields.");

            }
        }


        private void btnAddCar_Click(object sender, EventArgs e)
        {
            txtColor.Clear();
            pbCar.ImageLocation = "";
            txtEngineNumber.Clear();
            dtmWof.Value = DateTime.Now;
            dtmRegistrationDate.Value = DateTime.Now;
            cbBodyStyle.SelectedItem = BodyStyle.Hatchback;
            cbStatus.SelectedItem = CarStatus.OnShop;

            pnlAddModel.Hide();
            pnlDefaultStock.Hide();
            pnlAddcar.Show();
            txtEngineNumber.Enabled = true;
            cbBodyStyle.Enabled = true;

        }

        private void tvCars_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (tvCars.SelectedNode == null)


            { 
                btnRemoveCar.Enabled = false;
                btnRemoveModel.Enabled = false;
                btnAddCar.Enabled = false;
                btnAddModel.Enabled = true;
                return;
            }
            if (tvCars.SelectedNode.Tag is CarModel)
            {
                CarModel selectedModel = (CarModel)tvCars.SelectedNode.Tag;
                ViewCarModelDetails(selectedModel);
                pnlAddModel.Enabled = true;
                btnRemoveModel.Enabled = true;
                btnAddCar.Enabled = true;
                btnRemoveCar.Enabled = false;
                btnAddModel.Enabled = true;
            }


            else if (tvCars.SelectedNode.Tag is Car)
            {
                ViewCarDetails();
                btnRemoveCar.Enabled = true;
                btnRemoveModel.Enabled = false;
                btnAddCar.Enabled = false;
                btnAddModel.Enabled = false;
            }



        }

        private void ViewCarModelDetails(CarModel selectedModel)
        {

            pnlAddModel.Show();
            pnlDefaultStock.Hide();
            pnlAddcar.Hide();

            txtBrand.Enabled = false;
            txtEngineSize.Enabled = false;
            txtFuelCapacity.Enabled = false;
            txtModel.Enabled = false;
            txtPassengerCapacity.Enabled = false;
            txtYearOfManufacture.Enabled = false;
            txtSeat.Enabled = false;

            txtBrand.Text = selectedModel.Brand;
            txtEngineSize.Text = selectedModel.EngineSize.ToString();
            txtFuelCapacity.Text = selectedModel.FuelCapacity.ToString();
            txtModel.Text = selectedModel.Model;
            txtPassengerCapacity.Text = selectedModel.PassengerCapacity.ToString();
            txtRentCharge.Text = selectedModel.RentChargePerDay.ToString();
            txtSeat.Text = selectedModel.Seat.ToString();
            txtYearOfManufacture.Text = selectedModel.YearOfManufacture.ToString();
        }

        private void ViewCarDetails()
        {

            Car selectedCar = (Car)tvCars.SelectedNode.Tag;

            ViewCarModelDetails(Start.carYard.SearchCarAcrossModels(selectedCar));
            pnlAddModel.Show();
            pnlAddModel.Enabled = false;
            pnlDefaultStock.Hide();
            pnlAddcar.Show();

            txtEngineNumber.Enabled = false;
            cbBodyStyle.Enabled = false;



            cbStatus.SelectedItem = selectedCar.CurrentCarStatus;
            txtEngineNumber.Text = selectedCar.EngineNumber.ToString();
            cbBodyStyle.SelectedItem = selectedCar.CarBodyStyle;
            dtmWof.Value = selectedCar.WofDueDate;
            dtmRegistrationDate.Value = selectedCar.RegistrationDueDate;
            txtColor.Text = selectedCar.Colour;
            pbCar.ImageLocation = selectedCar.PicturePath;

        }

        private void StockManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.SaveCarYard();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            StockRefresh();
        }



        private void btnUploadCarPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            DialogResult selectedPhoto = photo.ShowDialog();
            pbCar.ImageLocation = photo.FileName;

        }

        private void txtSearchStock_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

            SwitchSearchMode();
            PerformSearch();
        }

        private void SwitchSearchMode()
        {
            txtSearchStock.Text = "";
            txtSearchStock.Visible = false;
            cbSearchCategory.Visible = false;
            cbSearchCategory.SelectedItem = null;

            if ((string)cbSearchType.SelectedItem == "Brand")
            {
                txtSearchStock.Text = "";
                txtSearchStock.Visible = true;

            }
            else if ((string)cbSearchType.SelectedItem == "Category")
            {
                cbSearchCategory.Visible = true;
            }
        }

        private void PerformSearch()
        {


            if (txtSearchStock.Text == "" && txtSearchStock.Visible == true)
            {
                StockRefresh();
                return;
            }

            HashSet<Car> resultCars = new HashSet<Car>();

            if ((string)cbSearchType.SelectedItem == "Brand")
            {
                resultCars = Start.carYard.loggedInEmployee.SearchBrandName(txtSearchStock.Text, Start.carYard);
            }
            else if ((string)cbSearchType.SelectedItem == "Category" && cbSearchCategory.SelectedItem != null)
            {
                resultCars = Start.carYard.loggedInEmployee.SearchCategory((BodyStyle)cbSearchCategory.SelectedItem, Start.carYard);
            }
            else
            {
                StockRefresh();
                return;
            }




            tvCars.Nodes.Clear();

            int counter = 1;
            foreach (Car car in resultCars)
            {
                TreeNode node2 = new TreeNode("Car " + counter + ": " + car.EngineNumber.ToString());
                tvCars.Nodes.Add(node2);
                node2.Tag = car;
                counter++;
            }
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }



        private void btnShowAllStock_Click(object sender, EventArgs e)
        {
            cbSearchType.SelectedItem = null;
            cbSearchCategory.SelectedItem = null;
            txtSearchStock.Text = "";
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            Start.carYard.loggedInEmployee.RemoveCar((Car)tvCars.SelectedNode.Tag, (CarModel)tvCars.SelectedNode.Parent.Tag);
            StockRefresh();
            pnlAddcar.Hide();
            pnlDefaultStock.Show();
            tvCars.SelectedNode = null;
            tvCars_AfterSelect(null, null);
        }

        private void btnShowAllStock_Click_1(object sender, EventArgs e)
        {
            cbSearchType.SelectedItem = null;
            txtSearchStock.Text = "";
            cbSearchCategory.SelectedItem = null;
            pnlAddcar.Hide();
            pnlDefaultStock.Show();
            tvCars.SelectedNode = null;
            tvCars_AfterSelect(null, null);
        }
    }
}
