﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory.Operators
{
    class MultiplyOperator: Operator
    {
        public MultiplyOperator()
        {

        }

        public override double Calculate(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
