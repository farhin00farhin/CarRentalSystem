using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public class Employee : Person
    {
        string _officeAddress;
        string _password; 
        int _phoneExtensionNumber; 
        Role _role;
        string _username;
        string _picturePath;

        public Employee(string officeAddress, string password, int phoneExtensionNumber, Role role, string username, string address, DateTime dateOfBirth, int id, string name, long telephoneNo):base(address, dateOfBirth, id, name, telephoneNo)
        {

            OfficeAddress = officeAddress;
            Password = password;
            PhoneExtensionNumber = phoneExtensionNumber;
            Role = role;
            Username = username;

        }

        public string OfficeAddress
        {
            get
            {
                return _officeAddress;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You entered an empty Office Address!");
                }
                _officeAddress = value;
            }
        }

        public string Password
        {
            set
            {
                if (value.Length > 0)
                {
                    _password = value;
                }
            }
        }

        public int PhoneExtensionNumber
        {
            get
            {
                return _phoneExtensionNumber;
            }

            set
            {
                if (value > 0 && value < 9999)
                {
                    _phoneExtensionNumber = value;
                }
                else
                {
                    throw new ArgumentException("Extension number is invalid. Please try again.");
                }
            }
        }

        public string Username
        {
            get
            {
                
                return _username;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You entered an empty username!");
                }
                _username = value;
            }
        }

        public Role Role
        {
            get
            {
                
                return _role;
            }

            set
            {
                _role = value;
            }
        }

        public string PicturePath
        {
            get
            {
                return _picturePath;
            }

            set
            {
                _picturePath = value;
            }
        }

        public void AddModel(CarModel model, CarYard yard)
        {
            yard.Models.Add(model);

        }

        public void RemoveModel(CarModel model, CarYard yard)
        {
            yard.Models.Remove(model);
        }

        public void AddCarToExistingModel(Car newCar, string model, string brand, CarYard yard)
        {
            yard.AddNewCarToExistingModel(newCar, model, brand);
        }

        public void RemoveCar(Car newCar, CarModel model)
        {
            model.AllCars.Remove(newCar);
        }

        public HashSet<Car> SearchBrandName(string brandName, CarYard yard)
        {
            HashSet<Car> matchedByBrandCars = new HashSet<Car>();

            foreach (CarModel newCarModel in yard.Models)
            {
                
                if (brandName == newCarModel.Brand)
                {
                    foreach (Car newCar in newCarModel.AllCars)
                    {
                        matchedByBrandCars.Add(newCar);
                    }
                   
                }
            }

            return matchedByBrandCars;
        }

        public HashSet<Car> SearchCategory(BodyStyle category, CarYard yard)
        {
            HashSet<Car> matchedByCategoryCars = new HashSet<Car>();

            foreach (CarModel newCarModel in yard.Models)
            {
                foreach (Car newCar in newCarModel.AllCars)
                {
                    if (newCar.CarBodyStyle == category)
                    {
                        matchedByCategoryCars.Add(newCar);
                    }
                        
                }
            }

            return matchedByCategoryCars;
        }


        public HashSet<RentalRecord> IssueCar(HashSet<Car> cars, DateTime newRentStart, DateTime newRentEnd, Customer customer)
         {
            HashSet<RentalRecord> rentalRecords = new HashSet<RentalRecord>();
            foreach (Car newCar in cars)
            {
                newCar.RentStart = newRentStart;
                newCar.RentEnd = newRentEnd;

                if (newCar.IsRentable())
                {
                    newCar.CurrentCarStatus = CarStatus.RentedOut;

                    rentalRecords.Add(new RentalRecord(newCar, customer, this, newRentStart, newRentEnd));
                }
                else
                {
                    throw new InvalidOperationException("The car is not available for renting");
                }
            }

            return rentalRecords;

         }

         public bool ReceiveReturnedCar(RentalRecord record)
         {
                if (record.RentedCar.CurrentCarStatus==CarStatus.RentedOut && record.RentingCustomer.RentedCars.Contains(record.RentedCar))
                {
                    record.RentedCar.CurrentCarStatus = CarStatus.OnShop;
                    record.CarReturnDate = DateTime.Now;
                    return true;      
                }

            return false;
        }

        public bool MatchPassword(string password)
        {
            if (password == _password)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("\n Name: {0}",Name);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Employee))
            {
                return false;
            }
            Employee newEmployee = (Employee)obj;
            if (newEmployee.Id == this.Id || newEmployee.Username == this.Username)
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
            // Returning a constant number so that the Equals method will be called 
            // when a hashset goes to add a new object
            return 0;
        }


    }
}
