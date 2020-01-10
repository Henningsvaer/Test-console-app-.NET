﻿using System;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace SomeTestsConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("SomeTestsConsoleApp.Person", false, true);

            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Console.ReadKey();
        }
    }
}
