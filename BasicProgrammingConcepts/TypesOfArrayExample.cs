using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class TypesOfArrayExample
    {
        OneOrSingleDimensionalArray oneDArray=new OneOrSingleDimensionalArray();
        public void PrintResult()
        {
            oneDArray.Show();
            oneDArray.PrintPrimeNumbers();
            oneDArray.PrintNSizeArray();
        }
    }
    public class OneOrSingleDimensionalArray
    {
        public void Show()
        {
            int[] x = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Maximum of x array" +x.Max());
            Console.WriteLine("Minimum of x array" +x.Min());
            Console.WriteLine("Length of x array" +x.Length);
            Console.WriteLine("Sum of x array" +x.Sum());
            Console.WriteLine("Count of x array" +x.Count());

            Console.WriteLine("One-Dimensional Array Example:");
            //Print all elements in the array
            for (int i = 0; i < x.Length; i++) 
            {
                Console.WriteLine("Array x " +x[i]);                
            }
            //Print even and odd numbers in the array
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                    Console.WriteLine("Even numbers in x array" + x[i]);
                else
                    Console.WriteLine("Odd numbers in x array" + x[i]);
            }
            //Print numbers between 1 and 3 in the array
            for (int i = 0; i < x.Count(); i++)
            {
                if (x[i] < 3 && x[i] > 1)
                    Console.WriteLine("Number between 1 and 3 in x array is : " + x[i]);
            }
            //Find posion of an element in the array
            Console.WriteLine("Find position of an element in the array:");
            Console.WriteLine("Enter element to find its position : ");
            int elementToFind = int.Parse(Console.ReadLine());

            int position = Array.IndexOf(x, elementToFind);
            Console.WriteLine("Position of an array element : " +position);
        }

        public void PrintNSizeArray()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of the array:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                //Read array elements from user
                arr[i] = int.Parse(Console.ReadLine());
                //Print array elements
                Console.WriteLine("Array element at position : "  + i + " is " +arr[i]);
            }

        }

        public void PrintPrimeNumbers() 
        {           
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Prime numbers in the array:");
            foreach(int num in numbers)
            {
                Console.WriteLine("Array number: " + num);
            }
            foreach (int num in numbers)
            {
                bool isPrime = true;
                if(num<=1)
                    isPrime = false;
                for(int i=2; i<=Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine("Prime Numbers : " +num);
            }            
        }
    }
    public class TwoDimensionalArray 
    {
    }
    public class MultiDimensionalArray
    {
    }
    public class JaggedArray
    {
    }
    public class ImplicitlyTypedArray
    {
    }
    public class ArrayOfObjects
    {
    }
}
