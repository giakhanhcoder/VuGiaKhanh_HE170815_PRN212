﻿namespace Exercise_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive: ");

            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
    }
}
