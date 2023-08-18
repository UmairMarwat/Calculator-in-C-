using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("write first number ");
                num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write 2nd Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("write an option");
            Console.WriteLine("\t +");
            Console.WriteLine("\t -");
            Console.WriteLine("\t *");
            Console.WriteLine("\t /");
            Console.WriteLine("enter an option:");

                switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"result is " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"result is " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"result is " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"result is " + result);
                    break;
                default:
                    Console.WriteLine("inncorrect");
                    Console.Beep();
                    break;
            }

            Console.ReadLine();

        }
    }
}
