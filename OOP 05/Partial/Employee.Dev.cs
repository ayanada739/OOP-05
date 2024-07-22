using OOP_05.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05.Partial
{
    internal partial class Employee
    {
        public void print()
        {
            Console.WriteLine(" I Am Employee ");
        }

        public int test { get; set; }

        public partial void Hamada()
        {
            throw new NotImplementedException();
        }
    }
}
