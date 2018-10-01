using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5_17
{
    class MyClass
    {
        public int Calc(int a, int b = 3)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            int r0 = mc.Calc(5, 6);
            int r1 = mc.Calc(5);
            Console.WriteLine("{0},{1}", r0,r1);
        }
    }
}
