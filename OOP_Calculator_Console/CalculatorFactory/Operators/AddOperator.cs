using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory.Operators
{
    class AddOperator: Operator
    {
        public AddOperator()
        {

        }
        public override double Calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
