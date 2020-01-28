using OOP_Calculator_Console.CalculatorFactory.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory.OperatorsFactories
{
    class MultiplyFactory: OperatorsFactory
    {
        public MultiplyFactory()
        {

        }

        public override Operator Create()
        {
            return new MultiplyOperator();
        }
    }
}
