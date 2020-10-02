using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LargeNumber;
namespace Multiplication
{
   
    class Program
    {
        static void Main(string[] args)
        {
            BigInt big;
            BigInt lit;
            BigInt Composit;
            big = Console.ReadLine();
            lit = Console.ReadLine();
            Composit = big * lit;
            Composit.Print();
            Console.ReadKey();
            
        }
    }
}
