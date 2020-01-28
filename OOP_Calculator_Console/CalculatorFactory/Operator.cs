using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory
{
    abstract class Operator
    {
        abstract public double Calculate(double number1, double number2);
    }
}
