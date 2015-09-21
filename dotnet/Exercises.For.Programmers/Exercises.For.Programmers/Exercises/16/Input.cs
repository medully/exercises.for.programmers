﻿using System;
using System.Text;

namespace Exercises.For.Programmers.Exercises._16
{
    static class Input
    {
        public static int ParseInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                }
            }
        }

        public static decimal DecimalParse(string message)
        {
            while (true)
            {
                Console.Write(message);

                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                }
            }
        }

        public static string ParseString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}