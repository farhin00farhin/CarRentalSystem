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
    public partial class CarDetails : Form
    {
        public CarDetails(QualityVehicleCars.Car selectedCar)
        {
            InitializeComponent();

            ViewCarDetails(selectedCar);
        }

        public void ViewCarDetails(Car selectedCar)
        {

            ViewCarModelDetails(Start.carYard.SearchCarAcrossModels(selectedCar));
            pnlAddModel.Show();

            lblStatus.Text = selectedCar.CurrentCarStatus.ToString();
            lblEngineNumber.Text = selectedCar.EngineNumber.ToString();
            lblBodyStyle.Text = selectedCar.CarBodyStyle.ToString();
            lblWof.Text = selectedCar.WofDueDate.ToShortDateString();
            lblRegistrationDate.Text = selectedCar.RegistrationDueDate.ToShortDateString();
            lblColor.Text = selectedCar.Colour;
            pbCar.ImageLocation = selectedCar.PicturePath;
        }

        public void ViewCarModelDetails(CarModel selectedModel)
        {

            lblBrand.Text = selectedModel.Brand;
            lblEngineSize.Text = selectedModel.EngineSize.ToString();
            lblFuelCapacity.Text = selectedModel.FuelCapacity.ToString();
            lblModel.Text = selectedModel.Model;
            lblPassengerCapacity.Text = selectedModel.PassengerCapacity.ToString();
            lblRentCharge.Text = selectedModel.RentChargePerDay.ToString();
            lblSeat.Text = selectedModel.Seat.ToString();
            lblYearOfManufacture.Text = selectedModel.YearOfManufacture.ToString();

        }
    }
}
