using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    interface InterfacesExample
    {
        void ShowData();
    }   
    public class MyClass : InterfacesExample
    {
        public void ShowData()
        {
            Console.WriteLine("Hello, Dnyaneshwari!");
        }
    }
}
