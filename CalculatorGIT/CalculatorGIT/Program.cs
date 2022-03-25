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
            }
        }
    }
}
