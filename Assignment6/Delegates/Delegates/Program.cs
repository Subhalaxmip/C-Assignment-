using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            operation obj = new operation(Program.Addition);


            Console.WriteLine("Addition is={0}", obj(23, 27));
            Console.ReadLine();
        }
    }
}
