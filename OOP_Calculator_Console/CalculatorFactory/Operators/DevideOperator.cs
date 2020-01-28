using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory.Operators
{
    class DevideOperator: Operator
    {
        public DevideOperator()
        {

        }

        public override double Calculate(double number1, double number2)
        {
            double result = 0;

            try
            {
                result = number1 / number2;
            } catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exeption caught: {e}");
            }

            return result;
        }
    }
}
