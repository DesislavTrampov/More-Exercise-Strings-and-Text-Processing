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
            List<Person> list = new List<Person>();
            int count = int.Parse(Console.ReadLine());

            for(int i =0; i< count; i++)
            {
                string comand = Console.ReadLine();

                string[] token = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(token[0], int.Parse(token[1]));
                list.Add(person);

            }
            var newList = list.OrderBy(x=>x.Age).ThenBy(x=>x.Age).Take(1).ToList();

           foreach(Person person in newList)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }


        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string  Name { get; set; }
        public int Age { get; set; }
    }
}
