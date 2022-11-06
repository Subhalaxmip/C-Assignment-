using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Cal
    {
        static void Main(string[] args)
        {
            do
            {
                double a = 0;
                double b = 0;
                double c = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.WriteLine("Enter first input");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second input");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter a option");
                Console.WriteLine("\nselect 1 for addition");
                Console.WriteLine("select 2 for subtraction");
                Console.WriteLine("select 3 for multiplication");
                Console.WriteLine("select 4 for division");

                switch (Console.ReadLine())
                {
                    case "1":
                        c = a + b;
                        Console.WriteLine($"the result: {a} + {b} =" + c);
                        break;
                    case "2":
                        c = a - b;
                        Console.WriteLine($"the result: {a} - {b} =" + c);
                        break;
                    case "3":
                        c = a * b;
                        Console.WriteLine($"the result: {a} * {b} =" + c);
                        break;
                    case "4":
                        c = a / b;
                        Console.WriteLine($"the result: {a} / {b} =" + c);
                        break;
                    default:
                        Console.WriteLine($"invalid");
                        break;

                }
                Console.WriteLine("would u like to continue?? (Y=yes N=no)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
