using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problems");
            Console.ReadLine();

            LineComparison line = new LineComparison();
            line.length_line();
            line.check_equality();

        }
    }
}