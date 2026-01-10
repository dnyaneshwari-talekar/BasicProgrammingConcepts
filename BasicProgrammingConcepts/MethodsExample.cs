using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class MethodsExample
    {
        //void Method
        public void PrintMessage()
        {
            Console.WriteLine("Hello, this is a method without parameters and return type.");
        }

        //Method with parameters
        public void PrintCustomMessage(string message)
        {
            message = "Hello, World!";
            Console.WriteLine(message);
        }

        //Method with return value
        public int Square(int number)
        {
            number = 5;
            return number * number;
        }

        //Method with default parameters
        public void Display(string name, int age = 25)
        {
            Console.WriteLine($"{name} - {age}");
        }

        //Method with variable no. of parameters
        public int Add(params int[] numbers)
        {
            int res = numbers.Sum();
            Console.WriteLine("Result of Addition " + res);

            return res;
        }

    }
}
