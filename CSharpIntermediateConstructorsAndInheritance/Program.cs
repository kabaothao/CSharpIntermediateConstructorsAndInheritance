// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateConstructorsAndInheritance // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ1234");
        }
    }
}


/*
 There are two things you need to know about constructors when it comes to inheritance.

First is that during the instantiation of an object the base class constructors are always executed

first and the second is base class constructors are not inherited.

So in a derived class you need to redefine your constructors.

 
 */