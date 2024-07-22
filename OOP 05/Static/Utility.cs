using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05.Static
{
    internal  static class Utility
    { 
        static Utility()
        {
            //PI = 3.14;
        }

        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        //objedt member attr
        private readonly static  double pi = 3.14;

        //objedt member Prop

        public static double PI
        {
            get { return pi; }
             
        }


        public static double CalcCircleArea(double R)
        {
            //PI IS OBJECT MEMBER PROPERTY
            //Utility U01 = new Utility(10, 20);
            //Utility U02 = new Utility(10, 20);
            return PI * R * R;
        }




    }


}
