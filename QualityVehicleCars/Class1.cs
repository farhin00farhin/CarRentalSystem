using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityVehicleCars
{
    public class Class1
    {
        public Class1(int tid)
        {

        }

        public virtual void M1()
        {
            Console.WriteLine("Class1.M1");
        }
    }

    public interface I1
    {
        void M1();
    }

    public interface I2 : I1, I3
    {

    }

    public interface I3
    {

    }

    public class MyClass2 : I1
    {
        public void M1()
        {
            Myclass m = new Myclass(5);

        }

    }

    internal class Myclass : Class1
    {
        public Myclass(int id) : base(id)
        {

        }

        public void M1()
        {
            Console.WriteLine("Myclass.m1");
        }

        protected int asdf
        {
            private get
            {
                return 0;
            }
            set
            {
            }

        }

    }
}