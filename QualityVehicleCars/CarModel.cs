using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public class CarModel
    {



        int _passengerCapacity;
        int _seat;
        string _brand;
        int _engineSize;
        int _fuelCapacity;
        string _model;
        double _rentChargePerDay;
        int _yearOfManufacture;
        HashSet<Car> _allCars = new HashSet<Car>();

        public CarModel(int passengerCapacity, int seat, string brand, int engineSize, int fuelCapacity, string model, double rentChargePerDay, int yearOfManufacture)
        {
            if (passengerCapacity < 1 || passengerCapacity > 30)
            {
                throw new ArgumentException("Passenger capacity can't be less than 1 or greater than 30.");
            }

            if (seat < 1 || seat > 15)
            {
                throw new ArgumentException("Number of seats can't be less than 1 or greater than 15.");
            }

            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new ArgumentException("Brand can't be empty.");
            }

            if (engineSize < 1 || engineSize > int.MaxValue)
            {
                throw new ArgumentException("Engine Size can't be less than 1 or greater than " + int.MaxValue + ".");
            }

            if (fuelCapacity < 1 || fuelCapacity > int.MaxValue)
            {
                throw new ArgumentException("Fuel capacity can't be less than 1 or greater than " + int.MaxValue + ".");
            }



            if (yearOfManufacture < 1800 || yearOfManufacture > DateTime.Now.Year)
            {
                throw new ArgumentException("Year of manufacture can't be less than 1800 or greater than " + DateTime.Now.Year + ".");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model can't be empty.");
            }


            _passengerCapacity = passengerCapacity;
            _seat = seat;
            _brand = brand;
            _engineSize = engineSize;
            _fuelCapacity = fuelCapacity;
            RentChargePerDay = rentChargePerDay;
            _yearOfManufacture = yearOfManufacture;
            _model = model;


        }

        public int PassengerCapacity
        {
            get
            {
                return _passengerCapacity;

            }

        }

        public int Seat
        {
            get
            {
                return _seat;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
        }

        public int EngineSize
        {
            get
            {
                return _engineSize;
            }

        }

        public int FuelCapacity
        {
            get
            {

                return _fuelCapacity;
            }


        }

        public string Model
        {
            get
            {

                return _model;
            }

        }

        public double RentChargePerDay
        {
            get
            {

                return _rentChargePerDay;
            }

            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("Rent charge per day can't be less than 0 or greater than " + double.MaxValue + ".");
                }
                _rentChargePerDay = value;
            }
        }

        public int YearOfManufacture
        {
            get
            {

                return _yearOfManufacture;
            }

        }

        public HashSet<Car> AllCars
        {
            get
            {
                return _allCars;
            }

        }

        public HashSet<Car> RentedOutCars
        {
            get
            {
                HashSet<Car> rentedCars = new HashSet<Car>();
                foreach (Car newCar in AllCars)
                {
                    if (newCar.CurrentCarStatus == CarStatus.RentedOut)
                    {
                        rentedCars.Add(newCar);
                    }
                }

                return rentedCars;
            }
        }

        public HashSet<Car> AvailableCars
        {
            get
            {
                HashSet<Car> availableCars = new HashSet<Car>();
                foreach (Car newCar in AllCars)
                {
                    if (newCar.CurrentCarStatus == CarStatus.OnShop)
                    {
                        availableCars.Add(newCar);
                    }
                }

                return availableCars;
            }
        }


        public double WeeklyRentCharge(int numberOfCars)
        {

            return _rentChargePerDay * 7 * numberOfCars;
        }

        public override bool Equals(object obj)
        {

            if (!(obj is CarModel))
            {
                return false;
            }
            CarModel newModel = (CarModel)obj;
            if (newModel.Brand == this.Brand || newModel.Model == this.Model)
            {
                return true;

            }

            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (_brand + _model).GetHashCode();
        }

        public override string ToString()
        {
            string currentModel = string.Format("\n Passenger Capacity: {0}\n Seat: {1} \n Brand: {2}\n Engine Size: {3}\n Fuel Capacity: {4}\n Model: {5} \n Rent Charge Per Day: {6} \n Year Of Manufacture: {7}", PassengerCapacity, Seat, Brand, EngineSize, FuelCapacity, Model, RentChargePerDay, YearOfManufacture);
            return currentModel;
        }
    }


}
