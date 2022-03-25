using System;
using System.Linq;

namespace CalculatorGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int output = 0;
            while (input != "END")
            {
                string[] commandArgs = input.Split();
                switch (commandArgs[0])
                {
                    case "+":
                        output = Add(commandArgs.Skip(1).ToArray());

                        break;
                    case "-":
                        output = Sub(commandArgs.Skip(1).ToArray());
                        break;
                    case "*":
                        output = Mult(commandArgs.Skip(1).ToArray());
                        break;
                    case "/":
                        output = Div(commandArgs.Skip(1).ToArray());
                        break;
                    case "POW":
                        output = Pow(commandArgs.Skip(1).ToArray());
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
                Console.WriteLine(output);
            }
        }
        private static int Pow(string[] vs)
        {
            int Num1 = int.Parse(vs[0]);
            int Num2 = int.Parse(vs[1]);
            return Math.Pow(Num1, Num2);
        }

        private static int Div(string[] vs)
        {
            int Num1 = int.Parse(vs[0]);
            int Num2 = int.Parse(vs[1]);
            return Num1 / Num2;
        }

        private static int Mult(string[] vs)
        {
            int Num1 = int.Parse(vs[0]);
            int Num2 = int.Parse(vs[1]);
            return Num1 * Num2;
        }

        private static int Sub(string[] vs)
        {
            int Num1 = int.Parse(vs[0]);
            int Num2 = int.Parse(vs[1]);
            return Num1 - Num2;
        }

        private static int Add(string[] vs)
        {
            int Num1 = int.Parse(vs[0]);
            int Num2 = int.Parse(vs[1]);
            return Num1 + Num2;
        }
    }
}
