using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    [Serializable]
    public abstract class Person
    {
        protected string _address;
        protected DateTime _dateOfBirth;
        protected int _id; 
        protected string _name;
        protected long _telephoneNo; 

        protected Person( string address, DateTime dateOfBirth, int id, string name, long telephoneNo)
        {
            if (id < 0 || id >99999999)
            {
                throw new ArgumentException("Invalid ID number!");
                
            }
            Address = address;
            DateOfBirth = dateOfBirth;
            _id = id;
            Name = name;
            TelephoneNo = telephoneNo;
        }

        public string Address
        {
            get
            {
               
                return _address;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You entered an empty address!");
                }
                _address = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                if (value < DateTime.Now.AddYears (- 15))
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("You entered an invalid date of birth. You need to at least 16 years old.");
                }

            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You entered an empty Name!");
                }
                _name = value;
            }
        }

        public long TelephoneNo
        {
            get
            {
               
                return _telephoneNo;
            }

            set
            {
                
                if (value > 0 && value< 999999999)
                {
                    _telephoneNo = value;
                }
                else
                {
                    throw new ArgumentException("You entered an invalid telephone no!");
                }

            }
        }

       

    }
}
