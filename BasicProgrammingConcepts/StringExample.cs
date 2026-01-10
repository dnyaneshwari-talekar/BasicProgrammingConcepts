using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class StringExample
    {
        public void PrintString()
        {
            StringBuilder sb = new StringBuilder("String example ");
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            sb.Insert(5, ",");
            sb.Replace("World", "C#");
            sb.Remove(5, 1);

            Console.WriteLine(sb.ToString());

            Console.WriteLine(sb);

            string text = "DotNet Developer";

            Console.WriteLine("Length of string " + text.Length);          
            Console.WriteLine("Uppercase string " + text.ToUpper());        
            Console.WriteLine("Lowercase string " + text.ToLower());        
            Console.WriteLine("Is string contains Net " + text.Contains("Net"));  
            Console.WriteLine("Substring from 0-5 " + text.Substring(0, 6)); 

        }
    }
}
