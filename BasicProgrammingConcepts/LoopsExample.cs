using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class LoopsExample
    {
        ForLoopExample forLoopExample = new ForLoopExample();
        WhileLoopExample whileLoopExample = new WhileLoopExample();
        DoWhileLoopExample doWhileLoopExample = new DoWhileLoopExample();
        ForeachLoopExample foreachLoopExample = new ForeachLoopExample();
        public void Show()
        {
            forLoopExample.Show();
            whileLoopExample.Show();
            doWhileLoopExample.Show();
            foreachLoopExample.Show();
        }
    }
    public class ForLoopExample
    {
        public void Show()
        {
            Console.WriteLine("For Loop Example: print 1 to 5");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Value of i : " + i);
            }
        }
    }

    public class WhileLoopExample
    {
        public void Show()
        {
            Console.WriteLine("While Loop Example:print 1 to 3");
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("Value of i : " + i);
                i++;
            }
        }
    }

    public class DoWhileLoopExample
    {
        public void Show()
        {
            Console.WriteLine("Do-While Loop Example: print 1 to 7");
            int i = 1;
            do
            {
                Console.WriteLine("Value of i : " + i);
                i++;
            } while (i <= 7);
        }
    }

    public class ForeachLoopExample
    {
        public void Show()
        {
            Console.WriteLine("Foreach Loop Example:");
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}
