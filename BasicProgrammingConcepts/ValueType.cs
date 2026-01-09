using System;

namespace BasicProgrammingConcepts
{
    public class ValueType
    {
        int num1 = 10;
        int num2;

        public void Show()
        {
            Console.WriteLine("Value of num1:" + num1);
            num2 = num1; // num2 now holds a copy of num1's value
            Console.WriteLine("Before changing num2:" + num2);
            num2 = 20;   // Changing num2 does not affect num1
            Console.WriteLine("After changing num2:" + num2);
        }
    }
    public class ReferenceType
    {
        public int num;

        public void Show() 
        {

            ReferenceType refTypeObj1 = new ReferenceType();
            refTypeObj1.num = 30;
            Console.WriteLine("Value in refTypeObj1: " + refTypeObj1.num);

            ReferenceType refTypeObj2 = refTypeObj1;
            refTypeObj2.num = 40;
            Console.WriteLine("Value in refTypeObj2:" + refTypeObj2.num);
        }
    }
}