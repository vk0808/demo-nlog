﻿using System;

namespace SessionNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \nEnter a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumbers add = new AddNumbers();
            Console.WriteLine($"Result is {add.Sum(a,b)}");
        }
    }
}
