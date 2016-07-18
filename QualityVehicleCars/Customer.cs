using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public class Customer : Person
    {
        int _age;
        DateTime _licenseExpiryDate;
        string _licenseNumber;
        HashSet<Car> _rentedCars = new HashSet<Car>();

        public Customer(DateTime licenseExpiryDate, string licenseNumber, string address, DateTime dateOfBirth, int id, string name, long telephoneNo) : base(address, dateOfBirth, id, name, telephoneNo)
        {
            LicenseExpiryDate = licenseExpiryDate;
            LicenseNumber = licenseNumber;

            Console.WriteLine("Quality Vehicle Cars has 1 new customer.\nCustomer details: {0}", ToString());
            Console.WriteLine("********************************************************");
        }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Now;
                _age = today.Year - DateOfBirth.Year;

                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public DateTime LicenseExpiryDate
        {
            get
            {
                return _licenseExpiryDate;
            }

            set
            {

                if (value > DateTime.Today)
                {
                    _licenseExpiryDate = value;
                }
                else
                {
                    throw new ArgumentException("You entered an invalid licence expiry date!");
                }

            }
        }

        public string LicenseNumber
        {
            get
            {

                return _licenseNumber;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You entered an empty Licence Number!");
                }
                _licenseNumber = value;


            }
        }

        public HashSet<Car> RentedCars
        {
            get
            {
                return _rentedCars;
            }

        }



        public HashSet<RentalRecord> RentCar(Employee staff, HashSet<Car> cars, DateTime newRentStart, DateTime newRentEnd)
        {

            HashSet<RentalRecord> records = staff.IssueCar(cars, newRentStart, newRentEnd, this);
            foreach (Car newCar in cars)
            {
                if (newCar.CurrentCarStatus == CarStatus.RentedOut)
                {
                    _rentedCars.Add(newCar);
                }
                else
                {
                    Console.WriteLine("This car has not been rented to {0}.", Name);
                }

            }

            return records;

        }

        public bool ReturnCar(Employee staff, RentalRecord record)
        {
            bool returned = staff.ReceiveReturnedCar(record);

            if (_rentedCars.Contains(record.RentedCar) && record.RentedCar.CurrentCarStatus == CarStatus.OnShop)
            {
                _rentedCars.Remove(record.RentedCar);
                Console.WriteLine("{0} has returned 1 car", this.Name);
            }

            else
            {
                Console.WriteLine("{0} has not rented this car. So {0} can't return it.", Name);
            }
            return returned;

        }


        public override string ToString()
        {
            return string.Format("\n Name: {0}", Name);

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Customer))
            {
                return false;
            }
            Customer newCustomer = (Customer)obj;
            if (newCustomer.Id == this.Id || newCustomer.LicenseNumber == this.LicenseNumber)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {   // Returning a constant number so that the Equals method will be called 
            // when a hashset goes to add a new object
            return 1;
        }
    }
}

