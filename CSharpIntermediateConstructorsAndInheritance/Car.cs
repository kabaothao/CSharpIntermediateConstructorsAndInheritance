using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConstructorsAndInheritance
{
    public class Car : Vehicle //Car class is derived from the Vehical class, in other words it will behave like an Vehicale, contaings of its properties and methods and will be able to call the methods of the Animal class.
    {
        public Car(string registrationNumber)
            :base(registrationNumber) //A better way is to receive a parameter called registration number in the car class's constructor. So here string registration number and whatever we receive here we simply pass it to the base class
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}


/*
line 12 

So all we need to do here is when declaring the constructor for the car class before opening the body

of the method here we up and colon base and here base is simply a way to access the base class.

The syntax simply represents a method call.

Imagine you're calling a method called base.

And here you're passing an argument to that method.

Basically what's happening here is when we create an object of type car the runtime first tries to create

an object of type vehicle but because the vehicle type does not have a default or prominences constructor

the runtime doesn't know how to create an object of type recall.

So what we need to do here is back to the core class we use the base keyword to call one of the constructors

of the vehicle class and how we do it is very simple.

Enter Colon.

We use the base keyword open brackets.

And here we go.



 */