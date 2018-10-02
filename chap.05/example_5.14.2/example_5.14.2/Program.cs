using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5_14_2
{
    class MyClass
    {
        public void ListInts(params int[] inVals)
        {
            if ((inVals != null) && (inVals.Length != 0))
                for (int i = 0; i < inVals.Length; i++)
                {
                    inVals[i] = inVals[i] * 10;
                    Console.WriteLine("{0}", inVals[i]);
                }
        }
    }
    //
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 6, 7 };

            MyClass mc = new MyClass();
            mc.ListInts(myArray);//数组作为实参

            foreach (int x in myArray)
            {
                Console.WriteLine("{0}", x);
            }
        }
    }
}
