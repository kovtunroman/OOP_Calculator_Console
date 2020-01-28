using OOP_Calculator_Console.CalculatorFactory.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory.OperatorsFactories
{
    class MinusFactory: OperatorsFactory
    {
        public MinusFactory()
        {

        }

        public override Operator Create()
        {
            return new MinusOperator();
        }
    }
}
