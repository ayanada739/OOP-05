 
using OOP_05.Operator_Overloading;
using OOP_05.Partial;
using OOP_05.Static;
using System.Drawing;
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

            #region Casting Operator Overloading - Mapping
            //// View EmployeeViewModel Employee [Model] ==> Database
            //// Database ==> Employee =>EmployeeViewModel==> View

            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    FullName = "Aliaa Tarek",
            //    Password = "password",
            //    Email = "AliaaTarek42@Gmail.com",
            //    SecurityStamp = Guid.NewGuid()
            //};

            ////EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            ////employeeViewModel = (EmployeeViewModel)employee;

            ////Console.WriteLine(employeeViewModel.FirstName);
            ////Console.WriteLine(employeeViewModel.LastName);

            //object obj = new EmployeeViewModel();
            //EmployeeViewModel E = (EmployeeViewModel)obj; 
            #endregion

            #region Abstraction


            //Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 20 };

            //decimal RecArea = rectangle.CalcArea();
            //Console.WriteLine($"Area Of rectangle = {RecArea}");

            //Console.WriteLine($"Perimeter of rectangle = {rectangle.Perimeter}");
            #endregion

            #region Static

            //Utility U01 = new Utility(10, 20);
            //Console.WriteLine($"Cm to Inch = {U01.CmToInch(254)}"); //100


            //Utility U02 = new Utility(100, 200);
            //Console.WriteLine($"Cm to Inch = {U02.CmToInch(254)}"); //100

            //Console.WriteLine(U01.CalcCircleArea(10)); //314
            //Console.WriteLine(U02.CalcCircleArea(10)); //314


            //Console.WriteLine($"Area of Circle = {Utility.CalcCircleArea(10)}");
            //Utility utility = new Utility();//INVALID


            #endregion

            #region Parial
            Employee employee
                 = new Employee();
            employee.Id = 10;
            employee.Name = "Aliaa";
            employee.Age = 30;
            employee.Salary = 50000;

            employee.test = 10;
            employee.print();

            employee.Hamada();
            #endregion




        }
    }
}
