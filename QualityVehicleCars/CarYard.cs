using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public class CarYard
    {

        public  HashSet<Employee> employees = new HashSet<Employee>();
        public HashSet<Customer> customers= new HashSet<Customer>();
        public  Employee loggedInEmployee = null;

        HashSet<CarModel> _models = new HashSet<CarModel>();
         HashSet<RentalRecord> _rentalRecords = new HashSet<RentalRecord>();

        public HashSet<CarModel> Models
        {
            get
            {
                return _models;
            }
        }


        public void ListOfAllRentedCars()
        {
            int totalCount = 0;
            foreach (CarModel myModel in Models)
            {
                foreach (Car car in myModel.AllCars)
                {
                    if (car.CurrentCarStatus == CarStatus.RentedOut)
                    {
                        totalCount++;
                    }
                }
            }
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("A total of {0} cars have been rented to customers.", totalCount);
            int carCount = 0;
            Console.WriteLine("Car Details: ");
            foreach (CarModel myModel in Models)
            {
                foreach (Car car in myModel.AllCars)
                {
                    if (car.CurrentCarStatus == CarStatus.RentedOut)
                    {

                        carCount++;
                        Console.WriteLine(carCount + ". " + car.ToString());
                    }
                }
            }

        }

        public HashSet<Car> GetAllAvailableCars { 
        get
            {
                HashSet<Car> carResults = new HashSet<Car>();
                foreach (CarModel myModel in Models)
                {
                    foreach (Car car in myModel.AllCars)
                    {
                        if (car.CurrentCarStatus == CarStatus.OnShop)
                        {
                            carResults.Add(car);
                        }
                    }
                }
                return carResults;
            }
        }

        public HashSet<RentalRecord> RentalRecords
        {
            get
            {
                if (_rentalRecords == null)
                {
                    _rentalRecords = new HashSet <RentalRecord>();
                }
                return _rentalRecords;
            }

            set
            {
                _rentalRecords = value;
            }
        }
        public HashSet<RentalRecord> OverdueCars()
        {
          HashSet<RentalRecord> overdueCars = new HashSet<RentalRecord>();
          foreach (RentalRecord record in RentalRecords)
          {
              if (record.CarReturnDate == DateTime.MinValue && record.RentEndDate < DateTime.Now)
              {
                  overdueCars.Add(record);

              }

}

          return overdueCars;

      }

        public HashSet<RentalRecord> OutstandingRentalRecords
        {
            get
            {
                HashSet<RentalRecord> outstanding = new HashSet<RentalRecord>();
                foreach (RentalRecord record in RentalRecords)
                {
                    if (record.CarReturnDate == DateTime.MinValue)
                    {
                        outstanding.Add(record);
                    }
                    
                }
                return outstanding;
            }

            
        }

        public string AddNewCarToExistingModel(Car newCar, string model, string brand)
        {
            string msg = "Sorry this car model does not exist in our yard";
            foreach (CarModel myModel in Models)
            {
                if (myModel.Model == model && myModel.Brand == brand)
                {
                    myModel.AllCars.Add(newCar);
                    msg = "Car has been added successfully";
                    break;
                }
            }
            return msg;
        }

        public HashSet<Employee> SearchName(string name)
        {
            HashSet<Employee> matchedByName = new HashSet<Employee>();

            foreach (Employee newEmployee in employees)
            {

                if (name == newEmployee.Name)
                {
                    matchedByName.Add(newEmployee);

                }
            }

            return matchedByName;
        }

        public HashSet<Customer> SearchNameCustomer(string name)
        {
            HashSet<Customer> matchedByName = new HashSet<Customer>();

            foreach (Customer newCustomer in customers)
            {

                if (name == newCustomer.Name)
                {
                    matchedByName.Add(newCustomer);

                }
            }

            return matchedByName;
        }

        public HashSet<Employee> SearchId(int id)
        {
            HashSet<Employee> matchedById = new HashSet<Employee>();

            foreach (Employee newEmployee in employees)
            {

                if (id == newEmployee.Id)
                {
                    matchedById.Add(newEmployee);

                }
            }

            return matchedById;
        }

        public HashSet<Customer> SearchIdCustomer(int id)
        {
            HashSet<Customer> matchedById = new HashSet<Customer>();

            foreach (Customer newCustomer in customers)
            {

                if (id == newCustomer.Id)
                {
                    matchedById.Add(newCustomer);

                }
            }

            return matchedById;
        }

        public HashSet<Employee> SearchDateOfBirth(DateTime dateOfBirth)
        {
            HashSet<Employee> matchedByDateOfBirth = new HashSet<Employee>();

            foreach (Employee newEmployee in employees)
            {

                if (dateOfBirth.Date == newEmployee.DateOfBirth.Date)
                {
                    matchedByDateOfBirth.Add(newEmployee);

                }
            }

            return matchedByDateOfBirth;
        }

        public HashSet<Customer> SearchDateOfBirthCustomer(DateTime dateOfBirth)
        {
            HashSet<Customer> matchedByDateOfBirth = new HashSet<Customer>();

            foreach (Customer newCustomer in customers)
            {

                if (dateOfBirth.Date == newCustomer.DateOfBirth.Date)
                {
                    matchedByDateOfBirth.Add(newCustomer);

                }
            }

            return matchedByDateOfBirth;
        }

        public CarModel SearchCarAcrossModels(Car car)
        {
            foreach (CarModel carModel in Models)
            {
                if (carModel.AllCars.Contains(car))
                {
                    return carModel;
                }
            }

            return null;

        }

        public HashSet<RentalRecord> SearchRentalByDate(DateTime from, DateTime to)
        {
            HashSet<RentalRecord> records = new HashSet<RentalRecord>();
            foreach (RentalRecord record in RentalRecords)
            {
                if (record.RentBeginDate >= from && record.RentBeginDate <=to)
                {
                    records.Add(record);
                }
               
            }
            return records;
        }

        public HashSet<RentalRecord> SearchRentalByCustomer(Customer renter)
        {
            HashSet<RentalRecord> records = new HashSet<RentalRecord>();
            foreach (RentalRecord record in RentalRecords)
            {
                if (record.RentingCustomer == renter)
                {
                    records.Add(record);
                }

            }
            return records;
        }
    }
}
