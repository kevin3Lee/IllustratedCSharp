using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_13._10
{
    delegate void PrintFunction(); // define a delegate type with no parameters (and no return value)

    class Test
    {
        public void Print1()
        {
            Console.WriteLine("Print1: instance");
        }
        public static void Print2()
        {
            Console.WriteLine("Print2: static");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(); // create a class instance.
            PrintFunction pf; // create a null delegate.

            pf = t.Print1; // instantiate and initialize the delegate.

            // add 3 more methods to the delegate obj: pf
            pf += Test.Print2; // Print2 must be static.
            pf += t.Print1;
            pf += Test.Print2;

            //
            if (null != pf)
                pf();
            else
                Console.WriteLine("Delegate is empty.");
        }
    }
}
