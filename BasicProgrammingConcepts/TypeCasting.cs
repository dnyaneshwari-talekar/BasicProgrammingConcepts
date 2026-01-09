using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    public class TypeCasting
    {
      ImplicitCasting implicitCasting = new ImplicitCasting();
      ExplicitCasting explicitCasting = new ExplicitCasting();
        public void Show()
        {
            implicitCasting.Show();
            explicitCasting.Show();
        }

    }

    public class ImplicitCasting
    {
        public void Show()
        {
            int intValue = 100;
            double doubleValue = intValue; // Implicit casting from int to double
            Console.WriteLine("Implicitly casted int to double: " + doubleValue);
        }
    }

    public class ExplicitCasting
    {
        public void Show()
        {
            double doubleValue = 99.99;
            int intValue = (int)doubleValue; // Explicit casting from double to int
            Console.WriteLine("Explicitly casted double to int: " + intValue);
        }
    }
}
