﻿using System;

namespace Beecrowd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine($"SOMA = {SOMA}");
            Console.Read();
        }
    }
}
