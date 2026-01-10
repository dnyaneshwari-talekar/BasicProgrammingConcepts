using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class EncapsulationExample
    {
        Employee emp = new Employee();
        public void show()
        {
            emp.SetSalary(5000);
            Console.WriteLine(emp.GetSalary());
        }
    }

    public class Employee
    {
        // private data (data hiding)
        private int salary;

        // public method to set value
        public void SetSalary(int amount)
        {
            if (amount > 0)
            {
                salary = amount;
            }
        }

        // public method to get value
        public int GetSalary()
        {
            return salary;
        }
    }

}
