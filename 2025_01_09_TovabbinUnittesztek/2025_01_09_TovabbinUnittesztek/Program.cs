﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_09_TovabbinUnittesztek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdatOsztaly a = new AdatOsztaly();
            Console.WriteLine(a.OsszegzestolNig(10000));

            Console.ReadLine();
        }
    }
}
