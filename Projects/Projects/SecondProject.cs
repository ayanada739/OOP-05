﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Projects
{
    public class SecondProject
    {

        public static class Maths
        {
            public static int Add(int a, int b) => a + b;
            public static int Subtract(int a, int b) => a - b;
            public static int Multiply(int a, int b) => a * b;
            public static double Divide(int a, int b) => b == 0 ? double.NaN : (double)a / b;
        }



    }
}
