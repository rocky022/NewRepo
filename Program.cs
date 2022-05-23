using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Math math = new Math();
            Console.WriteLine("Add result is"+math.Add(2,3));
            Console.ReadLine();
        }
    }
}
