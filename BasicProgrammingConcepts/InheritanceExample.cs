using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    //Single Inheritance
    public class InheritanceExample
    {
        public void MyData()
        {
            Console.WriteLine("I'm Dnyaneshwari T");
        }
    }

    class MyDerivedClass : InheritanceExample
    {
        public void Show()
        {
            Console.WriteLine("I love programming..");
        }
    }
   
    //Multilevel Inheritance
    class A
    {
        public void MethodA()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : A
    {
        public void MethodB()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : B
    {
        public void MethodC()
        {
            Console.WriteLine("Class C");
        }
    }

    //Hierarchical Inheritance
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }

    class Bike : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Bike is riding");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }


}
