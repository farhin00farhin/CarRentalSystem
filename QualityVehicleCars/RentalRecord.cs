using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public class RentalRecord
    {
        Car _rentedCar;
        Customer _rentingCustomer;
        Employee _servedBy;
     
        DateTime _rentBeginDate;
        DateTime _rentEndDate;
        DateTime _carReturnDate; 

        public RentalRecord(Car rentedCar, Customer rentingCustomer, Employee servedBy, DateTime rentBeginDate, DateTime rentEndDate)
         {
            _rentedCar = rentedCar;
            _rentingCustomer = rentingCustomer;
            _servedBy = servedBy;
            _rentBeginDate = rentBeginDate;
            _rentEndDate = rentEndDate; 
        }

        public Car RentedCar
        {
            get
            {
                return _rentedCar;
            }


        }
        public Customer RentingCustomer
        {
            get
            {
                return _rentingCustomer;
            }

        }

        public Employee ServedBy
        {
            get
            {
                return _servedBy;
            }

          
        }

      
        public DateTime RentBeginDate
        {
            get
            {
                return _rentBeginDate;
            }
        }

        public DateTime RentEndDate
        {
            get
            {
                return _rentEndDate;
            }

        }

        public DateTime CarReturnDate
        {
            get
            {
                return _carReturnDate;
            }

            set
            {
                _carReturnDate = value;
            }
        }
    }
}
