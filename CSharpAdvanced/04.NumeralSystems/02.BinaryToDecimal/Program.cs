﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToUInt64(Console.ReadLine(), 2).ToString());
        }
    }
}
