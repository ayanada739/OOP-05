using OOP_05.Operator_Overloading;
using System.Threading.Channels;

namespace OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading


            //Complex C1 = new Complex() { Real = 3, Imag = 5 };
            //Console.WriteLine($"C1 = { C1}"); //3+5i

            //Complex C2 = new Complex() { Real = 2, Imag = 4 };   
            //Console.WriteLine($"C2 = {C2}"); //2+4i

            //Complex C3 = default;

            #region Binary Operators Overloading
            //////Complex C3 = C1 + C2; // Invalid
            //////Console.WriteLine("===============");
            //////Console.WriteLine(C3); // 5 + 9i

            ////Complex C3 = C1 - C2;  
            ////Console.WriteLine(C3); 

            //Complex C3 = default;
            //C3 += C1; //C3 = NULL + C1
            //Console.WriteLine(C3);
            //C3 -= C1;//C3 = C3 - C1 
            #endregion

            #region Unary Operators Overloading

            ////C3 = ++C1; // Prefix
            ////C3 = C1++; // Postfix

            //Console.WriteLine("============");
            //Console.WriteLine($"C3 = {C3}");

            //C3 = --C1;
            //C3 = C1--;
            //Console.WriteLine("============");
            //Console.WriteLine($"C3 = {C3}");
            //Console.WriteLine($"C1 = {C1}"); // 3 + 5i

            #endregion

            #region Relational Operators Overloading

            //if (C1 > C2)
            //    Console.WriteLine("C1 Is Greater Than C2");
            //else if (C2 > C1)
            //    Console.WriteLine("C2 Is Greater Than C1") ;

            #endregion
            #endregion

            #region Casting Operators Overloading

            ////object obj = 2; // Boxing
            //// int X = (int) obj; // Explicit Casting
            //// (int) Casting Operator

            //Complex C1 = new Complex() { Real = 2, Imag = 4 };

            //string S1 =(string) C1;
            //S1 = (string)C1; //Recommended [explicitly]

            //// int Y = (int)C1; //Invaid
            ////                 // Explicit Casting
            ////                // (int) 

            //// Console.WriteLine(C1);
            //// Console.WriteLine(Y);



            #endregion


        }
    }
}
