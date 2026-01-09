using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VariablesAndDataTypes obj = new VariablesAndDataTypes();
            obj.PrintVariables();

            ValueType valueTypeObj = new ValueType();
            valueTypeObj.Show();

            ReferenceType refTypeObj = new ReferenceType();
            refTypeObj.Show();

            TypeCasting typeCastingObj = new TypeCasting();
            typeCastingObj.Show();

            Operators operatorsObj = new Operators();
            operatorsObj.Show();

            ControlStatements controlStatements = new ControlStatements();
            controlStatements.Show();

            LoopsExample loopsExample = new LoopsExample();
            loopsExample.Show();

            TypesOfArrayExample typesOfArrayExample = new TypesOfArrayExample();
            typesOfArrayExample.PrintResult();
        }
    }
}
