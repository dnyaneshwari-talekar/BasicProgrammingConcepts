using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class ControlStatements
    {
        IfExample ifExample = new IfExample();
        IfElseExample ifElseExample = new IfElseExample();
        IfElseIfExample ifElseIfExample = new IfElseIfExample();
        SwitchExample switchExample = new SwitchExample();
        public void Show()
        {
            Console.WriteLine("If Statement Example:");
            ifExample.CheckEvenOdd();
            Console.WriteLine("\nIf-Else Statement Example:");
            ifElseExample.CheckEvenOdd();
            Console.WriteLine("\nIf-Else If Statement Example:");
            ifElseIfExample.CheckNumber();
            Console.WriteLine("\nSwitch Statement Example:");
            switchExample.PrintDay();
        }
    }
    public class IfExample
    {
        int marks = 35;
        public void CheckEvenOdd()
        {
            if (marks == 35)
            {
                Console.WriteLine("Result is PASS !");
            }
        }
    }
    public class IfElseExample
    {
        int number = 7;
        public void CheckEvenOdd()
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even.");
            }
            else
            {
                Console.WriteLine(number + " is odd.");
            }
        }
    }
    public class IfElseIfExample
    {
        int number = 0;
        public void CheckNumber()
        {
            if (number > 0)
            {
                Console.WriteLine(number + " is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
    public class SwitchExample
    {
        int day = 3;
        public void PrintDay()
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
