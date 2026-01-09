using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class VariablesAndDataTypes
    {
        int age = 25;
        double salary = 45000.50;
        char grade = 'A';
        bool isActive = true;
        string name = "Amit";

        public void PrintVariables()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Is Active: " + isActive);
        }
    }
}
