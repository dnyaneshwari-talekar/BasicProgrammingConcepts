using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class Operators
    {
        ArithmeticOperators arithmeticOperators = new ArithmeticOperators();
        ComparisonOperators comparisonOperators = new ComparisonOperators();
        LogicalOperators logicalOperators = new LogicalOperators();
        public void Show()
        {
            Console.WriteLine("Arithmetic Operators:");
            arithmeticOperators.Show();
            Console.WriteLine("Comparison Operators:");
            comparisonOperators.Show();
            Console.WriteLine("Logical Operators:");
            logicalOperators.Show();
        }
    }
    public class ArithmeticOperators
    {
        int a = 10;
        int b = 5;
        public void Show()
        {            
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
        }
    }
    public class ComparisonOperators
    {
        int a = 10;
        int b = 5;
        public void Show()
        {
            Console.WriteLine("Equal to: " + (a == b));
            Console.WriteLine("Not equal to: " + (a != b));
            Console.WriteLine("Greater than: " + (a > b));
            Console.WriteLine("Less than: " + (a < b));
            Console.WriteLine("Greater than or equal to: " + (a >= b));
            Console.WriteLine("Less than or equal to: " + (a <= b));
        }
    }
    public class LogicalOperators
    {
        bool x = true;
        bool y = false;
        public void Show()
        {
            Console.WriteLine("Logical AND: " + (x && y));
            Console.WriteLine("Logical OR: " + (x || y));
            Console.WriteLine("Logical NOT: " + (!x));
        }
    }
}
