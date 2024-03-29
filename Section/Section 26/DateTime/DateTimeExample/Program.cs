﻿using System;
using System.Collections.Generic;

namespace DateTimeExample
{
    class Person
    {
        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class Program
    {
        static void Main()
        {
            DateTime dt = DateTime.Parse("2000-12-31 11:59:59.999 am");
            string str1 = dt.ToString();
            string str2 = dt.ToShortDateString();
            string str3 = dt.ToLongDateString();
            string str4 = dt.ToShortTimeString();
            string str5 = dt.ToLongTimeString();


            string custom = dt.ToString("dd-MM-yyyy HH:mm:ss");

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);



            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            // To define day as per our need we can do the follow
            DateTime Mine = DateTime.ParseExact("31/12/2020 23:59:59", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);



            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");



            Console.WriteLine("\"2000-12-31 11:59:59.999 am\"");
            Person person1 = new Person();
            person1.PersonName = "Miller";
            person1.DateOfBirth = DateTime.Parse("2000-12-31 11:59:59.999 am");
            Console.WriteLine(person1.DateOfBirth.ToString());




            Console.WriteLine("Day " + person1.DateOfBirth.Day);
            Console.WriteLine("Month " + person1.DateOfBirth.Month);
            Console.WriteLine("Year " + person1.DateOfBirth.Year);
            Console.WriteLine("Hours " + person1.DateOfBirth.Hour);
            Console.WriteLine("Minutes " + person1.DateOfBirth.Minute);
            Console.WriteLine("Seconds " + person1.DateOfBirth.Second);
            Console.WriteLine("Milliseconds " + person1.DateOfBirth.Millisecond);
            Console.WriteLine("Day of week " + person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of week " + (int)person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of year " + person1.DateOfBirth.DayOfYear);

            DateTime time = DateTime.Now;
            Console.WriteLine(dt.ToString());

            Console.ReadKey();
        }
    }
}
