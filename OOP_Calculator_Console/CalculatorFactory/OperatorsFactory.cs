using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator_Console.CalculatorFactory
{
    abstract class OperatorsFactory
    {
        public OperatorsFactory()
        {

        }

        abstract public Operator Create();
    }
}
