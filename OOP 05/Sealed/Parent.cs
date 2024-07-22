using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05.Sealed
{
    internal class Parent
    {
        private int salary; 

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }
        public virtual void print()
        {
            Console.WriteLine("I am Parent");
        }

    }

    class Child : Parent 
    {
        public override int Salary
        {
            get { return base.Salary; }

            set { base.Salary = value < 5000 ? 5000: value; }
        }
        public sealed override void print()
        {
            Console.WriteLine("I am Child");
        }


    }


    class GrandChild : Child
    {
       // public override int Salary { get => base.Salary; set => base.Salary = value; }


        //public override void print() // invalid
        //{
        //    base.print();
        //}
    }
 
}
