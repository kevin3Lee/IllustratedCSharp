﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6._3
{
    class D
    {
        public int Mem1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d1 = new D();
            D d2 = new D();
            d1.Mem1 = 10;
            d2.Mem1 = 28;

            Console.WriteLine("d1 = {0}, d2 = {1}", d1.Mem1, d2. Mem1);
        }
    }
}
