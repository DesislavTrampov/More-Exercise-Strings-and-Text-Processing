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

            int count = int.Parse(Console.ReadLine());

            for (int i =0; i< count; i++)
            {
                string input = Console.ReadLine();

                int startindex = input.IndexOf('@');
                int lastindex = input.LastIndexOf('|');

                string name = input.Substring(startindex+1, lastindex-startindex-1);

                int startindexofAge = input.IndexOf('#');
                int lastindexofAge = input.LastIndexOf('*');

                string age = input.Substring(startindexofAge + 1, lastindexofAge - startindexofAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }


        }
        
        
    }
}
