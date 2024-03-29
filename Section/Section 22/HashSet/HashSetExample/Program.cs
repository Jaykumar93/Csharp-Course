﻿using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main()
        {
            //create an object of HashSet
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            //Add
            messages.Add("Good Luck");

            //Remove
            messages.Remove("Have a good day");

            //Remove
            messages.RemoveWhere(m => m.EndsWith("You"));

            //Search
            bool b = messages.Contains("Good Morning");
            Console.WriteLine("Contains: " + b);

            //Count
            Console.WriteLine("Count: " + messages.Count);

            //foreach
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("\n________________________________________________________________________________]\n");

            Console.WriteLine("Union with method");

            //create two HashSet's
            HashSet<string> Employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };
            HashSet<string> Employees2022 = new HashSet<string>() { "John", "Scott", "Smith", "David" };
            HashSet<string> Employees2023 = new HashSet<string>() { "John", "Sam", "Smith", "Kumar" };

            //Union
            Employees2021.UnionWith(Employees2022);
            foreach (string item in Employees2021)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n________________________________________________________________________________]\n");

            //IntersectWith
            Console.WriteLine("IntersectWith Method");

            Employees2022.IntersectWith(Employees2023);
            foreach (string item in Employees2022)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
