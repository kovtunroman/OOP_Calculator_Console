using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Calculator_Console.CalculatorFactory;
using OOP_Calculator_Console.CalculatorFactory.OperatorsFactories;

namespace OOP_Calculator_Console
{
    static class Menu
    {
        public static void Showmenu()
        {

            Console.WriteLine("=================================");
            Console.WriteLine("Simple Factory Calculator");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Devide");
            Console.WriteLine("5.Exit");
            Console.WriteLine("=================================");
        }

        public static double ReciveOperands(string operandName)
        {
            double operand = 0;
            Console.Write($"Enter operand {operandName}: ");
            try
            {
                operand = double.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine("Wrong Data Type");
                operand = ReciveOperands(operandName);
            }

            return operand;
        }

        public static double Add()
        {
            double operand1 = ReciveOperands("Operand1");
            double operand2 = ReciveOperands("Operand2");
            OperatorsFactory addFactory = new AddFactory();
            Operator addOperator = addFactory.Create();
            return addOperator.Calculate(operand1, operand2);
        }

        public static double Substruct()
        {
            double operand1 = ReciveOperands("Operand1");
            double operand2 = ReciveOperands("Operand2");
            OperatorsFactory minusFactory = new MinusFactory();
            Operator addOperator = minusFactory.Create();
            return addOperator.Calculate(operand1, operand2);
        }

        public static double Multiply()
        {
            double operand1 = ReciveOperands("Operand1");
            double operand2 = ReciveOperands("Operand2");
            OperatorsFactory multiplyFactory = new MultiplyFactory();
            Operator multiplyOperator = multiplyFactory.Create();
            return multiplyOperator.Calculate(operand1, operand2);
        }

        public static double Devide()
        {
            double operand1 = ReciveOperands("Operand1");
            double operand2 = ReciveOperands("Operand2");
            OperatorsFactory devideFactory = new DevideFactory();
            Operator devideOperator = devideFactory.Create();
            return devideOperator.Calculate(operand1, operand2);
        }
        public static void Select()
        {

            int yes = 0;
            int choise = 0;
            Showmenu();

            try
            {
                while (yes == 0)
                {
                    double result;
                    Console.Clear();
                    Showmenu();
                    Console.Write("Enter your choice: ");
                    choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {

                        case 1:
                            result = Add();
                            Console.WriteLine($"The rusult of Add operation is: {result}");
                            break;

                        case 2:
                            result = Substruct();
                            Console.WriteLine($"The rusult of Subtraction operation is: {result}");
                            break;

                        case 3:
                            result = Multiply();
                            Console.WriteLine($"The rusult of Multiplication operation is: {result}");
                            break;

                        case 4:
                            result = Devide();
                            Console.WriteLine($"The rusult of Division operation is: {result}");
                            break;
                            
                        case 5: Environment.Exit(0); break;

                        default: Console.WriteLine("Invalid choice!"); break;

                    }


                    Console.Write("\nContinue? Press 0 to continue:");
                    yes = int.Parse(Console.ReadLine());

                }

            }
            catch (Exception e) { }

        }
    }
}
