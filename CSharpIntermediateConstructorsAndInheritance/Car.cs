using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConstructorsAndInheritance
{
    public class Car : Vehicle //Car class is derived from the Vehical class, in other words it will behave like an Vehicale, contaings of its properties and methods and will be able to call the methods of the Animal class.
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized.");
        }
    }
}
