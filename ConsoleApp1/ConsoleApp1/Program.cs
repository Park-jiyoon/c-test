using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            
            Console.WriteLine(calculate.add(1, 2));
            Console.WriteLine(calculate.minus(2, 1));
        }
    }
}
