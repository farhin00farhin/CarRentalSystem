using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 c = new Myclass(3);
            Myclass m = (Myclass) new Class1(89);
            Console.ReadKey();
           // //Creating car yard object
           // CarYard yard = new CarYard();


           // //Creating databse of Cars, passing in all the values necessary for creating a new car object

           // Car car1 = new Car(BodyStyle.Hatchback, CarStatus.OnShop, "Red", 1234, new DateTime(2017, 02, 02), new DateTime(2017, 04, 03));
           // Car car2 = new Car(BodyStyle.Hatchback, CarStatus.OnShop, "Blue", 1556, new DateTime(2017, 06, 02), new DateTime(2017, 06, 03));
           // Car car3 = new Car(BodyStyle.Hatchback, CarStatus.OnShop, "White", 12896, new DateTime(2017, 08, 02), new DateTime(2016, 05, 15));
           // Car car4 = new Car(BodyStyle.SUV, CarStatus.OnShop, "Red", 3654, new DateTime(2017, 01, 02), new DateTime(2017, 04, 03));
           // Car car5 = new Car(BodyStyle.Sedan, CarStatus.OnShop, "Black", 9999, new DateTime(2016, 09, 02), new DateTime(2016, 05, 19));
           // Car car6 = new Car(BodyStyle.Station_Wagon, CarStatus.OnShop, "Silver", 1284, new DateTime(2018, 02, 02), new DateTime(2018, 04, 03));
           // Car car7 = new Car(BodyStyle.Sedan, CarStatus.OnShop, "Yellow", 1464, new DateTime(2016, 10, 02), new DateTime(2016, 12, 03));

           // //Creating car object with invalid values
           // Car car8 = new Car(BodyStyle.Sedan, CarStatus.OnShop, "Green", 1400, new DateTime(2015, 10, 02), new DateTime(2015, 09, 03));

           // //Creating employee objects, passing in all the values necessary for creating a new employee object
           // Employee staff1 = new Employee("Manukau", "12sd12", 234, Role.staff, "sam", "Auckland", new DateTime(1985, 01, 01), 1289, "Sam", 3344556);
           // Employee admin1 = new Employee("Manukau", "12s896", 856, Role.admin, "pam", "Auckland", new DateTime(1989, 01, 01), 1875, "Pam", 3344444);

           // //Creating employee object with invalid values
           // Employee admin2 = new Employee("Manukau", "12", -856, Role.admin, "pam", "Auckland", new DateTime(2089, 01, 01), 1875, "Pam", 99999999999);


           // //Employee adds cars to  different car models
           // staff1.AddCarToNewModel(car1, 6, 4, "Toyota", 1500, 60, "Corolla", 12.99, 2000, yard);
           // staff1.AddCarToExistingModel(car2, "Corolla", "Toyota", yard);
           // staff1.AddCarToExistingModel(car3, "Corolla", "Toyota", yard);
           // staff1.AddCarToNewModel(car4, 8, 6, "Mazda", 1900, 90, "Mazda6", 18.00, 2008, yard);
           // staff1.AddCarToNewModel(car5, 4, 4, "Honda", 1700, 80, "Civic", 8.59, 2008, yard);
           // staff1.AddCarToNewModel(car6, 8, 6, "BMW", 1600, 100, "M3", 14.99, 2008, yard);
           // staff1.AddCarToExistingModel(car7, "Civic", "Honda", yard);

           // //Employee tries to add same car to a car model
           // staff1.AddCarToExistingModel(car4, "Mazda6", "Mazda", yard);


           // //Checking how many car models are there in the car yard and their details
           // Console.WriteLine("\n**************************");
           // Console.WriteLine("Quality Vehicle Cars have {0} car models", yard.Models.Count);
           // int modelNumber = 0;
           // Console.WriteLine("All car model information: ");
           // foreach (CarModel model in yard.Models)
           // {
           //     modelNumber++;
           //     Console.WriteLine(modelNumber + ". {0}:{1}", model.Model, model.Brand + model.ToString());

           // }
           // //Checking how many cars there are in total in the car yeard
           // Console.WriteLine("*****************************************************************************");
           // yard.CountOfAllCars();

           // //Checking how many cars are there in each model and their details
           // foreach (CarModel model in yard.Models)
           // {
           //     Console.WriteLine("\n**************************");
           //     Console.WriteLine("Quality Vehicle Cars have {0} car(s) of {1}:{2} model", model.AllCars.Count, model.Brand, model.Model);
           //     Console.WriteLine("Car Details: ");
           //     int carNumber = 0;
           //     foreach (Car car in model.AllCars)
           //     {
           //         carNumber++;
           //         Console.WriteLine(carNumber + ". " + car.ToString());

           //     }
           // }

           // Console.WriteLine("*****************************************************************************");


           // //Creating a few customer objects, passing in all the values necessary for creating a new customer object 
           // Customer customer1 = new Customer(20, new DateTime(2017, 03, 03), "aa123496", "Auckland", new DateTime(1996, 01, 01), 123, "John", 222333);
           // Customer customer2 = new Customer(22, new DateTime(2018, 04, 03), "bb123458", "Auckland", new DateTime(1994, 01, 01), 123, "Mia", 225833);

           // //Creating customer object with invalid values
           // Customer customer3 = new Customer(2, new DateTime(2000, 04, 03), "bb1234", "Auckland", new DateTime(2094, 01, 01), 123, "Sadia", 100000000000);

           // /*Making a list of cars that the customer picks for renting from all the cars that are available in a car model. 
           // At this point all the cars are available for renting since none of them have been rented yet*/

           // HashSet<Car> carsCustomerWantsToRent = new HashSet<Car>();
           // carsCustomerWantsToRent.Add(yard.Models.ToList()[0].AvailableCars.ToList<Car>()[0]);
           // carsCustomerWantsToRent.Add(yard.Models.ToList()[0].AvailableCars.ToList<Car>()[1]);
           // carsCustomerWantsToRent.Add(yard.Models.ToList()[3].AvailableCars.ToList<Car>()[0]);


           // //Customer rents cars. To rent a car, the customer calls staffs functionality, passes in his/her desired list of cars and the rent start and end dates.

           // customer1.RentCar(staff1, carsCustomerWantsToRent, new DateTime(2016, 07, 01), new DateTime(2016, 07, 25));
           // Console.WriteLine("{0} has rented {1} car(s).", customer1.Name, customer1.RentedCars.Count);


           // // Checking how many cars have been rented by customer1 and their details.
           // int rentedCarNumber = 0;
           // Console.WriteLine("\n**************************");
           // Console.WriteLine("Car Details: ");
           // foreach (Car car in customer1.RentedCars)
           // {
           //     rentedCarNumber++;
           //     Console.WriteLine(rentedCarNumber + ". " + car.ToString());
           // }

           // //Since cars have been rented, there will be a list of rented cars. Checking how many cars have been rented by customers and their details.
           // yard.ListOfAllRentedCars();


           // Console.WriteLine("*****************************************************************************");
           // //Customer tries to rent a car  with invalid rent end date
           // HashSet<Car> carsCustomer2WantsToRent = new HashSet<Car>();
           // carsCustomer2WantsToRent.Add(yard.Models.ToList()[2].AvailableCars.ToList<Car>()[0]);
           // customer2.RentCar(staff1, carsCustomer2WantsToRent, new DateTime(2015, 07, 01), new DateTime(2015, 09, 02));
           // //Since cars have not been rented, there will be an empty list of rented cars. Checking the number of rented cars by customer2.
           // Console.WriteLine("{0} has rented {1} car(s).", customer2.Name, customer2.RentedCars.Count);








           // //Since cars have been rented, the list of available cars will change. Checking how many cars are available and their details.
           // yard.CountOfAllAvailableCars();
           // foreach (CarModel model in yard.Models)
           // {
           //     Console.WriteLine("\n**************************");
           //     Console.WriteLine("Quality Vehicle Cars has {0} available car(s) of {1}:{2} model", model.AvailableCars.Count, model.Brand, model.Model);
           //     Console.WriteLine("Car Details: ");
           //     int availableCarNumber = 0;
           //     foreach (Car car in model.AvailableCars)
           //     {
           //         availableCarNumber++;
           //         Console.WriteLine(availableCarNumber + ". " + car.ToString());
           //     }
           // }

           // //Since cars have been rented, their status will change. Showing car status for all the cars in all the models.
           // Console.WriteLine("\n**************************");

           // foreach (CarModel model in yard.Models)
           // {
           //     Console.WriteLine("\nCar Status: \n{0}:{1}\n", model.Brand, model.Model);

           //     int statusChangeCarNumber = 0;
           //     foreach (Car car in model.AllCars)
           //     {
           //         statusChangeCarNumber++;
           //         Console.WriteLine(statusChangeCarNumber + ". " + car.CurrentCarStatus);
           //     }

           // }
           // Console.WriteLine("Press enter to continue");

           // Console.ReadLine();

           // //Getting weekly rent for 2 cars of each model

           // Console.WriteLine("*****************************************************************************");
           // foreach (CarModel model in yard.Models)
           // {
           //     Console.WriteLine("Weekly rent charge for 2 cars: ");
           //     Console.WriteLine("{0}:{1}  ${2}", model.Brand, model.Model, model.WeeklyRentCharge(2));
           //     Console.WriteLine("\n**************************");
           // }

           // //Checking all the cars in all the models to see if their WOF is due this month

           // //Cars are under the same model name have nothing that distinguishes them except for the engine number. 
           // //It's really hard to identify a particular car by looking at the engine number, so I'm providing a printout 
           // //of all the car details under each model with a very clear line which indicates whether the car has WOF due or not. 

           // //If I only gave a list of cars that have WOF due, it would be very hard for someone to look at the car database and tell which car(s) I'm displaying.
            

           // Console.WriteLine("Displaying if any car has WOF due this month");

           // foreach (CarModel model in yard.Models)
           // {
           //     Console.WriteLine("{0}: {1}", model.Brand, model.Model);
           //     Console.WriteLine("\nCar details:");

           //     int carNumber = 0;
           //     foreach (Car car in model.AllCars)
           //     {
           //         carNumber++;
           //         if (car.WofDueThisMonth() == true)
           //         {
           //             Console.WriteLine(carNumber + ". " + car.ToString() + "\n\n-----------WOF due this month\n");
           //         }
           //         else
           //         {

           //             Console.WriteLine(carNumber + ". " + car.ToString() + "\n\n-----------WOF not due this month\n");

           //         }
           //     }
           // }



           // //Customer returns a car. To return a car, the customer calls staffs functionality and passes the list of cars he had rented.
           // Console.WriteLine("*****************************************************************************");
           // Console.WriteLine("Customer {0} has {1} car(s) to return.", customer1.Name, customer1.RentedCars.Count);
           // Console.WriteLine("Car Details: ");

           // int returnedCarNumber = 0;
           // foreach (Car car in customer1.RentedCars)
           // {
           //     returnedCarNumber++;
           //     Console.WriteLine(returnedCarNumber + ". " + car.ToString());
           //     Console.WriteLine("\n**************************");
           // }

           // customer1.ReturnCar(staff1, new HashSet<Car>(customer1.RentedCars));

           // //Since cars have been returned, the list of all the rented cars will change. Checking how many cars have been rented by customers and their details.
           // yard.ListOfAllRentedCars();

           // //Since all cars have been returned, there will be an empty list of rented cars. Checking the number of rented cars by customer1.

           // Console.WriteLine("\n**************************");
           // Console.WriteLine("Customer {0} has rented {1} car(s).", customer1.Name, customer1.RentedCars.Count);




           // Console.WriteLine("*****************************************************************************");
           // //Customer tries to return car that's not in his rented cars list
           // //Before, customer2 was trying to rent a car with invalid rent end date. With valid dates the car will be rented to customer 2. 
           // customer2.RentCar(staff1, carsCustomer2WantsToRent, new DateTime(2017, 07, 01), new DateTime(2017, 07, 02));
           // Console.WriteLine("Customer {0} has rented {1} car(s).", customer2.Name, customer2.RentedCars.Count);


           // Console.WriteLine("*****************************************************************************");
           // Console.WriteLine("Customer {0} wants to return {1} car(s).", customer1.Name, customer2.RentedCars.Count);
           // Console.WriteLine("Car Details: ");

           // int returned2CarNumber = 0;
           // foreach (Car car in customer2.RentedCars)
           // {
           //     returned2CarNumber++;
           //     Console.WriteLine(returned2CarNumber + ". " + car.ToString());
           //     Console.WriteLine("\n**************************");
           // }

           // customer1.ReturnCar(staff1, new HashSet<Car>(customer2.RentedCars));





           // //Since cars have been returned, their status will change. Showing car status for all the cars in all the models.

           // Console.WriteLine("\n**************************");

           // foreach (CarModel model in yard.Models)
           // {
           //     int statusChangeReturnedCarNumber = 0;
           //     Console.WriteLine("\nCar Status: \n{0}:{1}\n", model.Brand, model.Model);

           //     foreach (Car car in model.AllCars)
           //     {
           //         statusChangeReturnedCarNumber++;
           //         Console.WriteLine(statusChangeReturnedCarNumber + ". " + car.CurrentCarStatus);
           //     }

           // }




           // //Employee searches a car by model name
           // Console.WriteLine("*****************************************************************************");
           // int modelSearchCarNumber = 0;
           // string modelNameSearchTerm = "Corolla";
           // Console.WriteLine("Searching with model name: " + modelNameSearchTerm);

           // Console.WriteLine("Found {0} car(s)", staff1.SearchBrandName("Corolla", yard).Count);
           // Console.WriteLine("Car details");
           // foreach (Car car in staff1.SearchBrandName("Corolla", yard))
           // {
           //     modelSearchCarNumber++;
           //     Console.WriteLine(modelSearchCarNumber + ". " + car.ToString());
           // }


           // //Employee searches a car by price
           // Console.WriteLine("*****************************************************************************");
           // int priceSearchCarNumber = 0;
           // double priceSearch = 18.00;
           // Console.WriteLine("Searching with price: $" + priceSearch);

           // Console.WriteLine("Found {0} car(s)", staff1.SearchPrice(18.00, yard).Count);
           // Console.WriteLine("Car details");
           // foreach (Car car in staff1.SearchPrice(18.00, yard))
           // {
           //     priceSearchCarNumber++;
           //     Console.WriteLine(priceSearchCarNumber + ". " + car.ToString());
           // }


           // //Employee searches a car by price range
           // Console.WriteLine("*****************************************************************************");
           // int priceRangeSearchCarNumber = 0;
           // double priceRangeSearchFrom = 1.00;
           // double priceRangeSearchTo = 15.00;

           // Console.WriteLine("Searching for car between price range of ${0}-${1}: ", priceRangeSearchFrom, priceRangeSearchTo);

           // Console.WriteLine("Found {0} car(s)", staff1.SearchPriceRange(1.00, 15.00, yard).Count);
           // Console.WriteLine("Car details");
           // foreach (Car car in staff1.SearchPriceRange(1.00, 15.00, yard))
           // {
           //     priceRangeSearchCarNumber++;
           //     Console.WriteLine(priceRangeSearchCarNumber + ". " + car.ToString());
           // }


           // /*The updated assignment requirements excluded this part.
           // Checking if any car is overdue to return

           //   customer1.RentCar(staff1, carsCustomerWantsToRent, new DateTime(2015, 07, 01), new DateTime(2015, 07, 31)); //Rent start and end dates are set in the past to test overdue cars
           //Console.WriteLine("\n**************************");
           //Console.WriteLine("{0} has rented {1} car(s).", customer1.Name, customer1.RentedCars.Count);

           //int overdueCarNumber = 0;
           //Console.WriteLine("*****************************************************************************");
           //Console.WriteLine("Customer {0} has {1} car(s) overdue to return.", customer1.Name, customer1.OverdueRentedCars().Count);
           //Console.WriteLine("Car Details: ");
           //foreach (Car car in customer1.OverdueRentedCars())
           //{
           //    overdueCarNumber++;
           //    Console.WriteLine(overdueCarNumber + ". " + car.ToString());

           //}*/



           // Console.ReadKey();
        }
    }
}
