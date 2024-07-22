using static Assignment.Projects.FirstProject;
using static Assignment.Projects.SecondProject;
using static Assignment.Projects.ThirdProject;

namespace Projects
{
    public class Program
    {
        public static void Main(string[] args)
        {


            #region First Project  Point3D Class

            //try
            //{
            //    Console.Write("Enter coordinates for P1 (x y z): ");
            //    string[] input1 = Console.ReadLine().Split();
            //    int x1 = int.Parse(input1[0]);
            //    int y1 = int.Parse(input1[1]);
            //    int z1 = int.Parse(input1[2]);

            //    Console.Write("Enter coordinates for P2 (x y z): ");
            //    string[] input2 = Console.ReadLine().Split();
            //    int x2 = int.Parse(input2[0]);
            //    int y2 = int.Parse(input2[1]);
            //    int z2 = int.Parse(input2[2]);

            //    Point3D P1 = new Point3D(x1, y1, z1);
            //    Point3D P2 = new Point3D(x2, y2, z2);


            //    Console.WriteLine(P1.ToString());
            //    Console.WriteLine(P2.ToString());

            //    if (P1 == P2)
            //    {
            //        Console.WriteLine("P1 and P2 are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("P1 and P2 are not equal.");
            //    }

            //    Point3D[] points = { P1, P2, new Point3D(5, 5, 5), new Point3D(1, 2, 3) };
            //    Array.Sort(points);

            //    Console.WriteLine("Sorted points:");
            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point.ToString());
            //    }

            //    Point3D P1Clone = (Point3D)P1.Clone();
            //    Console.WriteLine("P1 Clone: " + P1Clone.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid input: " + ex.Message);
            //}

            #endregion

            #region Second Project Maths


            //int a = 10;
            //int b = 2;

            //Console.WriteLine($"Add: {Maths.Add(a, b)}");
            //Console.WriteLine($"Subtract: {Maths.Subtract(a, b)}");
            //Console.WriteLine($"Multiply: {Maths.Multiply(a, b)}");
            //Console.WriteLine($"Divide: {Maths.Divide(a, b)}");

            #endregion

            #region Third Project Duration

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString());

            //D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString());

            //D3 = 666 + D3;
            //Console.WriteLine(D3.ToString());

            //D3 = ++D1;
            //Console.WriteLine(D3.ToString());

            //D3 = --D2;
            //Console.WriteLine(D3.ToString());

            //D1 = D1 - D2;
            //Console.WriteLine(D1.ToString());

            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 is greater than D2");
            //}
            //else if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 is less than or equal to D2");
            //}

            //DateTime dt = (DateTime)D1;
            //Console.WriteLine("DateTime: " + dt.ToString());


            #endregion



        }
    }
}
