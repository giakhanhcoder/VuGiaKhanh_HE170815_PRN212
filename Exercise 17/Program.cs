﻿namespace Exercise_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("Input a string : ");
            str = Console.ReadLine(); 

            if(str.Length > 0)
            {
                var s = str.Substring(0, 1);

                Console.WriteLine(s + str + s);
            }

        }

    }
}
