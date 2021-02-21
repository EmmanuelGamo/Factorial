using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            long FactN = GetFactorial(number);
            Console.WriteLine("{0} factorial is equal to {1}", number, FactN);
            Console.ReadKey();
        }
        private static long GetFactorial(int number) 
        {
            if (number == 0)
            {
                return 1;
            }           
            int diff = number - 1;
            return number * GetFactorial(diff); // using recursion       
        }
    }
}
