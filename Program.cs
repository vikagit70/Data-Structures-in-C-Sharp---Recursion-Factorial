using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        
        static void Factorial ( int n, int multi)
        {
            if(n < 0)
            {
                return;
            }
            else if (n == 0)
            {
                Console.Write("Result: 1");
            }
            else if (n != 1)
            {
                multi = multi * n;
                Factorial((n - 1), multi);
            }
            else
            {
                Console.Write("Result: ");
                Console.WriteLine(multi);
            }
        }
        static void Main(string[] args)
        {
            int multi1 = 1;
            Console.WriteLine("Input any positive number: ");
            int userInput = Int32.Parse(Console.ReadLine());
            Factorial(userInput, multi1);
            Console.WriteLine("The End");
        }
    }
}
