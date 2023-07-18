using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Inherit the interface in the Employee class and implement the Quit() method
    class Employee : IQuittable
    {
        public string Name { get; set; }

        public void Quit()
        {
            Console.WriteLine("Employee {0} is quitting...", Name);
        }
    }
}
