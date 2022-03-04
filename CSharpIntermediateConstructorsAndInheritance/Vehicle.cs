using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initlialized.");
        }




        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }



    }
}
