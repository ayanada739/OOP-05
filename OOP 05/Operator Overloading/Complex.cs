using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05.Operator_Overloading
{
    internal class Complex
    {

        public int Real { get; set; }
        public int Imag { get; set; }


        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }


        #region Operators Overloading
        // +
        // Non — Private , Class member Method


        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {

                Real =(Left?.Real ?? 0) + Right?.Real ?? 0,
                Imag =(Left?.Imag ?? 0) + Right?.Imag ?? 0
            };
        }


        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {

                Real = (Left?.Real ?? 0) - Right?.Real ?? 0,
                Imag = (Left?.Imag ?? 0) - Right?.Imag ?? 0
            };
        }


        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {

                Real = (C?.Real ?? 0) + 1,
                Imag = C?.Imag ?? 0  
            };
        }

        public static Complex operator --(Complex C)
        {
            return new Complex()
            {

                Real = (C?.Real ?? 0) + 1,
                Imag = C?.Imag ?? 0
            };
        }



        public static bool operator > (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag > Right.Imag;
            else
                return Left.Real > Right.Real;
        }



        public static bool operator < (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return Left.Real < Right.Real;
        }


        #endregion


        #region Casting Operator Overloading
        //(int)

        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }


        //string

        public static /*string*/ implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty; 
        }
        #endregion



    }
}
