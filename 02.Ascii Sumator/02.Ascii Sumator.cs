using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace programs
{
    internal class Program
    {


        static void Main(string[] args)
        {

            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int sum = 0;

            foreach (var symbol in input)
            {
                if (symbol > Math.Min(first, second) && symbol < Math.Max(first, second))
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }


    }
}
