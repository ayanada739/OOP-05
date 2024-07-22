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
        public int Id { get; set; }
        public String?   Name { get; set; }

        public decimal Salary { get; set; }
        public int Age { get; set; }


        public partial void Hamada();


    }
}
