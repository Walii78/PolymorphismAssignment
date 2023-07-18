using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable and call the Quit() method
            IQuittable quittableEmployee = new Employee { Name = "John" };
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
