﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = Double.Parse(Console.ReadLine());
            var km = miles * 1.60934;
            Console.WriteLine($"{km:F2}");
        }
    }
}
