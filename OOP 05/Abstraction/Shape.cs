using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }

        public decimal Dim02 { get; set; }
        // Abstract Method => Not Implemented
        // Must Be Contained Inside Abstract Class

        public abstract decimal CalcArea();

        public abstract decimal Perimeter { get; }
         
    }

    class Rectangle : Shape
        {
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

        public override decimal CalcArea()
            {
                return Dim01 * Dim02;
            }
        }

    class Square : Shape
    {
        public Square(decimal Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        

        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
             
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }


}
