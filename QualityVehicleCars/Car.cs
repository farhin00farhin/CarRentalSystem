using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
     public class Car
    {

        BodyStyle _carBodyStyle;
        CarStatus _currentCarStatus;
        string _colour;
        int _engineNumber;
        DateTime _registrationDueDate;
        DateTime _wofDueDate;
        DateTime _rentStart;
        DateTime _rentEnd;
        string _picturePath;
        public Car(BodyStyle carBodyStyle, CarStatus currentCarStatus, string colour, int engineNumber, DateTime registrationDueDate, DateTime wofDueDate)
        {
            if (engineNumber < 1 || engineNumber > int.MaxValue)
            {
                throw new ArgumentException("Engine number can't be less than 1 or greater than " + int.MaxValue + ".");
            }

            _carBodyStyle = carBodyStyle;
            CurrentCarStatus = currentCarStatus;
            Colour = colour;

            _engineNumber = engineNumber;
            RegistrationDueDate = registrationDueDate;
            WofDueDate = wofDueDate;
        }

        public BodyStyle CarBodyStyle
        {
            get
            {
                return _carBodyStyle;
            }
        }

        public CarStatus CurrentCarStatus
        {
            get
            {
                return _currentCarStatus;
            }
            set
            {
                _currentCarStatus = value;
            }
        }

        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Colour can't be empty.");
                }
                _colour = value;
            }
        }

        public int EngineNumber
        {
            get
            {
                return _engineNumber;
            }
        }
        public DateTime WofDueDate
        {

            get
            {

                if (new DateTime(1753, 01, 01) == _wofDueDate)
                {
                    throw new ArgumentException("The WOF due date has not been set");
                }

                return _wofDueDate;
            }
            set
            {

                if (value >= DateTime.Today)
                {
                    _wofDueDate = value;
                }
                else
                {
                    _wofDueDate = new DateTime(1753, 01, 01);
                    throw new ArgumentException("Invalid WOF due date!");
                }

            }
        }

        public DateTime RegistrationDueDate
        {
            get
            {

                return _registrationDueDate;
            }

            set
            {
                if (value > DateTime.Today)
                {
                    _registrationDueDate = value;
                }
                else
                {
                    _registrationDueDate = new DateTime(1753, 01, 01);
                    throw new ArgumentException("Invalid Registration Due Date!");
                }
            }
        }



        public DateTime RentStart
        {
            get
            {

                if (new DateTime(1753, 01, 01) == _rentStart)
                {
                    Console.WriteLine("The date has not been set");
                }

                return _rentStart;
            }
            set
            {

                if (value >= DateTime.Today)
                {
                    _rentStart = value;
                }
                else
                {
                    _rentStart = new DateTime(1753, 01, 01);
                    throw new ArgumentException("Invalid rent start date!");
                }

            }
        }

        public DateTime RentEnd
        {
            get
            {

                if (new DateTime(1753, 01, 01) == _rentEnd)
                {
                    Console.WriteLine("The date has not been set");
                }

                return _rentEnd;
            }
            set
            {

                if (value > RentStart)
                {

                    _rentEnd = value;

                }
                else
                {
                    _rentEnd = new DateTime(1753, 01, 01);
                    throw new ArgumentException("Invalid rent end date!");
                }

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

        public bool IsRentable()
        {


            if (CurrentCarStatus == CarStatus.OnShop && RentStart != DateTime.MinValue && RentEnd != DateTime.MinValue)
            {
                Console.WriteLine("The car that the customer wants to rent is rentable.");
                return true;
            }
            else
            {
                Console.WriteLine("The car that the customer wants to rent is not rentable.");
                return false;
            }
        }

        public bool WofDueThisMonth()
        {
            if (DateTime.Now.Month == this.WofDueDate.Month && DateTime.Now.Year == this.WofDueDate.Year)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Car))
            {
                return false;
            }
            Car newCar = (Car)obj;
            if (newCar.EngineNumber == this.EngineNumber)
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
            return (_engineNumber).GetHashCode();
        }

        public override string ToString()
        {
            string currentCar = string.Format("\n Body Style: {0}\n Car Status: {1} \n Colour {2}\n Engine Number: {3}\n Registration Due Date: {4}\n WOF Due Date: {5}", CarBodyStyle, CurrentCarStatus, Colour, EngineNumber, RegistrationDueDate, WofDueDate);
            return currentCar;
        }
    }


}
